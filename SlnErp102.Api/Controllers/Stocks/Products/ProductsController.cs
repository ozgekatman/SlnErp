#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SlnErp102.Api.DTOs.Stocks.Product;
using SlnErp102.Core.Models.Stocks.Products;
using SlnErp102.Core.Service.Stocks.Products;

namespace SlnErp102.Api.Controllers.Stocks.Products
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;
        private readonly IMapper _mapper;

        public ProductsController(IProductService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProduct()
        {
            var pro = await _service.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<ProductDto>>(pro));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var pro = await _service.GetByIdAsync(id);
            return Ok(pro);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, ProductDto productDto)
        {
            if (id != productDto.Id)
            {
                return BadRequest();
            }

            var pro = await _service.GetByIdAsync(id);
            pro.Description = productDto.Description;
            pro.BranchNoId = productDto.BranchNoId;
            pro.EntryDate = productDto.EntryDate;
            pro.Picture = productDto.Picture;
            pro.ProductCode = productDto.ProductCode;
            pro.SutDescription = productDto.SutDescription;
            pro.SutCode = productDto.SutCode;
            pro.SutPrice = productDto.SutPrice;
            pro.CompanyId = productDto.CompanyId;
            _service.Update(_mapper.Map<Product>(pro));
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(ProductDto productDto)
        {
            var pro = await _service.AddAsync(_mapper.Map<Product>(productDto));
            return Created(string.Empty, _mapper.Map<ProductDto>(pro));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var pro = await _service.GetByIdAsync(id);
            _service.Remove(pro);
            return NoContent();
        }
    }
}
