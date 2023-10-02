using Autofac;
using ResumeBuilder.Web.Areas.Users.Models;
using ResumeBuilder.Web.Models;

namespace ResumeBuilder.Web
{
    public class WebModule:Module
    {
        public WebModule()
        {
            
        }
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicantVM>().AsSelf().InstancePerLifetimeScope();           
            builder.RegisterType<RegisterVM>().AsSelf().InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}
