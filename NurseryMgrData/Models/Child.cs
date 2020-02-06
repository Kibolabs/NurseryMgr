using System.Collections.Generic;

namespace NurseryMgrData.Models
{
    public class Child:Person
    {
        //public int Id { get; set; }
        public virtual Class Class { get; set; } 
        public virtual Parent Parent { get; set; }
        public RegistrationStatus RegistrationStatus { get; set; }

        public IEnumerable<DailyActivity> DailyActivity{get;set;} 
           
    }
}