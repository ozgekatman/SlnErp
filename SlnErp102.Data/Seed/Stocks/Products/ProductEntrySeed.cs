using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SlnErp102.Core.Models.Stocks.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnErp102.Data.Seed.Stocks.Products
{
    public class ProductEntrySeed : IEntityTypeConfiguration<ProductEntry>
    {
        public void Configure(EntityTypeBuilder<ProductEntry> builder)
        {
            builder.HasData(
                new ProductEntry
                {
                    Id = 1,
                    Barcode = "AR-1000/1",
                    CompanyId = 1,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    EntryTypeId = 1,
                    ExpirationDate = DateTime.Now,
                    InvoiceNumber = "1234",
                    ProductId = 1,
                    ProductionDate = DateTime.Now,
                    LotSerial = "1",
                    Quantity = 100,
                    Description = "Test1",
                    ModifiedUser = "system",
                    EntryDate = DateTime.Now
                },
                new ProductEntry
                {
                    Id = 2,
                    Barcode = "AR-1000/2",
                    CompanyId = 1,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    EntryTypeId = 1,
                    ExpirationDate = DateTime.Now,
                    InvoiceNumber = "1234",
                    ProductId = 1,
                    ProductionDate = DateTime.Now,
                    LotSerial = "2",
                    Description = "Test2",
                    Quantity = 100,
                    ModifiedUser="system" ,
                    EntryDate = DateTime.Now
                },
                new ProductEntry
                {
                    Id = 3,
                    Barcode = "AR-1001/1",
                    CompanyId = 1,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    EntryTypeId = 1,
                    ExpirationDate = DateTime.Now,
                    InvoiceNumber = "1234",
                    ProductId = 2,
                    ProductionDate = DateTime.Now,
                    LotSerial = "1",
                    Description = "Test3",
                    Quantity = 75,
                    ModifiedUser = "system",
                    EntryDate = DateTime.Now

                },
                new ProductEntry
                {
                    Id = 4,
                    Barcode = "AR-1002/1",
                    CompanyId = 1,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    EntryTypeId = 1,
                    ExpirationDate = DateTime.Now,
                    InvoiceNumber = "4321",
                    ProductId = 3,
                    ProductionDate = DateTime.Now,
                    LotSerial = "1",
                    Description = "Test4",
                    Quantity = 50,
                    ModifiedUser = "system",
                    EntryDate = DateTime.Now
                }
                );
        }
    }
}
