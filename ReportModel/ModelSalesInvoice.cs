using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportModel
{
    public class ModelSalesInvoice
    {
        public ModelSalesInvoice()
        {
            ProductOrderDetail = new List<ProductOrderDetail>();
        }
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string SallerName { get; set; }
        public string SallerAddress { get; set; }
        public string CompanyImage { get; set; }
        public DateTime OrderDate { get; set; }
        public string SallerPhone { get; set; }
        public string CustomerPhone { get; set; }
        public string SalesPersonName { get; set; }
        public decimal OrderToal { get; set; }
        public decimal DiscountOnTotal { get; set; }
        public decimal PriceAfterToal { get; set; }
        public decimal AmountDebit { get; set; }
        public decimal AmountCredit { get; set; }
        public decimal RemainingBalance { get; set; }
        public string PaymentType { get; set; }
        
        public List<ProductOrderDetail> ProductOrderDetail { get; set; }
    }

    public class ProductOrderDetail
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductConfig1 { get; set; }
        public string ProductConfig2 { get; set; }
        public string ProductDesc { get; set; }
        public string ProductCategory { get; set; }
        public decimal ProductPricePerUnit { get; set; }
        public decimal ProductActualPrice { get; set; }
        public decimal ProductDiscount { get; set; }
        public int ProductQuantity { get; set; }
        public decimal ProductFinalPrice { get; set; }
        public decimal ProductDiscountAmount { get; set; }
        public int SrNo { get; set; }
    }
}
