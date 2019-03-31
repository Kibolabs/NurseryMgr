using System;

namespace NurseryMgrData.Models
{
    public class RegisterChild
    {
        public int Id { get; set; }
        public DateTime RegistrationDate { get; set; }
        public Child Child { get; set; }
    }
}