using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NurseryMgrData;
using NurseryMgrData.Models;

namespace NurseryMgrServices
{
    public class ChildService : IChildFacade
    {

        private NurseryDbContext _context;
        public ChildService(NurseryDbContext context){
            _context=context;
        }
        public void CreateChild(Child newChild)
        {
            _context.Add(newChild);
            _context.SaveChanges();
        }

        public IEnumerable<Child> getAllChildren()
        {
           return _context.Children
                .Include(kid=>kid.Parent)
                .Include(kid=>kid.Class)
                .Include(kid=>kid.DailyActivity);
        }

        public Child getChildById(int id)
        {
            return _context.Children
                .Include(kid=>kid.Parent)
                .Include(kid=>kid.Class)
                .Include(kid=>kid.DailyActivity)
                .FirstOrDefault(kid=>kid.Id == id);
        }
        public Class getChildClass(int id)
        {
            return getChildById(id).Class;
        }
        public DateTime getDateOfBirth(int id)
        {
             return getChildById(id).DOB;
        }

        public string getFullName(int id)
        {
             return getChildById(id).FirstName + " "+ getChildById(id).LastName;
        }
        public Parent getChildParent(int id)
        {
            return getChildById(id).Parent;
        }
    }
}
