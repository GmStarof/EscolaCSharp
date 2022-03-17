using Appai.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appai.Repositorys
{
   
        public static class MateriasRepository
    {
        public static List<Materia> materias = new List<Materia>();
        public static void AddList(Materia materia)
        {
            materias.Add(materia);
        }

        public static bool CadastroMateria(string nome)
        {

           

                int id = MateriaId();

                Materia materia = new Materia(nome, id);

                bool achei = true;

                for (int i = 0; i < materias.Count; i++)
                {
                    if (nome == materias[i].Nome)
                    {
                        achei = false;
                        
                        break;
                    }

                }
                if (achei)
                {
                      AddList(materia);

                }
                
            return achei;
                
            
        }
        public static Materia Localizar(int id)
        {

            for (int i = 0; i < materias.Count; i++)
            {
                if (id == materias[i].Id)
                {
                    return materias[i];
                }
            }

            return null;

        }

        public static bool RemoverMateria(int id )
        {
            
            bool achei = false;

            for (int i = 0; i < materias.Count; i++)
            {
                if (id == materias[i].Id)
                {
                    achei = true;
                    materias.RemoveAt(i);

                    break;
                }
            }
            return achei;
        }

        public static int MateriaId()
        {

            if (materias == null)
            {
                return 0;
            }
            int idMaior = -1;
            for (int i = 0; i < materias.Count; i++)
            {
                if (materias[i].Id > idMaior)
                {
                    idMaior = materias[i].Id;
                }
            }

            return ++idMaior;
        }

    }

}
