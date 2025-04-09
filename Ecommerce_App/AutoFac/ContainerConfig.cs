using Autofac.Integration.Mvc;
using Autofac;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using DAL;
using DAL.Interface;
using DAL.Master;
using DAL.Interface.Master;

using DAL.Account;
using DAL.Interface.Account;
using DAL.ProductMaster;
using DAL.Interface.ProductMaster;



namespace OMSOnline.AutoFac
{
    public class ContainerConfig
    {
        public static void RegisterContainer()
        {
            var builder = new ContainerBuilder();
            var config = GlobalConfiguration.Configuration;
          
            // Register your controllers (important)
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterWebApiFilterProvider(config);
            builder.RegisterWebApiModelBinderProvider();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            // Register dependencies
            builder.RegisterType<CategoryGroup>().As<ICategoryGroup>();
            builder.RegisterType<CategorySubGroup>().As<ICategorySubGroup>();
            builder.RegisterType<Account>().As<IAccount>();
            builder.RegisterType<ProductMaster>().As<IProductMaster>();
            builder.RegisterType<Size>().As<ISize>();
            builder.RegisterType<Color>().As<IColor>();
            // Set the dependency resolver
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
           
        }
    }
}