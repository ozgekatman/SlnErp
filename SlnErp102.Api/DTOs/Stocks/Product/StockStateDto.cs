namespace SlnErp102.Api.DTOs.Stocks.Product
{
    public class StockStateDto
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string LotSerial { get; set; }
        public int StockQuantity { get; set; }
        public int ShelfQuantity { get; set; }
        public int BranchQuantity { get; set; } 
        public int ConsigneeQuantity { get; set; }
        public int TransferedProductQuantity { get; set; } 
    }
}
