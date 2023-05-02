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
        [Display(Name="Categoria")]
        public string categoria {get; set;} 
        [Display(Name="Categoria")]
        public int CategoriaId {get; set;} 
        [Display(Name="Preço")]
        [DataType(DataType.Currency)]
        public double preco {get; set;}

        // Atributo de Relacionamento
        public virtual Categoria Categoria {get; set;}
    }
}