using Autofac;
using Autofac.Features.ResolveAnything;
using FluentAutofacValidationAPI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FluentAutofacValidationAPI
{
    public partial class Startup
    {
        private static IContainer ConfigureAutofac()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule<AutofacWebModule>();
            builder.RegisterSource(new AnyConcreteTypeNotAlreadyRegisteredSource());

            var container = builder.Build();
            return container;
        }
    }
}