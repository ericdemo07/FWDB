using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FWDBApp.Models;

namespace FWDBApp.Repository
{
    public class FrameworkRepository : IFrameworkRepository
    {
        private FrameworkModel context;

        public FrameworkRepository(FrameworkModel frameworkContext)
        {
            this.context = frameworkContext;
        }

        public IEnumerable<Framework> FetchFrameworks()
        {
                return context.Frameworks.ToList();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
