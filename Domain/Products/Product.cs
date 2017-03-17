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
        public string Name { get; set; }
        public string Description { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<Product>();
            }
        }

        #region
        public virtual Category Category { get; set; }
        public virtual IList<Batch> Batches { get; set; }
        public virtual IList<Material> Materials { get; set; }
        #endregion
    }
}
