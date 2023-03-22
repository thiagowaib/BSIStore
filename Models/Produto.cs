using System.ComponentModel.DataAnnotations;

namespace BSIStore.Models 
{
    public class Produto
    {
        public int      id           {get; set;}
        public string?  descricao    {get; set;}

        [DataType(DataType.Date)]
        public DateTime dataValidade {get; set;}

        public string?  categoria    {get; set;}
        public double   preco        {get; set;}
    }
}