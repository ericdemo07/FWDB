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
        private FrameworkModel _context;

        public FrameworkRepository(FrameworkModel frameworkContext)
        {
            this._context = frameworkContext;
        }

        public IEnumerable<Framework> FetchFrameworks()
        {
                return _context.Frameworks.ToList();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
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
