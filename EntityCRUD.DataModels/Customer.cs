using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCRUD.DataModels
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        //reverse lookup
        public virtual List<Order> Orders { get; set; }
    }
}
