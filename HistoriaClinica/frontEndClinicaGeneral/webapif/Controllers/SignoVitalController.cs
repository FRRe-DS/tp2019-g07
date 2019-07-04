using System;
using System.Collections.Generic;
using System.Linq;
using webapif.Models.Persistance;
using webapif.Models.entidades;
using System.Web.Http;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using RouteAttribute = System.Web.Mvc.RouteAttribute;
using System.Net;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using HttpPutAttribute = System.Web.Mvc.HttpPutAttribute;
using HttpDeleteAttribute = System.Web.Mvc.HttpDeleteAttribute;

namespace webapif.Controllers
{
    public class SignoVitalController : ApiController

    {

        static readonly IServerDataRepository<SignoVital> svRepository = new ServerDataRepository<SignoVital>();
        //// GET: SignoVital
        //public ActionResult Index()
        //{
        //    return View();
        //}
        [Route("api/signovital/todos")]
        [HttpGet]
        public IEnumerable<SignoVital> GetSingoVital()
        {
            return svRepository.GetAll();
        }
        [HttpGet]
        public IEnumerable<SignoVital> GetSignovitalByIdExpediente(int idexpediente)
        {
            return svRepository.GetAll().Where(d => d.idExpediente == idexpediente);
        }

        [HttpPost]
        public void PostSignoVital(SignoVital sv)
        {

            if (!svRepository.Add(sv))
                throw new HttpResponseException(HttpStatusCode.NotFound);
        }
        [HttpPut]
        public void PutSignoVital(SignoVital sv)
        {
            

            if (!svRepository.Update(sv))
                throw new HttpResponseException(HttpStatusCode.NotFound);
        }
        [HttpDelete]
        public void DeleteSignoVital(int id)
        {

            SignoVital sv = new SignoVital()
            {
                idSignoVital = id
            };

            if (sv == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            svRepository.Delete(sv);
        }
    }
}