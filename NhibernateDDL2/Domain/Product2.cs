using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Mapping.Attributes;

namespace NhibernateDDL2.Domain
{   
    [Class(Table="T_Product2")]
    public class Product2 
    {
        [Id(1, Name = "Id", TypeType = typeof(long), Column = "Id", UnsavedValue = "0")]
        [Generator(2, Class = "native")]
        public virtual Guid Id { get; set; }

        [PropertyAttribute(Column = "Name2", TypeType = typeof(string),Length=100)]
        public virtual string Name2 { get; set; }

        [PropertyAttribute(Column = "Category", TypeType = typeof(string),Length=200)]
        public virtual string Category { get; set; }

        [PropertyAttribute(Column = "Discontinued", TypeType = typeof(bool))]
        public virtual bool Discontinued { get; set; }
    }
}
