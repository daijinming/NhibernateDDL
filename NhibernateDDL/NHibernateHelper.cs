using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using NHibernate;
using NHibernate.Cfg;
using NhibernateDDL.Domain;

namespace NhibernateDDL
{
    public class NHibernateHelper
    {
        private ISessionFactory _sessionFactory;
        public NHibernateHelper()
        {
            _sessionFactory = GetSessionFactory();
        }

        private ISessionFactory GetSessionFactory()
        {
            Configuration cfg = new Configuration();
            cfg.Configure();
            Assembly thisAssembly = typeof(Product).Assembly;
            cfg.AddAssembly(thisAssembly);

            return cfg.BuildSessionFactory();
        }
        public ISession GetSession()
        {
            return _sessionFactory.OpenSession();
        }
    }
}
