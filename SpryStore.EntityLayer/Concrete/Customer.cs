using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryStore.EntityLayer.Concrete
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerMail { get; set; }
        public string CustomerCity { get; set; }
        public int CustomerBonus { get; set; }
    }
}
