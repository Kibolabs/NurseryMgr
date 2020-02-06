using System;
using System.Collections.Generic;
using NurseryMgrData.Models;

namespace NurseryMgrData
{
    public interface IRegisterChild
    {
         DateTime getRegistrationDate(int id);
         IEnumerable<RegisterChild> GetAll();
         RegisterChild GetById(int id);
         void Unregister(int childId);
         void Deregister(int childId);
         string GetTeacherName(int childId);
         void AddToClass(int childId);
         void Register(RegisterChild newRegisterChild);
         void AssignTeacher(int id);
         void AddDailyActivity(DailyActivity newActivity); 
         void AssignParent(int id); 
         IEnumerable<DailyActivity> GetCurrentDailyActivity(int id);
    }
}