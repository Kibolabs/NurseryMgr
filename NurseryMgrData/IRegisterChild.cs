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
         void MarkRegistered(int childId);
         void Unregister(int childId);
         void Deregister(int childId);
         void Add(RegisterChild newRegisterChild);

    }
}