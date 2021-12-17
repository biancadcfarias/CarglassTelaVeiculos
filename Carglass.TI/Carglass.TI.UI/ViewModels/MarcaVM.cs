using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Carglass.TI.UI.ViewModels
{
    public class MarcaAddEditVM
    {
        public int VehicleBrandId { get; set; }

        [Required(ErrorMessage = "campo obrigatório")]
        [MinLength(2, ErrorMessage = "informe ao menos 2 caracteres")]
        public string Name { get; set; }
    }

}
