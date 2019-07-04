using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using webapif.Models.entidades;
using webapif.Models.Persistance;

namespace webapif.Controllers
{
    public class SintomaGeneralController : ApiController
    {
        static readonly IServerDataRepository<SintomaGeneral> sgRepository = new ServerDataRepository<SintomaGeneral>();

        [Route("api/sintomageneral/todos")]
        [HttpGet]
        public IEnumerable<SintomaGeneral> GetSintomaGeneral()
        {
            return sgRepository.GetAll();
        }
        [HttpGet]
        public IEnumerable<SintomaGeneral> GetSintomaGeneralByIdExpediente(int idexpediente)
        {
            return sgRepository.GetAll().Where(d => d.idExpediente == idexpediente);
        }
        [HttpPost]
        public void PostSintomaGeneral(SintomaGeneral sg)
        {

            if (!sgRepository.Add(sg))
                throw new HttpResponseException(HttpStatusCode.NotFound);
        }
        [HttpPut]
        public void PutSintomaGeneral(SintomaGeneral sg)
        {

            if (!sgRepository.Update(sg))
                throw new HttpResponseException(HttpStatusCode.NotFound);
        }

        [HttpDelete]
        public void DeleteSintomaGeneral(int id)
        {

            SintomaGeneral sg = new SintomaGeneral()
            {
                idSintomaGeneral = id
            };

            if (sg == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            sgRepository.Delete(sg);
        }
    }
}
