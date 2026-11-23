using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Primeira_ATV_MVC.Models;
using Primeira_ATV_MVC.ViewModels;

namespace Primeira_ATV_MVC.Controllers
{
    public class EventosController : Controller
    {
        private static List<Evento> _evento = new()
        {
            new Evento {Id = 1, Nome = "Campeonato de natação",Descricao = "Campeonato nacional de natação" ,Local ="Campo natação", DataEvento = DateTime.Today.AddDays(1), QuantidadeVagas = 100, ValorIngresso = 100m }
        };
        public IActionResult Index()
        {
            return View(_evento);
        }
        public IActionResult Detalhes(int id)
        {
            var evento = _evento.FirstOrDefault(a => a.Id == id);

            if(evento == null) return NotFound();
            return View(evento);
        }
          [HttpGet]

          public IActionResult Criar()
          { return View();}

          [HttpPost]

          public IActionResult Criar(Evento evento)
        {
            if(!ModelState.IsValid) return View(evento);
            evento.Id = _evento.Any() ? _evento.Max(a => a.Id) + 1 : 1;
            _evento.Add(evento);
                return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Buscar()
        {
            return View(new BuscaEventoViewModel());
        }

        [HttpPost]

        public IActionResult Buscar(BuscaEventoViewModel vm)
        {
            vm.Resultados = _evento; 

            if(!string.IsNullOrEmpty(vm.NomeBusca))
            {
                vm.Resultados = _evento.Where(a => a.Nome.Contains(vm.NomeBusca, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            return View(vm);
        }

    }
}