using Ninject;
using Ninject.Syntax;
using PizzariaPoloh.Dominio.Repositorio;
using PizzariaPoloh.Dominio.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace PizzariaPoloh.Web.App_Start
{
    public class ConfiguracaoInjecao : IDependencyResolver
    {
        private readonly IResolutionRoot _resolutionRoot;

        public ConfiguracaoInjecao(IResolutionRoot kernel)
        {
            _resolutionRoot = kernel;
        }

        public object GetService(Type serviceType)
        {
            return _resolutionRoot.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _resolutionRoot.GetAll(serviceType);
        }

        public static void ConfigurarDependencias()
        {
            //Cria o Container 
            IKernel kernel = new StandardKernel();

            //Instrução para mapear a interface IPessoa para a classe concreta Pessoa
            kernel.Bind<IProdutoRepositorio>().To<ProdutoRepositorio>();

            //Registra o container no ASP.NET
            DependencyResolver.SetResolver(new ConfiguracaoInjecao(kernel));
        }
    }
}