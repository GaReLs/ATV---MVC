using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Primeira_ATV_MVC.Models;

namespace Primeira_ATV_MVC.ViewModels
{
    public class BuscaEventoViewModel
    {
         public string? NomeBusca {get; set;}
         public string? LocalBusca {get;set;}

         public DateTime? DataInicial {get;set;}

        public List<Evento> Resultados { get; set; } = new();
    }
}