using Bitspco.Framework.Common;
using Bitspco.Framework.Filters;
using Bitspco.Framework.Filters.Log;
using Bitspco.Framework.Filters.Security;
using Bitspco.Framework.Filters.Security.AntiDos;
using Bitspco.Framework.Filters.Security.Authenticate;
using Bitspco.Framework.Filters.Security.IP;
using Bitspco.Framework.Filters.Security.Models;
using Bitspco.Framework.Net.Logger.Contexts;
using Bitspco.Framework.Net.Filters.Security;
using ERP.Treasury.Business;
using ERP.Treasury.Common.Interfaces;
using ERP.Treasury.Data;
using ERP.Treasury.Data.Contexts;
using ERP.Treasury.Facade.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net.Http;
using AutoMapper;
using Bitspco.Framework.Common.Query;
using ERP.Treasury.Shared.Models.Bank;
using ERP.Treasury.Common.Entities;

namespace ERP.Treasury.Facade
{
    public partial class TreasuryController
    {
        public string ConnectionString
        {
            get
            {
               // return "data source=192.168.4.10;initial catalog=FraSanaat;persist security info=True;user id=sa;password=ali_1350;MultipleActiveResultSets=True;App=EntityFramework";
                return "data source=(localdb)\\MSSQLLocalDB;initial catalog=Treasury;Integrated Security=SSPI;MultipleActiveResultSets=True;App=EntityFramework";

            }
        }
        public string MapExtension { get { return ".jpg"; } }

        private IDataAdapter adapter;
        private TreasuryBusiness business;

        private Authenticator auth;
        private AuthFilter authFilter = new AuthFilter();
        private LogFilter logFilter = new LogFilter(new Logger());
        private SecurityFilter securityFilter = new SecurityFilter();
        private AntiDosFilter antiDosFilter = new AntiDosFilter();
        private IPFilter ipFilter = new IPFilter();
        private FilterCollection<IFilter> filters = new FilterCollection<IFilter>();

        private TreasuryBusiness Business
        {
            get
            {
                if (business == null)
                {
                    business = new TreasuryBusiness(Adapter);
                }
                return business;
            }
        }
        private IDataAdapter Adapter
        {
            get
            {
                if (adapter != null) return adapter;
                //return adapter = new DataAdapter(new TreasuryDbContext(ConnectionString), new LoggerDbContext(ConnectionString));
                return adapter = new DataAdapter(new TreasuryDbContext(ConnectionString));
            }
        }

        public TreasuryController()
        {
            //filters.Add(authFilter);
            filters.Add(logFilter);

            antiDosFilter.AttributeEnable = true;
            securityFilter.Filters.Add(authFilter);
            securityFilter.Filters.Add(antiDosFilter);
            securityFilter.Filters.Add(ipFilter);

            filters.Add(securityFilter);
        }
        public void RegisterSecurity(HttpRequest request)
        {
            securityFilter.ClientInfo = new ClientInfo().GetClientInfo(request, "");
        }

        public void RegisterAuthenticator(string token)
        {
            auth = new Authenticator() { Token = token };
            authFilter.SetAuthenticator(auth);
        }

        private Promise<T> Run<T>(Func<T> func, bool saveChanges = false, object[] arguments = null)
        {
            T result = default(T);
            filters.BeginExecute(frameBack: 2, arguments: arguments);
            try { result = func(); }
            catch (Exception e) { throw; }
            finally { filters.EndExecute(); if (saveChanges) Adapter.SaveChanges(); }
            return new Promise<T>(result);
        }
        public List<R> Select<T, R>(QueryOptions options) where T : class => Run(() => options.ApplyTo(Adapter.Select<T>()).ToList()).Then(Mapper.Map<List<R>>).Result;
        public List<R> GetAll<T, R>() where T : class => Run(() => Adapter.Select<T>().ToList()).Then(Mapper.Map<List<R>>).Result;
        public R GetById<T, R>(object id) where T : class => Run(() => Adapter.GetById<T>(id)).Then(Mapper.Map<R>).Result;
        public R Add<T, R, Q>(Q obj) where T : class => Run(() => Adapter.Insert(Mapper.Map<T>(obj)), saveChanges: true).Then(Mapper.Map<R>).Result;
        public R Change<T, R, Q>(object id, Q obj) where T : class => Run(() => Adapter.Update(Mapper.Map(obj, Adapter.GetById<T>(id))), saveChanges: true).Then(Mapper.Map<R>).Result;
        public R Remove<T, R>(object id) where T : class => Run(() => Adapter.Delete(Adapter.GetById<T>(id)), saveChanges: true).Then(Mapper.Map<R>).Result;

        public BankGetDto Insert(BankAddDto bankAddDto)
        {
            var b = Mapper.Map(bankAddDto, BankAddDto, Bank);
            business.AddBank
            //Bank entity = Mapper.Map < (bankAddDto, BankAddDto, Bank);
            //Adapter.Insert<Bank>()
        }
        public R GetById2<T, R>(object id) where T : class => Run(() => Adapter.GetById<T>(id)).Then(Mapper.Map<R>).Result;

        
    }
}
