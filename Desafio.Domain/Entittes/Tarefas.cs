using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Domain.Entittes
{
    public sealed class Tarefas
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime DateLimit { get; private set; }

        public Tarefas(int id, string name, string description, DateTime dateLimit)
        {
            Id = id;
            Name = name;
            Description = description;
            DateLimit = dateLimit;
        }

        public Tarefas(string name, string description, DateTime dateLimit)
        {
            
            Name = name;
            Description = description;
            DateLimit = dateLimit;
        }

        private void ValidationTarefas(string name)
        {

        }
    }
}
