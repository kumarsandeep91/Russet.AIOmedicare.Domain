﻿using AIOmedicare.Domain.Base;
using AIOmedicare.Domain.Domain.Doctor;
using AIOmedicare.Domain.Domain.Employee;
using System;
using System.Collections.Generic;

namespace AIOmedicare.Domain.Domain.Billing
{
    public class FeesBill : DomainObject
    {
        public Guid PatientID { get; set; }
        public Guid DoctorFeesID { get; set; }
        public Guid UserID { get; set; }

        public DateTime BillingDate { get; set; }

        public virtual DoctorFees DoctorFees { get; set; }
        public virtual Patient.Patient Patient { get; set; }
        public virtual User User { get; set; }
        public virtual IList<FeesBillPayment> Payments { get; set; }
    }
}