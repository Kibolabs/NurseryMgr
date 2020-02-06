using System;
namespace NurseryMgrData.Models
{
    public class DailyActivity
    {
        public int Id { get; set; }
        public DateTime DateRecorded { get; set; }
        public string Comment { get; set; }
        public Child Child { get; set; }
    }
}