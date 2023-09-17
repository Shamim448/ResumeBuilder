using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeBuilder.Domain.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
