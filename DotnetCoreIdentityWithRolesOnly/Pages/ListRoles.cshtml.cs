using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DotnetCoreIdentityWithRolesOnly.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotnetCoreIdentityWithRolesOnly.Pages
{
    public class ListRolesModel : PageModel
    {
        private readonly RoleManager<PersonalizedRole> _roleManager;

        public ListRolesModel(RoleManager<PersonalizedRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public List<PersonalizedRole> Roles { get; set; }

        public void OnGet()
        {
            var userRoles = ((ClaimsIdentity)User.Identity).Claims
                            .Where(c => c.Type == ClaimTypes.Role)
                            .Select(c => c.Value).First();



            Roles = _roleManager.Roles.ToList();
        }
    }
}