using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportModel
{
   public class CustomerSalesRetrun
    {

        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public string OrderDate { get; set; }
        public string CustomerName { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
       
        public decimal ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public decimal ProductTOTAL { get; set; }
        public decimal ProductDiscount { get; set; }

        public decimal AfterDisPrice { get; set; }
    }
}
