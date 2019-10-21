using Bitspco.Framework.Filters.Security.Authenticate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Treasury.Facade.Filters
{
    class Authenticator : IAuthenticator
    {
        public string Token { get; set; }
        public string GetToken()
        {
            throw new NotImplementedException();
        }

        public bool HasPermission(string policy)
        {
            throw new NotImplementedException();
        }

        public bool IsTokenValid()
        {
            throw new NotImplementedException();
        }
    }
}
