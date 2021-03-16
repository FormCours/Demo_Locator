using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Locator.Pattern.IOC
{
    public class SimpleIOC : ISimpleIOC
    {
        private class InfoConstructor
        {
            public Type TypeService;
            public object[] Parametres;

            public InfoConstructor(Type typeService, params object[] parametres)
            {
                TypeService = typeService;
                Parametres = parametres;
            }
        }

        private Dictionary<Type, object> _Instances;
        private Dictionary<Type, InfoConstructor> _InfoCtors; 

        public SimpleIOC()
        {
            _Instances = new Dictionary<Type, object>();
            _InfoCtors = new Dictionary<Type, InfoConstructor>();
        }

        public void Register<TService>() where TService : class, new()
        {
            Register<TService>(null);
        }

        public void Register<TService>(params object[] parametres) where TService : class
        {
            Type type = typeof(TService);

            _Instances.Add(type, null);
            _InfoCtors.Add(type, new InfoConstructor(type, parametres));
        }

        public TService GetService<TService>()
        {
            Type type = typeof(TService);

            if (!_Instances.ContainsKey(type))
                throw new ArgumentOutOfRangeException("TService", "TService is not register");

            if (_Instances[type] == null)
            {
                InfoConstructor ctor = _InfoCtors[type];

                // Permet d'instancier un objet via son constructeur (en fonction des parametres)
                _Instances[type] = Activator.CreateInstance(ctor.TypeService, ctor.Parametres);
            }

            return (TService)_Instances[type];
        }
    }

}
