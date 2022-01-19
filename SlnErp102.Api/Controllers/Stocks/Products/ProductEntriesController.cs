#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SlnErp102.Api.DTOs;
using SlnErp102.Api.DTOs.Stocks.Product;
using SlnErp102.Core.Models.Stocks.Products;
using SlnErp102.Core.Service.Infos.Companies;
using SlnErp102.Core.Service.Stocks.Products;

namespace SlnErp102.Api.Controllers.Stocks.Products
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductEntriesController : ControllerBase
    {
        private readonly IProductEntryService _service;
        private readonly ICompanyService _cservice;
        private readonly IStockStateService _sservice;
        private readonly IMapper _mapper;

        public ProductEntriesController(IProductEntryService service, ICompanyService cservice, IStockStateService sservice, IMapper mapper)
        {
            _service = service;
            _cservice = cservice;
            _sservice = sservice;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductEntry>>> GetProductEntry()
        {
           // var pro = await _service.GetAllAsync();
            var test = await _service.DistinctListByCompany();
            ProductEntryDistinct p = new ProductEntryDistinct();
            foreach (var item in test)
            {
                var company=await _cservice.GetByIdAsync(item.CompanyId);
                if (company == null)
                {
                    return NotFound();
                }
                p.CompanyId=item.CompanyId;
                p.CompanyName=company.Name;
                p.EntryDate = item.EntryDate;
                p.InvoiceNumber=item.InvoiceNumber;
                return Ok(_mapper.Map<ProductEntryDistinctDto>(p));
            }//Product classından distincte doğru mapledik.Eksik var.ProductEntryDistinct classı oluşturmalıyız
            return BadRequest();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductEntry>> GetProductEntry(int id)
        {
            var pro = await _service.GetByIdAsync(id);
            return Ok(pro);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductEntry(int id, ProductEntryDto productEntryDto)
        {
            if (id != productEntryDto.Id)
            {
                return BadRequest();
            }
            var pro = await _service.GetByIdAsync(id);
            pro.CompanyId = productEntryDto.CompanyId;
            pro.InvoiceNumber = productEntryDto.InvoiceNumber;
            pro.EntryDate = productEntryDto.EntryDate;
            pro.ProductId = productEntryDto.ProductId;
            pro.LotSerial = productEntryDto.LotSerial;
            pro.Quantity = productEntryDto.Quantity;
            pro.EntryTypeId = productEntryDto.EntryTypeId;
            //pro.SurgerySide = productEntryDto.SurgerySide;
            //pro.SurgeryType = productEntryDto.SurgeryType;
            pro.Barcode = productEntryDto.Barcode;
            pro.Description = productEntryDto.Description;
            pro.ProductionDate = productEntryDto.ProductionDate;
            pro.ExpirationDate = productEntryDto.ExpirationDate;
            _service.Update(pro);
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<ProductEntry>> PostProductEntry(ProductEntryDto productEntryDto)
        {
            var pro = await _service.AddRangeAsync(_mapper.Map<IEnumerable<ProductEntry>>(productEntryDto));
            //_sservice.AddAsync
            return Created(string.Empty, _mapper.Map<IEnumerable<ProductEntryDto>>(pro));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductEntry(int id)
        {
            var pro = await _service.GetByIdAsync(id);
            _service.Remove(pro);
            return NoContent();
        }
    }
}
