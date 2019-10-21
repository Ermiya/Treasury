using Bitspco.Framework.Domain;
using ERP.Treasury.Shared.Models.Tax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bitspco.Framework.Common;

namespace ERP.Treasury.Service.WebApi.Controllers
{
    [RoutePrefix("Tax")]
    public class TaxController : ApiController
    {
        [HttpGet, Route("")]
        public OperationResult<List<TaxGetDto>> Select() => Controller.SelectTax(QueryOptions);
        [HttpGet, Route("{id}")]
        public OperationResult<TaxGetDto> Get(int id) => Controller.GetTaxById(id);
        [HttpPost, Route("")]
        public OperationResult<TaxGetDto> Add([FromBody] TaxAddDto obj) => Controller.AddTax(obj);
        [HttpPatch, Route("{id}")]
        public OperationResult<TaxGetDto> Change(int id, [FromBody] TaxChangeDto obj) => Controller.ChangeTax(id, obj);
        [HttpDelete, Route("{id}")]
        public OperationResult<TaxGetDto> Remove(int id) => Controller.RemoveTax(id);
    }
}
