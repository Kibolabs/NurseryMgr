using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NurseryMgr.Models.Child;
using NurseryMgrData;

namespace NurseryMgr.Controllers
{
    public class ChildController : Controller {
        private IChildFacade _children;

        public ChildController(IChildFacade children){
            _children=children;
        }

        public IActionResult Index(){
            var childModels = _children.getAllChildren();

            var listing = childModels.Select(res=> new ChildListingView
            {
                Id=res.Id,
                Name=res.FirstName,
                DateOfBirth=res.DOB,
                ParentName=res.Parent.FirstName,
                ClassLevel=res.Class.Name
            });

            var model = new ChildIndexModel(){
                Children=listing
            };
            return View(model);
        }

        public IActionResult Details (int id){
            var child = _children.getChildById(id);

            var model = new ChildDetailsModel(){
                Id=id,
                FullName=_children.getFullName(id),
                DateOfBirth=_children.getDateOfBirth(id),
                ParentNames=_children.getChildParent(id).LastName,
                ClassLevel=_children.getChildClass(id).Name,
                TeacherName=_children.getChildClass(id).Teacher.LastName,
                RegistrationStatus=child.RegistrationStatus.Name,
                RegistrationDate=child.RegistrationStatus.RegistrationDate

            };
           return View(model); 
         }
    
    }
}