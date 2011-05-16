using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace windsor_ioc_spike.Castle_Setup
{
    public class DependencyInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store) {
            container.Register(AllTypes
                                   .FromThisAssembly()
                                   .BasedOn<IDependency>()
                                   .WithService.FirstInterface()
                                   .Configure(component => component.LifeStyle.Transient));
        }
    }
}