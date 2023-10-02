
using Autofac;
using ResumeBuilder.Application.Features.Resume.Services;
using ResumeBuilder.Infrastructure.Features.Services;

namespace CSEData.Infrastructure
{
    public class InfrastructureModule: Module
    {
        public InfrastructureModule()
        {
            
        }
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ResumeBuilderService>().As<IResumeBuilderService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ResumeService>().As<IResumeService>()
               .InstancePerLifetimeScope();

        }
    }
}
