using Appai.Domain;
using Appai.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Appai.Repositorys
{
    public static class AlunosRepository
    {
        public static List<Aluno> alunos = new List<Aluno>();

        public static void AddList(Aluno alunos)
        {
            AlunosRepository.alunos.Add(alunos);
        }
        public static bool RemoverAluno(int id)
        {


            bool achei = false;

            for (int i = 0; i < alunos.Count; i++)
            {
                if (id == alunos[i].Id)
                {
                    achei = true;
                    alunos.RemoveAt(i);

                    break;

                }
            }
            return achei;
        }

        public static int AlunoId()
        {

            if (alunos == null)
            {
                return 0;
            }
            int idMaior = -1;
            for (int i = 0; i < alunos.Count; i++)
            {
                if (alunos[i].Id > idMaior)
                {
                    idMaior = alunos[i].Id;
                }
            }

            return ++idMaior;
        }
        public static void CadastrarNota(int id, Materia materia, double nota)
        {
            for (int i = 0; i < alunos.Count; i++)
            {
                if (id == alunos[i].Id)
                {
                    for (int j = 0; j < alunos[i].Materia.Count; j++)
                    {
                        if (materia.Id == alunos[i].Materia[j].Id)
                        {
                            alunos[i].Materia[j].Nota = nota;
                            break;
                        }
                    }

                }
            }

        }

            public static bool CadastroAluno(string nome, string email)
        {


            int id = AlunoId();

            Aluno aluno = new Aluno(nome, email, id);

            bool achei = true;

            for (int i = 0; i < alunos.Count; i++)
            {
                if (email == alunos[i].Email)
                {
                    achei = false;

                    break;
                }

            }
            if (achei)
            {
                AddList(aluno);
            }

            return achei;




        }
        public static bool MateriaVerificar(Aluno aluno, int id)
        {
            for(int i = 0; i < aluno.Materia.Count; i++)
            {
                if(id == aluno.Materia[i].Id)
                {
                    return true;
                }
            }
            return false;
        }
        
        public static void CadastrarMateria(int id, Materia materia)
        {
            for (int i = 0; i < alunos.Count; i++)
            {
                if (id == alunos[i].Id)
                {
                    alunos[i].Materia.Add(materia);
                }
            }
            
        }
        
        public static Aluno localizar(int id)
        {

            for (int i = 0; i < alunos.Count; i++)
            {
                if (id == alunos[i].Id)
                {
                    return alunos[i];
                }
            }

            return null;

        }
        public static bool SituaçãoFina(Aluno alunos)
        {
            if (alunos.Status == "Pago")
            {
                return true;
            }
            return false;
        }

        public static void PagarAluno(int id)
        {
            for (int i = 0; i < alunos.Count; i++)
            {
                if (id == alunos[i].Id)
                {
                    alunos[i].Status = "Pago";
                }
            }

        }

    }
}
