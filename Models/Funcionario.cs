using System.ComponentModel.DataAnnotations;

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
        public double   salario        {get; set;}
    }
}