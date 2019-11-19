using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TesteMundivox.Application.Models;
using TesteMundivox.Application.ViewModels;
using TesteMundivox.Repositories.Interface;
using TesteMundivox.UnitOfWork.Interfaces;

namespace TesteMundivox.Application.Controllers
{
    public class HomeController : Controller
    {
        private IUnitOfWork _unitOfWork;
        public HomeController(IJogoRepository jogoRepository, ITimeRepository timeRepository, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View(new TabelaVM()
            {
                Jogos = _unitOfWork.JogoRepository.GetAll().ToList(),
                Times = _unitOfWork.TimeRepository.GetAll().ToList()
            });
        }

        [HttpPost]
        public JsonResult CadastrarEvento([FromBody]CadastrarTabelaVM vm)
        {
            try
            {
                var times = _unitOfWork.TimeRepository.GetAll();
                _unitOfWork.JogoRepository.Add(new Entities.Jogos()
                {
                    Time1_Id = times.Where(d => d.Nome == vm.Time1).FirstOrDefault().Id,
                    Time2_Id = times.Where(d => d.Nome == vm.Time2).FirstOrDefault().Id,
                    TimeVencedor_Id = times.Where(d => d.Nome == vm.TimeVencedor).FirstOrDefault().Id
                });

                _unitOfWork.Commit();

                return Json("OK");
            } catch(Exception)
            {
                return Json("NOK");
            }
        }
    }
}
