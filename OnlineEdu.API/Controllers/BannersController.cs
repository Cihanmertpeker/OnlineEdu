using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.Dto.Dtos.AboutDtos;
using OnlineEdu.Dto.Dtos.BannerDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController(IGenericService<Banner> _bannerService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _bannerService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _bannerService.TGetById(id);
            return Ok(value);
        }

        [HttpGet("{id}")]
        public IActionResult Delete(int id)
        {
            _bannerService.TDelete(id);
            return Ok("Değer Başarıyla Silindi");
        }

        [HttpPost]
        public IActionResult Create(CreateBannerDto createBannerDto)
        {
            var newValue = _mapper.Map<Banner>(createBannerDto);
            _bannerService.TCreate(newValue);
            return Ok("Değer Başarıyla Oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateBannerDto updateBannerDto)
        {
            var value = _mapper.Map<Banner>(updateBannerDto);
            _bannerService.TUpdate(value);
            return Ok("Değer Başarıyla Güncellendi");

        }
    }
}
