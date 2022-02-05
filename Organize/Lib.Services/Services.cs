using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Services
{
    public class Services
    {


        public static TarefaService Tarefa()
        {
            return new TarefaService();
        }


    }
}
