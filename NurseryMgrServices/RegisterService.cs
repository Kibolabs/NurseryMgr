using System;
using System.Collections.Generic;
using System.Linq;
using NurseryMgrData;
using NurseryMgrData.Models;

namespace NurseryMgrServices
{
    public class RegisterService : IRegisterChild
    {
        private NurseryDbContext _context;
        public RegisterService(NurseryDbContext context){
            _context=context;
        }

        public void Add(RegisterChild newRegisterChild)
        {
            _context.Add(newRegisterChild);
            _context.SaveChanges();
        }

        public void Deregister(int childId)
        {
            AssignStatus(childId,"Deregistered");
            _context.Remove(childId);
        }

        private void AssignStatus(int childId, string status){
            var child = _context.Children
                .FirstOrDefault(ch=>ch.Id==childId);

                _context.Update(child);
                
            child.RegistrationStatus = _context.RegistrationStatuses
                .FirstOrDefault(regstatus=>regstatus.Name==status);  
        }

        public IEnumerable<RegisterChild> GetAll()
        {
           return _context.RegisteredChildrens;
        }

        public RegisterChild GetById(int id)
        {
            return GetAll().FirstOrDefault(regs=>regs.Id==id);
        }

        public DateTime getRegistrationDate(int id)
        {
            return GetById(id).RegistrationDate;
        }

        public void MarkRegistered(int childId)
        {
            var now= DateTime.Now;

            AssignStatus(childId,"Registered");

                //registration updated
            var registered = _context.RegisteredChildrens
                .FirstOrDefault(re=>re.Child.Id==childId && re.RegistrationDate==null);

            if(registered!=null){
                _context.Update(registered);
                registered.RegistrationDate=now;
            }
        }

        public void Unregister(int childId)
        {

            AssignStatus(childId, "Unregistered");
            _context.Remove(childId);


        }

        public string GetTeacherName(int childId)
        {
            // this is wrong querying the wrong table.
            return _context.Child
                .Include(t=>t.Class)
                .Where(t=>t.Class.Id==childId);
        }

        public void AddToClass(int childId)
        {
            throw new NotImplementedException();
        }

        public void Register(RegisterChild newRegisterChild)
        {
            throw new NotImplementedException();
        }

        public void AssignTeacher(int id)
        {
            throw new NotImplementedException();
        }

        public void AddDailyActivity(DailyActivity newActivity)
        {
            _context.Add(newActivity);
            _context.SaveChanges();
        }

        public void AssignParent(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DailyActivity> GetCurrentDailyActivity(int id)
        {
            //revisit this method may be activities need a new table or not.
            return _context.DailyActivity
                .Include(a=>a.Child)
                .Where(a=>a.Child.Id==id);
        }
    }
}