using Russet.AIOmedicare.Domain.Base;
using System.Collections.Generic;

namespace Russet.AIOmedicare.Domain.Domain.Companies
{
    public class Company : DomainObject
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
                return Validate<Company>();
            }
        }

        #region
        public virtual IList<Contact> Contacts { get; set; }
        public virtual IList<Address> Addresses { get; set; }
        #endregion
    }
}
