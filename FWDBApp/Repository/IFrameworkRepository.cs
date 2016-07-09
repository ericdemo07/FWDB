using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FWDBApp.Models;

namespace FWDBApp.Repository
{
    public interface IFrameworkRepository : IDisposable
    {
        IEnumerable<Framework> FetchFrameworks();
    }
}
