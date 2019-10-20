using Bitspco.Framework.Domain;
using ERP.Treasury_back.Shared.Models.CommonPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
namespace ERP.Treasury_back.Service.WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("CommonPages")]
    public class CommonPagesController : ApiController
    {
        [HttpGet, Route("GetParrametersForFormConstraction/{id}")]
       // public OperationResult<List<TaxGetDto>> Select() => Controller.SelectTax(QueryOptions);
        public OperationResult<ParrametersForFormConstractionDto> GetParrametersForFormConstraction(int id)
        {
            //return Controller.GetParrametersForFormConstraction(id);
            var x = Controller.GetParrametersForFormConstraction2(id);
              return null;

        }

    }
}
