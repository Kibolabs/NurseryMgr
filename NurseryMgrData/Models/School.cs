using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NurseryMgrData.Models
{
    public class School
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual Principal Principal { get; set; }
        public IEnumerable<Class> Classes { get; set; }
    }
}