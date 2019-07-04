using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using webapif.Models.entidades;
using webapif.Models.Persistance;

namespace webapif.Controllers
{
    public class ExploracionGeneralController : ApiController
    {
        static readonly IServerDataRepository<ExploracionGeneral> egRepository = new ServerDataRepository<ExploracionGeneral>();

        [Route("api/exploraciongeneral/todos")]
        [HttpGet]
        public IEnumerable<ExploracionGeneral> GetExploracionGeneral()
        {
            return egRepository.GetAll();
        }
        [HttpGet]
        public IEnumerable<ExploracionGeneral> GetExploracionGeneralByIdExpediente(int idexpediente)
        {
            return egRepository.GetAll().Where(d => d.idExpediente == idexpediente);
        }
        [HttpPost]
        public void PostExploracionGeneral(ExploracionGeneral eg)
        {

            if (!egRepository.Add(eg))
                throw new HttpResponseException(HttpStatusCode.NotFound);
        }
        [HttpPut]
        public void PutExploracionGeneral(ExploracionGeneral eg)
        {


            if (!egRepository.Update(eg))
                throw new HttpResponseException(HttpStatusCode.NotFound);
        }

        [HttpDelete]
        public void DeleteExploracionGeneral(int id)
        {

            ExploracionGeneral eg = new ExploracionGeneral()
            {
                idExploracionGeneral = id
            };

            if (eg == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            egRepository.Delete(eg);
        }
    }
}
