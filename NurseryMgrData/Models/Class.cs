using System.Collections.Generic;

namespace NurseryMgrData.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual School School { get; set; }
        public IEnumerable<Child> Children{get; set;}

    }
}