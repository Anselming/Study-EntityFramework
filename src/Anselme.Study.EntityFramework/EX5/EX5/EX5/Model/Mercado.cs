using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5.Model
{
    public class Mercado
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        
        public DateTime DataDoInicioDeOperacao { get; set; }
        public bool EmOperacao { get; set; }
        public string Detalhes { get; set; }
    }
}
