using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lib.Data.Entities
{
    public class Tarefa :BaseDal
    {
        public bool Feito { get; set; }
        public string Nome { get; set; }
    }
}
