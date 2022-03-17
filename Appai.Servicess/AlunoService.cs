using Appai.Domain;
using Appai.Domains;
using Appai.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appai.Services
{

    public class AlunoService
    {

        public List<Aluno> getAlunos()
        {
            return AlunosRepository.alunos;
        }

        public bool Remover(int id )
        {

            return AlunosRepository.RemoverAluno(id);
        }

        public bool Cadastrar(string nome, string email)
        {
           return AlunosRepository.CadastroAluno( nome, email);

        }
        
        public bool MateriaVerifica(Aluno aluno, int id)
        {
            return AlunosRepository.MateriaVerificar(aluno, id);
        }

        public void CadastrarMateria(int id, Materia materia)
        {
            AlunosRepository.CadastrarMateria(id, materia);
        }

        public void CadastrarNota(int id, Materia materia, double nota)
        {
            AlunosRepository.CadastrarNota(id,materia,nota);
        }
        public bool StatusFinan(Aluno aluno)
        {
            return AlunosRepository.SituaçãoFina(aluno);
        }
        public Aluno localizarP(int id)
        {
            return AlunosRepository.localizar(id);
        }
        public void PagarAluno(int id)
        {
            AlunosRepository.PagarAluno(id);
        }
    }
}
