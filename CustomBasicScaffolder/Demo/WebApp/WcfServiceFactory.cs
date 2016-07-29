using Microsoft.Practices.Unity;
using Repository.Pattern.DataContext;
using Repository.Pattern.Ef6;
using Repository.Pattern.Repositories;
using Repository.Pattern.UnitOfWork;
using Unity.Wcf;
using WebApp.Models;
using WebApp.Services;


namespace WebApp
{
	public class WcfServiceFactory : UnityServiceHostFactory
    {
        protected override void ConfigureContainer(IUnityContainer container)
        {
			// register all your components with the container here
            container
                    .RegisterType<WebApp.WCF.IBASE_CIQCODE, WebApp.WCF.BASE_CIQCODE>()
              .RegisterType<IRepositoryAsync<WebApp.Models.BASE_CIQCODE>, Repository<WebApp.Models.BASE_CIQCODE>>()
              .RegisterType<IBASE_CIQCODEService, BASE_CIQCODEService>()
              .RegisterType<IUnitOfWorkAsync, UnitOfWork>(new HierarchicalLifetimeManager())
             .RegisterType<IDataContextAsync, WebApp.Models.OdpContext>(new HierarchicalLifetimeManager());



            container.RegisterType<IRepositoryAsync<DataTableImportMapping>, Repository<DataTableImportMapping>>();
            container.RegisterType<IDataTableImportMappingService, DataTableImportMappingService>();
        }
    }    
}