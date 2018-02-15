using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportModel
{
   public class SaleReturn
   {
       int CustomerId { get; set; }
       int OrderId { get; set; }
       string OrderDate { get; set; }
       public string ProductName { get; set; }
       public string ProductCategory { get; set; }
       public string ProductConfig1 { get; set; }
       public string ProductConfig2 { get; set; }
       public double ProductPrice { get; set; }
       public int ProductQuantity { get; set; }
       public double ProductTOTAL { get; set; }
       public double ProductDiscount { get; set; }
       public double GrandTotalSales { get; set; }
   

    }
}
