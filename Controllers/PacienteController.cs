using AplicacaoTestePacienteCore.Data;
using AplicacaoTestePacienteCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacaoTestePacienteCore.Controllers
{
    public class PacienteController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PacienteController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Criar(int? id)
        {
            Paciente paciente = new Paciente();
            if(id == null)
            {
                return View(paciente);
            }
            else
            {
                paciente = await _db.Paciente.FindAsync(id);
                return View(paciente);
            }
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar(Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                if(paciente.Id == 0)        //Cria um paciente
                {
                    await _db.Paciente.AddAsync(paciente);
                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Criar));
                }
                else
                {
                    _db.Paciente.Update(paciente);
                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Criar), new { id=0});
                }
                
            }
            return View(paciente);
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            var todos = await _db.Paciente.ToListAsync();
            return Json(new { data = todos });
        }
    }
}
