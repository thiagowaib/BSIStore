using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BSIStore.Models 
{
    public class Funcionario
    {
        public int      id             {get; set;}

        [Display(Name = "Nome")]
        public string?  nome           {get; set;}

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime dataNascimento {get; set;}

        [Display(Name = "Cargo")]
        public string?  cargo          {get; set;}

        [Display(Name = "Salário (R$)")]
        [Column(TypeName = "decimal(18,2)")]
        public double   salario        {get; set;}
    }
}