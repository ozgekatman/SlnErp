using SlnErp102.Core.Models.Infos.Companies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnErp102.Core.Models.Stocks.Products
{
    public  class ProductEntry:BaseEntity//Lot bazlı ürün girişi
    {
        public int CompanyId { get; set; }
        public int ProductId { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime EntryDate{ get; set; }
        public string LotSerial { get; set; }//Buna gerek yok bence barcode bazlı giriş yapılıyor
        public int  Quantity { get; set; }
        public int EntryTypeId { get; set; }
        //public int SurgerySide { get; set; }//çıkar
        //public int SurgeryType { get; set; }//çıkar
        public string Barcode { get; set; }
        public string Description { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public virtual Company? Company { get; set; }
        public virtual Product? Product{ get; set; }

        //KDV eksik Fatura Genel No yok
        //Hangi company branche fatura kesilcek?
    }
}
