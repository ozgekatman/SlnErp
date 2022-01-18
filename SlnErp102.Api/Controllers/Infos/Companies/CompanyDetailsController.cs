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
    public class CompanyDetailsController : ControllerBase
    {
        private readonly ICompanyDetailService _service;
        private readonly IMapper _mapper;

        public CompanyDetailsController(ICompanyDetailService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CompanyDetail>>> GetCompanyDetail()
        {
            var c = await _service.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<CompanyDetailDto>>(c));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CompanyDetail>> GetCompanyDetail(int id)
        {
            var companyDetail = await _service.GetByIdAsync(id);

            if (companyDetail == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<CompanyDetailDto>(companyDetail));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompanyDetail(int id, CompanyDetailDto companyDetailDto)
        {
            if (id != companyDetailDto.Id)
            {
                return BadRequest();
            }

            var cd = await _service.GetByIdAsync(id);
            cd.CompanyId = companyDetailDto.Id;
            cd.Email = companyDetailDto.Email;
            cd.Phone = companyDetailDto.Phone;
            cd.Fax = companyDetailDto.Fax;
            cd.Gsm = companyDetailDto.Gsm;
            cd.Officer = companyDetailDto.Officer;
            cd.DepartmentId = companyDetailDto.DepartmentId;

            _service.Update(cd);
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<CompanyDetail>> PostCompanyDetail(CompanyDetailDto companyDetailDto)
        {
            var c = await _service.AddAsync(_mapper.Map<CompanyDetail>(companyDetailDto));

            return Created(String.Empty, _mapper.Map<CompanyDetailDto>(c));
        }

        // DELETE: api/CompanyDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompanyDetail(int id)
        {
            var companyDetail = await _service.GetByIdAsync(id);
            if (companyDetail == null)
            {
                return NotFound();
            }
            _service.Remove(companyDetail);
            return NoContent();
        }
    }
}
