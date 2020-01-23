using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Install  entity framework 6 on Tools > Manage Nuget Packages > Microsoft Entity Framework (ver 6.4)
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetGrooming.Models
{
    public class Groomer
    {
        [Key]
        public Int GroomerID { get; set; }
        public String GroomerFirstName { get; set; }
        public String GroomerLastName { get; set; }
        public String GroomerContact { get; set; }
        public String GroomerAddress { get; set; }
        public Int GroomerExperience { get; set; }
        public Date GroomerDateOfBirth { get; set; }
        public Int GroomerHourlyRate { get; set; }
        /* 
            A groomer is someone who is employed to groom pets
            Some things that describe a groomer
                - First Name
                - Last Name
                - Date of Birth
                - Phone Number
                - Hourly Rate

            A booking must reference to a groomer
        */
    }
}