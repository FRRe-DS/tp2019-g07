using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using webapif.Models.entidades;
using webapif.Models.Persistance;

namespace webapif.Controllers
{
    public class ExploracionRegionalController : ApiController
    {
        static readonly IServerDataRepository<ExploracionRegional> erRepository = new ServerDataRepository<ExploracionRegional>();

        [Route("api/exploracionregional/todos")]
        [HttpGet]
        public IEnumerable<ExploracionRegional> GetExploracionRegional()
        {
            return erRepository.GetAll();
        }
        [HttpGet]
        public IEnumerable<ExploracionRegional> GetExploracionRegionalByIdExpediente(int idexpediente)
        {
            return erRepository.GetAll().Where(d => d.idExpediente == idexpediente);
        }

        [HttpPost]
        public void PostExploracionRegional(ExploracionRegional er)
        {

            if (!erRepository.Add(er))
                throw new HttpResponseException(HttpStatusCode.NotFound);
        }
        [HttpPut]
        public void PutExploracionRegional(ExploracionRegional er)
        {
            if (!erRepository.Update(er))
                throw new HttpResponseException(HttpStatusCode.NotFound);
        }
        [HttpDelete]
        public void DeleteExploracionRegional(int id)
        {

            ExploracionRegional er = new ExploracionRegional()
            {
                idExploracionRegional = id
            };

            if (er == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            erRepository.Delete(er);
        }
    }
}
