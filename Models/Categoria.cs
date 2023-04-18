using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace BSIStore.Models
{
    public class Categoria
    {
        public int Id {get; set;}

        [Display(Name="Descrição")]
        public string Descricao {get; set;}

        //Atributo de relacionamento
        public virtual List<Produto> Produtos {get; set;}

    }
}