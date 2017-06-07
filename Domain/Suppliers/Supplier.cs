using Russet.AIOmedicare.Domain.Domain.Companies;

namespace Russet.AIOmedicare.Domain.Domain.Suppliers
{
    public class Supplier : Company
    {
        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<Supplier>();
            }
        }
    }
}
