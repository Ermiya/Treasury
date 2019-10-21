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
        public OperationResult<List<BankDto>> Select() => Controller.SelectTax(QueryOptions);
        [HttpGet, Route("{id}")]
        public OperationResult<BankDto> Get(int id) => Controller.GetTaxById(id);
        [HttpPost, Route("")]
        public OperationResult<BankDto> Add([FromBody] TaxAddDto obj) => Controller.AddTax(obj);
        [HttpPatch, Route("{id}")]
        public OperationResult<BankDto> Change(int id, [FromBody] TaxChangeDto obj) => Controller.ChangeTax(id, obj);
        [HttpDelete, Route("{id}")]
        public OperationResult<BankDto> Remove(int id) => Controller.RemoveTax(id);
    }
}
