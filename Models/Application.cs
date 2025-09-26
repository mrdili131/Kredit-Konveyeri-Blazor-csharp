using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Konveyer.Models{
    public class Application{
        public int Id {get;set;}
        public string? Name {get;set;}
        public int? LimitAmount {get;set;}
        public int? Rate {get;set;}
        public int? MaxMonth {get;set;}
        public int? Fine {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
    }
}