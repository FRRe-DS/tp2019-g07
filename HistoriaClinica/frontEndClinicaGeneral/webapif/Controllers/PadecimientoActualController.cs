using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using webapif.Models.entidades;
using webapif.Models.Persistance;

namespace webapif.Controllers
{
    public class PadecimientoActualController : ApiController
    {
        static readonly IServerDataRepository<PadecimientoActual> paRepository = new ServerDataRepository<PadecimientoActual>();

        [Route("api/padecimientoactual/todos")]
        [HttpGet]
        public IEnumerable<PadecimientoActual> GetPadecimientoActual()
        {
            return paRepository.GetAll();
        }
        [HttpGet]
        public IEnumerable<PadecimientoActual> GetPadecimientoActualByIdExpediente(int idexpediente)
        {
            return paRepository.GetAll().Where(d => d.idExpediente == idexpediente);
        }

        [HttpPost]
        public void PostPadecimientoActuall(PadecimientoActual pa)
        {

            if (!paRepository.Add(pa))
                throw new HttpResponseException(HttpStatusCode.NotFound);
        }
        [HttpPut]
        public void PutPadecimientoActual(PadecimientoActual pa)
        {

            if (!paRepository.Update(pa))
                throw new HttpResponseException(HttpStatusCode.NotFound);
        }

        [HttpDelete]
        public void DeletePadecimientoActual(int id)
        {

            PadecimientoActual pa = new PadecimientoActual()
            {
                idPadecimiento = id
            };

            if (pa == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            paRepository.Delete(pa);
        }
    }
}
