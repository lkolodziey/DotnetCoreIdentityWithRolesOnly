using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetCoreIdentityWithRolesOnly.Areas.Identity.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotnetCoreIdentityWithRolesOnly.Pages
{
    [Authorize(Roles = "Admin")]
    public class AboutModel : PageModel
    {
        UserManager<PersonalizedUser> _userManager;
        RoleManager<PersonalizedRole> _roleManager;

        public AboutModel(UserManager<PersonalizedUser> userManager, RoleManager<PersonalizedRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }



        public string Message { get; set; }

        public void OnGet()
        {
            var result = _userManager.Users.Where(i=>i.UserName == User.Identity.Name);


            Message = "Your application description page.";
        }
    }
}
