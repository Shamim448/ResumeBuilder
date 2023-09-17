using Autofac;
using ResumeBuilder.Application;
using ResumeBuilder.Application.Features.Resume.Repositories;
using ResumeBuilder.Persistence.Features.Resume.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Persistence
{
    public class PersistenceModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssembly;

        public PersistenceModule(string connectionString, string migrationAssembly)
        {
            _connectionString = connectionString;
            _migrationAssembly = migrationAssembly;
        }
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationDbContext>().AsSelf()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssembly", _migrationAssembly)
                .InstancePerLifetimeScope();

            builder.RegisterType<ApplicationDbContext>().As<IApplicationDbContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssembly", _migrationAssembly)
                .InstancePerLifetimeScope();

            builder.RegisterType<ApplicationUnitOfWork>().As<IApplicationUnitOfWork>()
.InstancePerLifetimeScope();

            builder.RegisterType<EducationRepository>().As<IEducationRepository>()
                .InstancePerLifetimeScope();
            builder.RegisterType<AboutUsRepository>().As<IAboutUsRepository>()
                .InstancePerLifetimeScope();
            builder.RegisterType<CVTemplateRepository>().As<ICVTemplateRepository>()
               .InstancePerLifetimeScope();

        }
    }
}
