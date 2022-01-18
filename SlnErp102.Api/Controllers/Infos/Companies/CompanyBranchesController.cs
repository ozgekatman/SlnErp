#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SlnErp102.Api.DTOs.Info.Companies;
using SlnErp102.Core.Models.Infos.Companies;
using SlnErp102.Core.Service.Infos.Companies;

namespace SlnErp102.Api.Controllers.Infos.Companies
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyBranchesController : ControllerBase
    {

        private readonly ICompanyBranchService _service;
        private readonly IMapper _mapper;

        public CompanyBranchesController(ICompanyBranchService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CompanyBranch>>> GetCompanyBranch()
        {
            var c= await _service.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<CompanyBranchDto>>(c));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CompanyBranch>> GetCompanyBranch(int id)
        {
            var companyBranch = await _service.GetByIdAsync(id);

            if (companyBranch == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<CompanyBranchDto>(companyBranch));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompanyBranch(int id, CompanyBranchDto companyBranchDto)
        {
            if (id != companyBranchDto.Id)
            {
                return BadRequest();
            }

            var c=await _service.GetByIdAsync(id);
            c.Name= companyBranchDto.Name;
            c.Address= companyBranchDto.Address;
            c.InvoiceTitle= companyBranchDto.InvoiceTitle;
            c.CityId= companyBranchDto.CityId;
            c.CompanyId= companyBranchDto.CompanyId;
            _service.Update(c);
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<CompanyBranch>> PostCompanyBranch(CompanyBranchDto companyBranchDto)
        {
            var c=await _service.AddAsync(_mapper.Map<CompanyBranch>(companyBranchDto));

            return Created(String.Empty,_mapper.Map<CompanyBranchDto>(c));
        }

        // DELETE: api/CompanyBranches/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompanyBranch(int id)
        {
            var companyBranch = await _service.GetByIdAsync(id);
            if (companyBranch == null)
            {
                return NotFound();
            }
            _service.Remove(companyBranch);
            return NoContent();
        }
    }
}
