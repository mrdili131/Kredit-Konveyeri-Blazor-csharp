using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Konveyer.Models{

    public enum Gender {
        Male,
        Female
    }

    public enum Education {
        Oliy,
        Orta,
        OrtaMaxsus,
        TuallanmaganOliy,
        Yoq
    }


    public class Client{
        // Client's data
        public int Id {get;set;}

        [MaxLength(50)]
        public string? FirstName {get;set;}

        [MaxLength(50)]
        public string? LastName {get;set;}

        [MaxLength(50)]
        public string? MiddleName {get;set;}

        [Range(typeof(DateTime),"1/1/1900","1/1/2025")]
        public DateTime? born_in {get;set;}

        public Gender? Gender {get;set;}

        public Education? Education {get;set;}

        public string? ClientCountry {get;set;}

        public string? ClientRegion {get;set;}

        // Passport data
        [MaxLength(2)]
        public string? PassportLetter {get;set;}

        [MaxLength(6)]
        public int? PassportNumber {get;set;}

        [MaxLength(50)]
        public string? PassportGotRegion {get;set;}

        public string? PassportGotCountry {get;set;}

        public int? PassportPinfl {get;set;}

        public DateTime? PassportGotDate {get;set;}


        // BaseAddress
        public string? BaseCountry {get;set;}

        public string? BaseRegion {get;set;}

        public string? BaseCity {get;set;}

        public string? BaseAddress {get;set;}

        // Current Address
        public string? CurrentCountry {get;set;}

        public string? CurrentRegion {get;set;}

        public string? CurrentCity {get;set;}

        public string? CurrentAddress {get;set;}

        // Other data
        public string? Description {get;set;}

        public string? FilialId {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;

    }
}