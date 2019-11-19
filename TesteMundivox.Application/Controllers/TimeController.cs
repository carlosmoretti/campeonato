using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TesteMundivox.UnitOfWork.Interfaces;

namespace TesteMundivox.Application.Controllers
{
    public class TimeController : Controller
    {
        private IUnitOfWork _unitOfWork;
        public TimeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(TesteMundivox.Entities.Times time)
        {
            if (ModelState.IsValid)
            {
                if (_unitOfWork.TimeRepository.GetAll().Any(d => d.Nome.ToUpper() == time.Nome.ToUpper()))
                {
                    TempData["mensagem"] = "Já existe um time com este nome!";
                    return View();
                }

                _unitOfWork.TimeRepository.Add(time);
                _unitOfWork.Commit();

                TempData["mensagem"] = "O time foi cadastrado com sucesso!";
            } else
            {
                TempData["mensagem"] = "Não foi possível cadastrar este time!";
            }

            return View();
        }

    }
}