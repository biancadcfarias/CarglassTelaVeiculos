using Carglass.TI.Domain.Contracts.Infra;
using Carglass.TI.Domain.Contracts.Repositories;
using Carglass.TI.Domain.Entities;
using Carglass.TI.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Carglass.TI.UI.Controllers
{
    public class MarcasController : Controller
    {
        private readonly IMarcaRepository _marcaRepository;
        private readonly IUnitOfWork _uow;

        public MarcasController(
            IMarcaRepository marcaRepository,
            IUnitOfWork uow)
        {
            _marcaRepository = marcaRepository;
            _uow = uow;
        }

        public async Task<IActionResult> Index()
        {
            var marcas = await _marcaRepository.GetAsync();
            return View(marcas);
        }

        public async Task<IActionResult> AddEdit(int id) 
        {
            MarcaAddEditVM model = null;

            if (id > 0)
            {
                var data = await _marcaRepository.GetAsync(id);
                model = new MarcaAddEditVM();
                model.BrandName = data.Name;
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddEdit(MarcaAddEditVM model)
        {
            if (ModelState.IsValid)
            {
                if (model.VehicleBrandId == 0)
                {
                    var marca = new Marca();
                    marca.Name = model.BrandName;
                    _marcaRepository.Add(marca);
                } else
                {
                    var marca = await _marcaRepository.GetAsync(model.VehicleBrandId);
                    marca.Name = model.BrandName;
                    marca.DataAlteracao = DateTime.Now;
                    _marcaRepository.Update(marca);
                }
                await _uow.CommitAsync();
                return RedirectToAction("Index");
            }

            return View();

        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var marca = await _marcaRepository.GetAsync(id);
            if (marca == null)
            {
                return NotFound();
            }

            try
            {
                _marcaRepository.Delete(marca);
                await _uow.CommitAsync();
            }
            catch (DbUpdateException) {
                return BadRequest("Essa marca já possui o veículo cadastrado.");
            }
            catch
            {
                // Criar log
                return new StatusCodeResult(500);
            }
            return Ok();
        }


    }
}
