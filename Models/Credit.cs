using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Konveyer.Models{

    public enum Status {
        Done,
        Pending,
        Rejected
    }

    public class Credit{
        public int Id {get;set;}

        public int? ClientId {get;set;}

        public string? ContractId {get;set;}

        public int? ApplicationId {get;set;}

        public int amount {get;set;} = 0;

        public int? PayDay {get;set;}

        public int? Rate {get;set;}

        public DateTime StartDate {get;set;} = DateTime.Now;

        public DateTime? EndDate {get;set;}

        public string? Description {get;set;}

        public int? UserId {get;set;}

        public int? FilialId {get;set;}

        public Status Status {get;set;} = Status.Pending;

        public DateTime CreatedAt {get;set;} = DateTime.Now;
    }
}