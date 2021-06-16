using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportShopWebsite.RestApi.Models.Entities;
using SportShopWebsite.RestApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportShopWebsite.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly ICrudFeature<Brand> _repository;

        public BrandController(ICrudFeature<Brand> repository)
        {
            this._repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<Brand>> GetBrands()
        {
            return await _repository.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Brand>> GetBrand(int id)
        {
            return await _repository.GetById(id);
        }




    }
}
