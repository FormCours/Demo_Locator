using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Locator.Pattern.IOC
{
    public interface ISimpleIOC
    {
        void Register<TService>()
            where TService : class, new();

        void Register<TService>(params object[] parametres)
            where TService : class;

        TService GetService<TService>();
    }
}
