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
            AssignStatus(childId,"Deregister");
            _context.Remove(childId);
        }

        private void AssignStatus(int childId, string status){
            var child = _context.Children
                .FirstOrDefault(ch=>ch.Id==childId);
                
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
            var now= DateTime .Now;

            AssignStatus(childId,"Registered");

                //registration updated
            var registered = _context.RegisteredChildrens
                .FirstOrDefault(re=>re.Child.Id==childId && re.RegistrationDate==null);

            if(registered!=null){
                _context.Update(registered);
                registered.RegistrationDate=now;
            }
        }

        public void Unregister(int childId){

            AssignStatus(childId,"Unregistered");
            if(childId !=null){
               _context.Remove();
            }


        }
    }
}