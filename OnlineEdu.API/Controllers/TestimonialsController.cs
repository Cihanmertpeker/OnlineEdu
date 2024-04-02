using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.Dto.Dtos.AboutDtos;
using OnlineEdu.Dto.Dtos.TestimonialDto;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController(IGenericService<Testimonial> _testimonialService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _testimonialService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _testimonialService.TGetById(id);
            return Ok(value);
        }

        [HttpGet("{id}")]
        public IActionResult Delete(int id)
        {
            _testimonialService.TDelete(id);
            return Ok("Değer Başarıyla Silindi");
        }

        [HttpPost]
        public IActionResult Create(CreateTestimonialDto createTestimonialDto)
        {
            var newValue = _mapper.Map<Testimonial>(createTestimonialDto);
            _testimonialService.TCreate(newValue);
            return Ok("Değer Başarıyla Oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateTestimonialDto updateTestimonialDto)
        {
            var value = _mapper.Map<Testimonial>(updateTestimonialDto);
            _testimonialService.TUpdate(value);
            return Ok("Değer Başarıyla Güncellendi");

        }
    }
}
