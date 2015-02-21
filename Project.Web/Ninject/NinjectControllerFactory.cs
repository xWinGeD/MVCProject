using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using Project.Persistence;
using Project.Persistence.Ef;

namespace Project.Web.Ninject
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null 
                ? null
                : (IController)ninjectKernel.Get(controllerType);
        }

        public void AddBindings()
        {
            ninjectKernel.Bind(typeof (IRepository<>)).To(typeof (Repository<>));
        }
    }
}