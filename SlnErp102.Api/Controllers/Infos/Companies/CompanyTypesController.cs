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
    public class CompanyTypesController : ControllerBase
    {
        private readonly ICompanyTypeService _service;
        private readonly IMapper _mapper;

        public CompanyTypesController(ICompanyTypeService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CompanyType>>> GetCompanyType()
        {
            var c = await _service.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<CompanyTypeDto>>(c));
        }

        // GET: api/CompanyTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CompanyType>> GetCompanyType(int id)
        {
            var companyType = await _service.GetByIdAsync(id);

            if (companyType == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<CompanyTypeDto>(companyType));
        }

        // PUT: api/CompanyTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompanyType(int id, CompanyTypeDto companyTypeDto)
        {
            if (id != companyTypeDto.Id)
            {
                return BadRequest();
            }
            var ct = await _service.GetByIdAsync(id);
            ct.Name = companyTypeDto.Name;
            _service.Update(ct);
            return NoContent();
        }

        // POST: api/CompanyTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CompanyType>> PostCompanyType(CompanyTypeDto companyTypeDto)
        {
            var c = await _service.AddAsync(_mapper.Map<CompanyType>(companyTypeDto));

            return Created(String.Empty, _mapper.Map<CompanyTypeDto>(c));
        }

        // DELETE: api/CompanyTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompanyType(int id)
        {
            var companyType = await _service.GetByIdAsync(id);
            if (companyType == null)
            {
                return NotFound();
            }
            _service.Remove(companyType);
            return NoContent();
        }
    }
}
