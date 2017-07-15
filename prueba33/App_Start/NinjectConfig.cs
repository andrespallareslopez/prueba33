using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using prueba33.repositories;

namespace prueba33.App_Start
{
    public static class NinjectConfig
    {
        public static Lazy<IKernel> CreateKernel = new Lazy<IKernel>(() =>
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            RegisterServices(kernel);

            return kernel;
        });

        private static void RegisterServices(KernelBase kernel)
        {
            //kernel.Bind<IGrupoRepository>()
            // .To<GrupoRepository>();
            kernel.Bind<IGrupoRepositoryAsync>().To<GrupoRepositoryAsync>();
            kernel.Bind<IFamiliaRepositoryAsync>().To<FamiliaRepositoryAsync>();
        }
    }
}