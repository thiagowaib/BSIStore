using System.ComponentModel.DataAnnotations;

namespace BSIStore.Models 
{
    public class Funcionario
    {
        public int      id             {get; set;}
        public string?  nome           {get; set;}

        [DataType(DataType.Date)]
        public DateTime dataNascimento {get; set;}

        public string?  cargo          {get; set;}
        public double   salario        {get; set;}
    }
}