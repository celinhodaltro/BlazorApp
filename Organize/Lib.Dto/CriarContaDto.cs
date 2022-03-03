using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Dto
{
    public class CriarContaDto
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string RepetirSenha { get; set; }
        public string Email { get; set; }
        public int Tipo { get; set; }

    }
}
