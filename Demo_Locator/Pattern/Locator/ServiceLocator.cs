using Demo_Locator.Pattern.IOC;
using Demo_Locator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Locator.Pattern.Locator
{
    public class ServiceLocator
    {
        #region Default Pattern (Variante Singleton)
        private static Lazy<ServiceLocator> _Instance = new Lazy<ServiceLocator>(() => new ServiceLocator(), true);

        public static ServiceLocator Default { get { return _Instance.Value; } }
        #endregion

        private readonly ISimpleIOC _SimpleIOC;

        public ServiceLocator()
        {
            _SimpleIOC = new SimpleIOC();

            // Configuration des services a enregistrer
            _SimpleIOC.Register<NicoService>();
            _SimpleIOC.Register<VirigineService>();
            _SimpleIOC.Register<TomService>("Demo de l'IOC");
        }


        public NicoService Service1()
        {
            return _SimpleIOC.GetService<NicoService>();
        }
        public VirigineService Service2()
        {
            return _SimpleIOC.GetService<VirigineService>();
        }
        public TomService Service3()
        {
            return _SimpleIOC.GetService<TomService>();
        }
    }
}
