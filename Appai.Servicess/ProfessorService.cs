using Appai.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appai.Domain;

namespace Appai.Services
{
    public class ProfessorService
    {

        public List<Professor> getProfessor()
        {
            return ProfessorRepository.profe;
        }
        public bool Cadastrar(string nome, string email)
        {
            return ProfessorRepository.CadastroProfessor(nome, email);
        }
        public void CadastrarMateria(int id, Materia materia)
        {
            ProfessorRepository.CadastrarMateria(id, materia);
        }
        public bool MateriaVerifica(Professor professor)
        {
            return ProfessorRepository.MateriaVerificar(professor);
        }

        public bool Remover(int id)
        {
            return ProfessorRepository.RemoverProfessor(id);
        }
        public bool StatusFinan(Professor profess)
        {
            return ProfessorRepository.SituaçãoFina(profess);
        }
        public Professor localizarP(int id)
        {
            return ProfessorRepository.localizar(id);
        }
        public void PagarProfe(int id)
        {
            ProfessorRepository.PagarProfe(id);
        }
    }

}