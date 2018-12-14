using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDNS.Core.ServiceProviders
{
    public interface IServiceProvider
    {
        void Update();
    }
}
