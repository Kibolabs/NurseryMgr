using System;

namespace NurseryMgrData.Models
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }  
        public DateTime DOB { get; set; } 
        public string ImageUrl { get; set; }
    }
}