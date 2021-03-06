﻿using Russet.AIOmedicare.Domain.Base;

namespace Russet.AIOmedicare.Domain.Domain.Products
{
    public class UnitOfMeasurement : DomainObject
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
                return Validate<UnitOfMeasurement>();
            }
        }
    }
}
