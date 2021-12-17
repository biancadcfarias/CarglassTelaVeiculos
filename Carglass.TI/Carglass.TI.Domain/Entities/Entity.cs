using System;

namespace Carglass.TI.Domain.Entities
{
    public abstract class Entity // new Entity() -> não pode pois é abstract
    {
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public DateTime DataAlteracao { get; set; } = DateTime.Now;
    }
}
