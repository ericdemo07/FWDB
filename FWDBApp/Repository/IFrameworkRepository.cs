using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FWDBApp.Models;

namespace FWDBApp.Repository
{
    interface IFrameworkRepository : IDisposable
    {
        IEnumerable<Framework> FetchFrameworks();
    }
}
