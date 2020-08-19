using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX6.Model
{
    public class Market: ModelBase
    {
        public string Name { get; set; }
        public int CommonCustomerSpecificationID { get; set; }
        public CustomerSpecification CommonCustomerSpecification { get; set; }
        public virtual ICollection<Industry> Industries { get; set; }
    }
}
