using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WalksAPI.Models.domain;
using WalksAPI.Repositories;

namespace WalksAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository regionRepository;
        private IMapper mapper;

        public RegionsController(IRegionRepository regionRepository, IMapper mapper)
        {
            this.regionRepository = regionRepository;
            NewMethod(mapper);

        }

        private void NewMethod(IMapper mapper)
        {
            Suggestedmethod(mapper);
        }

        private void Suggestedmethod(IMapper mapper)
        {
            this.mapper = mapper;
        }

        [HttpGet]
        public async  Task<IActionResult> GetAllRegions()
        {

            var regions = await regionRepository.GetAllAsync();
            //return DTO regions
            /* var regionsDTO = new List<Models.DTO.Region>();
             regions.ToList().ForEach(region =>
             {
                 var regionDTO = new Models.DTO.Region()
                 { 
                    Id =region.Id,
                    Code= region.Code,
                    Name=region.Name,
                    Area=region.Area, 
                    Lat=region.Lat,
                    Long=region.Long,
                    Population=region.Population,
                 };

                 regionsDTO.Add(regionDTO);

             });*/

           var regionsDTO = mapper.Map<Models.DTO.Region>(regions);         

            return Ok(regionsDTO);
        }
    }
}
  