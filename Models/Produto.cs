using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BSIStore.Models 
{
    public class Produto
    {
        public int      id           {get; set;}

        [Display(Name = "Descrição")]
        public string?  descricao    {get; set;}

        [Display(Name = "Data de Validade")]
        [DataType(DataType.Date)]
        public DateTime dataValidade {get; set;}

        [Display(Name = "Categoria")]
        public string?  categoria    {get; set;}

        [Display(Name = "Preço (R$)")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal   preco        {get; set;}
    }
}