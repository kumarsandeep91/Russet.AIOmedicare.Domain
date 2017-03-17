using Russet.AIOmedicare.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russet.AIOmedicare.Domain.Domain.Products
{
    public class Product : DomainObject
    {

        #region
        public virtual Category Category { get; set; }
        public virtual IList<Batch> Batches { get; set; }
        public virtual IList<Material> Materials { get; set; }
        #endregion
    }
}
