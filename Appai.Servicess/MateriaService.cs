using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appai.Repositorys;
using Appai.Domain;

namespace Appai.Services
{
    public class MateriaService
    {
        public bool Cadastrar(string nome)
        {
            return MateriasRepository.CadastroMateria(nome);
        }
        public bool Remover(int id )
        {
          return MateriasRepository.RemoverMateria(id);
        }

        public List<Materia> GetMaterias()
        {
            return MateriasRepository.materias;
        }
        public Materia Localizar(int id)
        {
            return MateriasRepository.Localizar(id);
        }
    }
}

