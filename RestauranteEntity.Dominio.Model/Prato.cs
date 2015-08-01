using System;
using System.ComponentModel.DataAnnotations;

namespace RestauranteEntity.Dominio.Model
{
    [Serializable]
    public class Prato
    {
        [Key]
        public int PratoId { get; set; }

        [Required(ErrorMessage="O nome é obrigatório")]
        [MaxLength(150), MinLength(2)]
        public string Nome { get; set; }

        [Required(ErrorMessage="A descricao é obrigatória")]
        [MinLength(2),MaxLength(250)]
        public string Descricao { get; set; }

        public int TipoId { get; set; }

        public virtual Tipo Tipo { get; set; }
    }
}
