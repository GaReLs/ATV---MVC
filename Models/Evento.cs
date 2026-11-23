using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Primeira_ATV_MVC.Models
{
    public class Evento
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="o nome é obrigatorio")]
        [StringLength(80, MinimumLength = 5, ErrorMessage = "O nome deve ter entre 5 e 80 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="A descrição é obrigatoria")]
        [MinLength(10, ErrorMessage = "A descrição deve ter no minimo 10 caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage ="O Local é obrigatorio")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O local deve ter de 3 a 100 caracteres")]
        public string Local { get; set; }

        [Required(ErrorMessage ="A data do evento e obrigatoria")]
        [DataType(DataType.DateTime)]
        [DataEventoValida(ErrorMessage = "A data do evento não pode ser menor que a data atual")]
        public DateTime DataEvento {get; set;}

        [Range(1, 1000, ErrorMessage ="A qauntidade de vagas deve estar entre 1 e 1000")]
        public int QuantidadeVagas { get; set; }
        
        [Range(0, int.MaxValue)]
        public Decimal ValorIngresso {get;set;}
        
        
        
        
    }
}