        using System;
    
    using System.ServiceModel;
    using System.ServiceModel.Channels;
    using System.ServiceModel.Dispatcher;
    
    using Microsoft.Practices.Unity;
using System.ServiceModel.Description;
using System.Collections.ObjectModel;
using System.ServiceModel.Activation;
using Repository.Pattern.Repositories;
using WebApp.Services;
using Repository.Pattern.UnitOfWork;
using Repository.Pattern.DataContext;
using Repository.Pattern.Ef6;
using WebApp.Models;

namespace UnitySample
{
    public class UnityInstanceProvider : IInstanceProvider
    {
        public UnityContainer Container { set; get; }
        public Type ServiceType { set; get; }

        public UnityInstanceProvider()
            : this(null)
        {
        }

        public UnityInstanceProvider(Type type)
        {
            ServiceType = type;
            Container = new UnityContainer();
        }

        #region IInstanceProvider Members

        public object GetInstance(InstanceContext instanceContext, Message message)
        {
            return Container.Resolve(ServiceType);
        }

        public object GetInstance(InstanceContext instanceContext)
        {
            return GetInstance(instanceContext, null);
        }
        public void ReleaseInstance(InstanceContext instanceContext, object instance)
        {

        }

        #endregion
    }




    public class UnityServiceBehavior : IServiceBehavior
        {
            public UnityInstanceProvider InstanceProvider
            { get; set; }
    
            private ServiceHost serviceHost = null;
    
            public UnityServiceBehavior()
            {
                InstanceProvider = new UnityInstanceProvider();
            }
            public UnityServiceBehavior(UnityContainer unity)
            {
                InstanceProvider = new UnityInstanceProvider();
                InstanceProvider.Container = unity;
            }
            public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
            {
                foreach (ChannelDispatcherBase cdb in serviceHostBase.ChannelDispatchers)
                {
                    ChannelDispatcher cd = cdb as ChannelDispatcher;
                    if (cd != null)
                    {
                        foreach (EndpointDispatcher ed in cd.Endpoints)
                        {
                            InstanceProvider.ServiceType = serviceDescription.ServiceType;
                            ed.DispatchRuntime.InstanceProvider = InstanceProvider;
    
                        }
                    }
                }
            }
    
    
            public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase) { }
    
    
            public void AddBindingParameters(
                ServiceDescription serviceDescription,
                ServiceHostBase serviceHostBase,
                Collection<ServiceEndpoint> endpoints,
                BindingParameterCollection bindingParameters)
            {
            }
    
        }




    public class UnityServiceHost : ServiceHost
     {
         public UnityContainer Container { set; get; }
 
         public UnityServiceHost()
             : base()
         {
             Container = new UnityContainer();
         }
 
         public UnityServiceHost(Type serviceType, params Uri[] baseAddresses)
             : base(serviceType, baseAddresses)
         {
             Container = new UnityContainer();
         }
 
         protected override void OnOpening()
         {
             if (this.Description.Behaviors.Find<UnitySample.UnityServiceBehavior>() == null)
                 this.Description.Behaviors.Add(new UnityServiceBehavior(Container));
 
             base.OnOpening();
         }
 
 
 
     }



    public class UnityServiceHostFactory : ServiceHostFactory
       {
           protected override ServiceHost CreateServiceHost(
                                             Type serviceType, Uri[] baseAddresses)
           {
               UnityServiceHost serviceHost = new UnityServiceHost(serviceType, baseAddresses);
               UnityContainer container = new UnityContainer();
               serviceHost.Container = container;
   
               //configure container
               container
                    .RegisterType<WebApp.WCF.IBASE_CIQCODE,  WebApp.WCF.BASE_CIQCODE>()
              .RegisterType<IRepositoryAsync<WebApp.Models.BASE_CIQCODE>, Repository<WebApp.Models.BASE_CIQCODE>>()
              .RegisterType<IBASE_CIQCODEService, BASE_CIQCODEService>()
              .RegisterType<IUnitOfWorkAsync, UnitOfWork>(new HierarchicalLifetimeManager())
             .RegisterType<IDataContextAsync, WebApp.Models.OdpContext>(new HierarchicalLifetimeManager());



               container.RegisterType<IRepositoryAsync<DataTableImportMapping>, Repository<DataTableImportMapping>>();
               container.RegisterType<IDataTableImportMappingService, DataTableImportMappingService>();

               return serviceHost;
           }
       }
}