namespace SlnErp102.Api.DTOs.Stocks.Product
{
    public class ProductPostUpDto
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime EntryDate { get; set; }
        public int EntryTypeId { get; set; }
        public string Description { get; set; }
        public List<ProductPostDownDto> Products { get; set; }
    }
}
