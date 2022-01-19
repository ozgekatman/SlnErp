﻿namespace SlnErp102.Api.DTOs.Stocks.Product
{
    public class ProductEntryDto
    {
        public int Id { get; init; }
        public int CompanyId { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime EntryDate { get; set; }
        public int ProductId { get; set; }
        public string LotSerial { get; set; }
        public int Quantity { get; set; }
        public int EntryTypeId { get; set; }
        //public int SurgerySide { get; set; }
        //public int SurgeryType { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
