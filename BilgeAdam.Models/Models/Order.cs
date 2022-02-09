using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Models.Models
{
    public class Order
    {
        public string No { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public string CustomerName { get; set; }
        public double TotalPayment { get; set; }
        public OrderDetail OrderDetail { get; set; }
        public override string ToString()
        {
            return $"{No}.{CustomerName}/{Note}";
        }
    }
}
