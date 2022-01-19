namespace SlnErp102.Api.DTOs
{
    public class ProductEntryDistinct
    {
        public int Id { get; init; }
        public int CompanyId { get; set; }
        public DateTime EntryDate { get; set; }
        public string InvoiceNumber { get; set; }
        public string CompanyName { get; set; }
    }
}
