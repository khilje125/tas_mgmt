using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportModel
{
   public class SalesModel
    {
       
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public string ProductConfig1 { get; set; }
        public string ProductConfig2 { get; set; }
        public decimal ProductPrice { get; set; }
         public int ProductQuantity { get; set; }
        public decimal ProductTOTAL { get; set; }
        public decimal ProductDiscount { get; set; }
        public decimal ProductDiscountAmount { get; set; }
        public decimal ProductFinalPrice { get; set; }
        public decimal GrandTotalSales { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
      
    }

    public class CurrentStock
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public decimal PerUnitPrice { get; set; }
        public decimal ActualPrice { get; set; }
        public decimal DefaultDiscountInPercent { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal PriceAfterDiscount { get; set; }
       

    }
}
