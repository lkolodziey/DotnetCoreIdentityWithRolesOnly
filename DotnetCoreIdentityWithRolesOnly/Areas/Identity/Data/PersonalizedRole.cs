using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetCoreIdentityWithRolesOnly.Areas.Identity.Data
{
    public class PersonalizedRole : IdentityRole
    {
        public PersonalizedRole() : base()
        {

        }

        public PersonalizedRole(string roleName)
        {
            Name = roleName;
        }


        [Required]
        [Column("DataInclusao")]
        public DateTime DataInclusao { get; set; }
    }
}
