using Carglass.TI.Domain.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Carglass.TI.UI.ViewModels
{
    public class UsuarioAddEditVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "campo obrigatório")]
        [MinLength(5, ErrorMessage = "informe ao menos 5 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "campo obrigatório")]
        [EmailAddress(ErrorMessage = "email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "campo obrigatório")]
        [MinLength(5, ErrorMessage = "informe ao menos 5 caracteres")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "campo obrigatório")]

        public Genero? Genero { get; set; }
        public IEnumerable<SelectListItem> Generos { get; set; }
    }
}
