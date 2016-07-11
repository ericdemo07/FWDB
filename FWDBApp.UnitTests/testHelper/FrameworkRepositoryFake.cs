using System;
using System.Collections.Generic;
using System.Linq;

using FWDBApp.Models;

namespace FWDBApp.Repository
{
    public class FrameworkRepositoryFake : IFrameworkRepository
    {
        private List<Framework> context;

        public FrameworkRepositoryFake(List<Framework> frameworkContext)
        {
            this.context = frameworkContext;
        }


        public IEnumerable<Framework> FetchFrameworks()
        {
            return context.ToList();
        }
        private FrameworkModel context2;

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context2.Dispose();
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
