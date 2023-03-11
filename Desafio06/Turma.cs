using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio06
{
    public class Turma
    {
        public string NomeDisciplina { get; private set; }
        public List<Aluno> Alunos { get; private set; }
        public string AproveitamentoAlunos { get; private set; }

        public Turma(string nomeDisciplina)
        {
            this.NomeDisciplina = nomeDisciplina;
            this.Alunos = new List<Aluno>();
        }

        public void AdicionarAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
        }

        public void RemoverAlunoPorNome(string nomeAluno)
        {
            List<Aluno> busca = Alunos.FindAll(n => n.Nome.Contains(nomeAluno));
            Alunos.Remove(busca[0]);
        }

        public void LancarNotas(Aluno aluno, float notaA, float notaB)
        {
            aluno.AdicionarNotas(notaA, notaB);
        }

        public string GerarAproveitamentoDosAlunos()
        {
            string aproveitamentoAlunos = "Aproveitamento dos alunos:\n";
            foreach (Aluno aluno in this.Alunos)
            {
                string situacao = aluno.Aprovado == true ? "Aprovado" : "Reprovado";
                aproveitamentoAlunos += $"Nome: {aluno.Nome}\nNota A: {aluno.NotaA}\nNota B: {aluno.NotaB}\nSituação: {situacao}\n\n";
            }

            return aproveitamentoAlunos;
        }

    }
}
