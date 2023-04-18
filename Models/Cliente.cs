using System;
using System.ComponentModel.DataAnnotations;

namespace BSIStore.Models
{
    public class Cliente
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        [Display(Name = "C.P.F.")]
        public string CPF {get; set;}
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DtNasc {get; set;}
        [Display(Name = "E-Mail")]
        public string Email {get; set;}
    }

}