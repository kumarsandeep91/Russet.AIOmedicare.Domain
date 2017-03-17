using Russet.AIOmedicare.Domain.Base;
using Russet.AIOmedicare.Domain.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russet.AIOmedicare.Domain.Domain.Inventories
{
    public class Inventory : DomainObject
    {
        public string Name { get; set; }
        public string Description { get; set; }

        #region
        public virtual IList<Product> Products { get; set; }
        #endregion
    }
}
