using Russet.AIOmedicare.Domain.Base;
using System.Collections.Generic;

namespace Russet.AIOmedicare.Domain.Domain.Products
{
    public class Category : DomainObject
    {

        #region
        public virtual IList<SubCategory> SubCategory { get; set; }
        #endregion
    }
}
