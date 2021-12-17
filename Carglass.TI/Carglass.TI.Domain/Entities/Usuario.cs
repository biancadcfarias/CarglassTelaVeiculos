using Carglass.TI.Domain.Enums;
using System.Collections.Generic;

namespace Carglass.TI.Domain.Entities
{
    public class Usuario : Entity
    {
        public int Id {  get; set; }
        public string Nome { get; set; }

        public string Email { get; set; }
        public string Senha { get; set; }

        public Genero Genero { get; set; }

        public IEnumerable<Perfil> Perfis { get; set; }
    }
}
