using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using EntityFramework.Entities;

namespace EntityFramework.Identity
{
    public class ApplicationUser : IdentityUser
    {
        //[BindNever] // TO DO: Decide what do with this, i think add ASP.Core library in this project is bad choise
        public bool IsDeleted { get; set; } = false;

        [NotMapped]
        public Person GetEntity { get; set; }

        [NotMapped]
        public bool HasPerson
        {
            get
            {
                return PersonID != null && PersonType != PersonType.User;
            }
        }

        public int? PersonID { get; set; }

        public PersonType PersonType { get; set; }

    }

    public enum PersonType
    {
        User,
        CharityMaker,
        Volunteer,
        Orphan,
        Representative
        
    }
}

    

