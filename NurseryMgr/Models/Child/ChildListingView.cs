using System;

namespace NurseryMgr.Models.Child
{
    public class ChildListingView
    {
        public int Id { get; set; }
        public string ImageUrl{get; set;}
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ParentName { get; set; }
        public string ClassLevel { get; set; }
    }
}