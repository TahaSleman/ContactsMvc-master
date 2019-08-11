using System.Web.Mvc;
using TelerikMvcApp2.Repository.Classes;
using TelerikMvcApp2.Repository.Interfaces;

using Unity;
using Unity.Mvc5;

namespace TelerikMvcApp2
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();


            container.RegisterType<IContactContextRepository,ContactContextRepository>();
            container.RegisterType<IContactRepository, ContactRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}