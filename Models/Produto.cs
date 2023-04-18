using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BSIStore.Models
{
    public class Produto
    {
        public int Id {get; set;}
        [Display(Name="Descrição")]
        public string Descricao {get; set;}
        [DataType(DataType.Date)]
        public DateTime validade {get; set;}
        public string categoria {get; set;} 
        [Display(Name="Preço")]
        [Column(TypeName = "decimal(18,2)")]      
        public decimal preco {get; set;}

        // Atributo de Relacionamento
        public virtual Categoria Categoria {get; set;}
    }
}