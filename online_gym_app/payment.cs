//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace online_gym_app
{
    using System;
    using System.Collections.Generic;
    
    public partial class payment
    {
        public payment()
        {
            this.customer_pay_class = new HashSet<customer_pay_class>();
        }
    
        public int payment_id { get; set; }
        public string method { get; set; }
        public Nullable<System.DateTime> date_ { get; set; }
        public Nullable<float> amount { get; set; }
        public Nullable<int> Receptionist_id { get; set; }
        public Nullable<int> customer_id { get; set; }
    
        public virtual customer customer { get; set; }
        public virtual ICollection<customer_pay_class> customer_pay_class { get; set; }
        public virtual receptionist receptionist { get; set; }
    }
}
