using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCControleDeAcesso.Models
{
    public class Entrada
    {
        public int id { get; set; }
        public int idAluno { get; set; }
        public string nome { get; set; }
        public string dataEntrada { get; set; }
        public int idEscola { get; set; }
        public virtual Escola Escola { get; set; }

    }
}
