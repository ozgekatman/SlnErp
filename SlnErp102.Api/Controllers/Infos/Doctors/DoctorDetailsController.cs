#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SlnErp102.Api.DTOs.Info.Doctors;
using SlnErp102.Core.Models.Infos.Doctors;
using SlnErp102.Core.Service.Infos.Doctors;

namespace SlnErp102.Api.Controllers.Infos.Doctors
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorDetailsController : ControllerBase
    {
        private readonly IDoctorDetailService _service;
        private readonly IMapper _mapper;

        public DoctorDetailsController(IDoctorDetailService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DoctorDetail>>> GetDoctorDetail()
        {
            var d = await _service.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<DoctorDetailDto>>(d));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DoctorDetail>> GetDoctorDetail(int id)
        {
            var doctorDetail = await _service.GetByIdAsync(id);
            if (doctorDetail == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<DoctorDetailDto>(doctorDetail));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDoctorDetail(int id, DoctorDetailDto doctorDetailDto)
        {
            if (id != doctorDetailDto.Id)
            {
                return BadRequest();
            }

            var d=await _service.GetByIdAsync(id);
            d.Email= doctorDetailDto.Email;
            d.Gsm = doctorDetailDto.Gsm;
            d.Phone= doctorDetailDto.Phone;
            d.Fax= doctorDetailDto.Fax;
            d.HospitalId = doctorDetailDto.HospitalId;
            d.DoctorId= doctorDetailDto.DoctorId;
            _service.Update(d);
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<DoctorDetail>> PostDoctorDetail(DoctorDetailDto doctorDetailDto)
        {
            var d = _service.AddAsync(_mapper.Map<DoctorDetail>(doctorDetailDto));
            return Created(String.Empty,_mapper.Map<DoctorDetailDto>(d));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDoctorDetail(int id)
        {
            var doctorDetail = await _service.GetByIdAsync(id);
            if (doctorDetail == null)
            {
                return NotFound();
            }
            _service.Remove(doctorDetail);
            return NoContent();
        }
    }
}
