using Russet.AIOmedicare.Domain.Base;
using Russet.AIOmedicare.Domain.Domain.Products;
using System.Collections.Generic;

namespace Russet.AIOmedicare.Domain.Domain
{
    public class Stock : DomainObject
    {
        public int Quantity { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<Stock>();
            }
        }

        #region
        public virtual IList<Product> Products { get; set; }
        #endregion
    }
}
