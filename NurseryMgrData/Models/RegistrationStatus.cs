using System;

namespace NurseryMgrData.Models
{
    public class RegistrationStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string TuituinComment { get; set; }
    }
}