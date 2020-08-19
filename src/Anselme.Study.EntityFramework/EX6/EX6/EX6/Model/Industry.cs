using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX6.Model
{
    public class Industry: ModelBase
    {
        public int MarketShare { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Market> Markets { get; set; }
    }
}
