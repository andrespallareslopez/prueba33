using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using prueba33.repositories;
using prueba33.Models;
using System.Threading.Tasks;
using System.Web.Http.Description;

namespace prueba33.Controllers
{
    public class FamiliaController : ApiController
    {
        private readonly IFamiliaRepositoryAsync _repo;

        public FamiliaController(IFamiliaRepositoryAsync repo)
        {
            _repo = repo;
        }   
        [ActionName("Familias")]
        public async Task<IHttpActionResult> GetAll()
        {
            var familias = await _repo.GetAllAsync();

            return Ok(familias);
        }

        [ResponseType(typeof(gesFamilia))]
        public async Task<IHttpActionResult> Get(int id)
        {
            var familia = await _repo.GetAsync(id);
            if (familia == null)
            {
                //return BadRequest("Familia no encontrada");
                // throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
                return NotFound(); 
            }
            return Ok(familia);
        }
        [Route("api/familia/grupo/{Id}")]
        public async Task<IHttpActionResult> GetByGrupo(int id)
        {
            var familias = await _repo.FindByAsync(gesfamilia=> 
                gesfamilia.CodGrupo == id
            );
            if (familias.Count() == 0)
            {
                return BadRequest("Familia no encontrada");
                //return NotFound();
            }
            return Ok(familias);
        }
        protected override void Dispose(bool disposing)
        {
            _repo.Dispose();
            base.Dispose(disposing);
        }

    }
}
