using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Util
{
    public class AutofacConfiguration
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<Calculator>().As<ICalculate>().SingleInstance();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}