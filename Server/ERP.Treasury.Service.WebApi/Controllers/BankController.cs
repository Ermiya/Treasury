using Bitspco.Framework.Domain;
using ERP.Treasury.Shared.Models.Tax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bitspco.Framework.Common;
using ERP.Treasury.Shared.Models;
using ERP.Treasury.Shared.Models.Bank;

namespace ERP.Treasury.Service.WebApi.Controllers
{
    [RoutePrefix("Bank")]
    public class BankController : ApiController
    {
        [HttpGet, Route("")]
        public OperationResult<List<BankGetDto>> Select() => Controller.SelectBank(QueryOptions);
        [HttpGet, Route("{id}")]
        public OperationResult<BankGetDto> Get(int id) => Controller.GetBankById(id);
        [HttpPost, Route("")]
        public OperationResult<BankGetDto> Add([FromBody] BankAddDto obj)
        //public BankGetDto Add([FromBody] BankAddDto obj)
        {

            obj.Validate().ThrowIfHasInnerException();
            //ex.ThrowIfHasInnerException();


            return Controller.AddBank(obj);

        }
        [HttpPatch, Route("{id}")]
        public OperationResult<BankGetDto> Change(int id, [FromBody] BankAddDto obj) => Controller.ChangeBank(id, obj);
        [HttpDelete, Route("{id}")]
        public OperationResult<BankGetDto> Remove(int id) => Controller.RemoveBank(id);
    }
}
