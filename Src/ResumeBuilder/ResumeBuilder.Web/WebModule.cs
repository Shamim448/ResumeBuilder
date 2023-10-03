using Autofac;
using ResumeBuilder.Web.Areas.Users.Models;

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
            builder.RegisterType<EducationVM>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<ResumeListModel>().AsSelf().InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}
