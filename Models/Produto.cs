using System.ComponentModel.DataAnnotations;

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
        public double   preco        {get; set;}
    }
}