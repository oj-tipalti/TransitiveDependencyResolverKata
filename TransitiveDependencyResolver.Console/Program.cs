using Castle.MicroKernel.Registration;
using Castle.Windsor;
using TransitiveDependencyResolver.model;

namespace TransitiveDependencyResolver.Console
{
    class Program
    {
        private static WindsorContainer _container;

        static void Main(string[] args)
        {
            InitializeContainer();

            var transitiveDependencyResolver = _container.Resolve<ITransitiveDependencyResolver>();

        }

        private static void InitializeContainer()
        {
            _container = new WindsorContainer();

        }

        private static void RegisterComponent<TService, TImpl>() 
            where TService : class 
            where TImpl : TService
        {
            _container.Register(Component
                .For<TService>()
                .ImplementedBy<TImpl>());
        }
    }
}
