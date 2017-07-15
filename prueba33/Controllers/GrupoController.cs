using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using prueba33.Models;
using prueba33.repositories;
using System.Threading.Tasks;

namespace prueba33.Controllers
{
    public class GrupoController : ApiController
    {
        private readonly IGrupoRepositoryAsync _repo;
        public GrupoController(IGrupoRepositoryAsync repo)
        {
            _repo = repo;
        }
        //Ejemplo simple de cache

        public HttpResponseMessage GetGrupos()
        {
            var data = _repo.GetAll();
            var response = Request.CreateResponse<IEnumerable<gesGrupo>>(HttpStatusCode.OK, data);
            response.Headers.CacheControl = new System.Net.Http.Headers.CacheControlHeaderValue()
            {
                MaxAge = TimeSpan.FromMinutes(1)
            };
            return response;
        }

        /*
        public async Task<ICollection<gesGrupo>> Grupos()
        {
            var data = await _repo.GetAll();

            return data;
        }
        */
        /*
        public string Get()
        {
            return "Ok";
        }
        */
        [Route("api/grupo/grupos")]
        public async Task<IEnumerable<gesGrupo>> GetAllAsync()
        {
            return await _repo.GetAllAsync();
        }
             
         
        //[DeflateCompression]
        public IQueryable<gesGrupo> Get()
        {
            return _repo.GetAll();
        }

        protected override void Dispose(bool disposing)
        {
            _repo.Dispose();
            base.Dispose(disposing);
        }
    }
}
