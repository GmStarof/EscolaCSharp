using Appai.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appai.Domains;

namespace Appai.Repositorys
{
    public static class ProfessorRepository
    {
        public static List<Professor> profe = new List<Professor>();


        public static void AddList(Professor professor)
        {
            ProfessorRepository.profe.Add(professor);
        }
        public static void SalarioProfessor()
        {

        }
        public static bool CadastroProfessor(string nome, string email)
        {

            int id = ProfessorId();

            Professor professor = new Professor(nome, email, id);

            bool achei = true;

            for (int i = 0; i < profe.Count; i++)
            {
                if (email == profe[i].Email)
                {
                    achei = false;

                    break;
                }

            }
            if (achei)
            {
                AddList(professor);
            }

            return achei;
        }
            public static int ProfessorId()
        {
            if (profe == null)
            {
                return 0;
            }
            int idMaior = -1;
            for (int i = 0; i < profe.Count; i++)
            {
                if (profe[i].Id > idMaior)
                {
                    idMaior = profe[i].Id;
                }
            }

            return ++idMaior;
        }
        public static bool RemoverProfessor(int id)
        {


            bool achei = false;

            for (int i = 0; i < profe.Count; i++)
            {
                if (id == profe[i].Id)
                {
                    achei = true;
                    profe.RemoveAt(i);

                    break;

                }
            }
            return achei;
        }
        public static bool MateriaVerificar(Professor professor)
        {
            if (professor.Materia != null)
            {
                return true;
            }
            return false;
        }
        public static void CadastrarMateria(int id, Materia materia)
        {
            for (int i = 0; i < profe.Count; i++)
            {
                if (id == profe[i].Id)
                {
                    profe[i].Materia = materia;
                }
            }

        }
        public static Professor localizar(int id)
        {
            
            for (int i = 0; i < profe.Count; i++)
            {
                if (id == profe[i].Id)
                {
                    return profe[i];
                }
            }
           
            return null;

        }
        public static bool SituaçãoFina(Professor profess)
        {
            if(profess.Status == "Pago")
            {
                return true;
            }
            return false;
        }

        public static void PagarProfe(int id)
        {
            for (int i = 0; i < profe.Count; i++)
            {
                if (id == profe[i].Id)
                {
                     profe[i].Status = "Pago";
                }
            }

        }
    }
}