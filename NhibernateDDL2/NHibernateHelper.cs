using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using NHibernate;
using NHibernate.Cfg;
using NhibernateDDL2.Domain;

namespace NhibernateDDL2
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

            cfg.AddInputStream(NHibernate.Mapping.Attributes.HbmSerializer.Default.Serialize(typeof(Product2)));        
            
            //cfg.AddInputStream(NHibernate.Mapping.Attributes.HbmSerializer.Default.Serialize(Assembly.GetExecutingAssembly()));

            return cfg.BuildSessionFactory();
        }
        public ISession GetSession()
        {
            return _sessionFactory.OpenSession();
        }
    }
}
