using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Carglass.TI.UI.ViewModels
{
    public class VeiculoAddEditVM
    {
        public int VehicleId { get; set; }

        [Required(ErrorMessage = "campo obrigatório")]
        public int VehicleBrandId { get; set; }

        [Required(ErrorMessage = "campo obrigatório")]
        public int VehicleTypeId { get; set; }

        [Required(ErrorMessage = "campo obrigatório")]
        [MinLength(2, ErrorMessage = "informe ao menos 2 caracteres")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "campo obrigatório")]
        public int Active { get; set; }
        
        [Required(ErrorMessage = "campo obrigatório")]
        public string VehicleCode { get; set; }



        public IEnumerable<SelectListItem> Marcas { get; set; }


    }
}
