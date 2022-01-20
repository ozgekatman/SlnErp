using Microsoft.EntityFrameworkCore;
using SlnErp102.Core.Models.Stocks.Products;
using SlnErp102.Core.Repository.Stocks.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnErp102.Data.Repository.Stocks.Products
{
    public class ProductEntryRepository : Repository<ProductEntry>, IProductEntryRepository
    {
        private SlnDbContext SlnDbContext { get => _db as SlnDbContext; }

        public ProductEntryRepository(SlnDbContext db) : base(db)
        {
        }
        public async Task<IEnumerable<ProductEntry>> DistinctListByCompany()
        {
            IEnumerable<ProductEntry> query = await SlnDbContext.ProductEntries.Include("Company")
                .GroupBy(x => new { x.CompanyId, x.EntryDate, x.InvoiceNumber,x.Company.Name }).Select(g => g.First()).ToListAsync();
            return query;
        }
    }
}
