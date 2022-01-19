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
    public class StockStatesController : ControllerBase
    {
        private readonly IStockStateService _service;
        private readonly IMapper _mapper;
        public StockStatesController(IStockStateService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<StockState>>> GetStockState()
        {
            var sto = await _service.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<StockStateDto>>(sto));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<StockState>> GetStockState(int id)
        {
            var sto = await _service.GetByIdAsync(id);
            return Ok(sto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutStockState(int id, StockStateDto stockStateDto)
        {
            if (id != stockStateDto.Id)
            {
                return BadRequest();
            }
            var sto = await _service.GetByIdAsync(id);
            sto.ProductCode=stockStateDto.ProductCode;
            sto.LotSerial=stockStateDto.LotSerial;
            sto.ShelfQuantity=stockStateDto.ShelfQuantity;
            sto.StockQuantity=stockStateDto.StockQuantity;
            sto.ConsigneeQuantity=stockStateDto.ConsigneeQuantity;
            sto.BranchQuantity=stockStateDto.BranchQuantity;
            sto.TransferedProductQuantity=stockStateDto.TransferedProductQuantity;
            _service.Update(_mapper.Map<StockState>(sto));
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<StockState>> PostStockState(StockStateDto stockStateDto)
        {
            var sto = await _service.AddAsync(_mapper.Map<StockState>(stockStateDto));
            return Created(string.Empty, _mapper.Map<ProductEntryDto>(sto));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStockState(int id)
        {
            var pro = await _service.GetByIdAsync(id);
            _service.Remove(pro);
            return NoContent();
        }
    }
}
