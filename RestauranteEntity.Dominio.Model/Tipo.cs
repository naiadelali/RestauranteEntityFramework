using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RestauranteEntity.Dominio.Model
{
    [Serializable]
    public class Tipo
    {
        [Key]
        public int TipoId { get; set; }

        [Required(ErrorMessage="O tipo é obrigatório")]
        public string Nome { get; set; }

        public virtual IEnumerable<Prato>  Pratos { get; set; }
    }
}
