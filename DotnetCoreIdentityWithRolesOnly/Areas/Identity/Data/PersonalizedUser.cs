using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace DotnetCoreIdentityWithRolesOnly.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the DotnetCoreIdentityWithRolesOnlyUser class
    public class PersonalizedUser : IdentityUser
    {
        [Required]
        [Display(Name = "Nome Completo")]
        public string NomeCompleto { get; set; }

        //[Required]
        //[Display(Name = "No. Agente")]
        //public int AgenteNumero { get; set; }

        //[Display(Name = "Data Inclusão")]
        //public DateTime DataInclusao { get; set; }

        //[Display(Name = "Data Alteração")]
        //public DateTime DataAlteracao { get; set; }

        //[Display(Name = "Data Alteração Senha")]
        //public DateTime DataAlteracaoSenha { get; set; }


       List<PersonalizedRole> Roles { get; set; }

    }
}
