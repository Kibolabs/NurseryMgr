using System;
using System.Collections.Generic;
using NurseryMgrData.Models;

namespace NurseryMgrData
{
    public interface IChildFacade
    {
         IEnumerable<Child> getAllChildren();
         Child getChildById(int id);
         void CreateChild(Child newChild);
         Class getChildClass(int id);
         Parent getChildParent(int id);
         string getFullName(int id);
         DateTime getDateOfBirth(int id);
         


    }
}