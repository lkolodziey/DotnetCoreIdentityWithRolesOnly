using System;
using System.Threading.Tasks;
using DotnetCoreIdentityWithRolesOnly.Areas.Identity.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotnetCoreIdentityWithRolesOnly.Pages
{
    [Authorize(Roles = "Admin")]
    public class AddRoleModel : PageModel
    {
        private readonly RoleManager<PersonalizedRole> _roleManager;
        public AddRoleModel(RoleManager<PersonalizedRole> roleManager)
        {
            _roleManager = roleManager;
        }

        [BindProperty]
        public PersonalizedRole Role { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                Role.DataInclusao = DateTime.Now;
                await _roleManager.CreateAsync(Role);
            }
            return RedirectToPage("./ListRoles");
        }
    }
}