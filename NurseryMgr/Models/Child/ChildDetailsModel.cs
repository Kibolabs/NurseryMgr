using System;
using System.Collections.Generic;
using NurseryMgrData.Models;

namespace NurseryMgr.Models.Child
{
    public class ChildDetailsModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ParentNames { get; set; }
        public string ImageUrl { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime GraduationDate { get; set; }
        public string TeacherName { get; set; }
        public string ClassLevel { get; set; }
        public string RegistrationStatus { get; set; }
        public bool isClassAssigned { get; set; }
        public IEnumerable<DailyActivity> ActivityHistory { get; set; }
    }
}