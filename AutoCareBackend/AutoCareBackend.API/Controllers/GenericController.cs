using AutoCareBackend.Repo.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoCareBackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<TEntity> : ControllerBase where TEntity : class
    {
        public readonly IGenericRepo<TEntity> _repo;

        public GenericController(IGenericRepo<TEntity> repo)
        {
            _repo = repo;
        }

        // [HttpPost]
        
    }

}