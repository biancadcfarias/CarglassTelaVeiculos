using Carglass.TI.Domain.Contracts.Infra;
using Carglass.TI.Domain.Contracts.Repositories;
using Carglass.TI.Domain.Entities;
using Carglass.TI.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carglass.TI.UI.Controllers
{
    public class VeiculosController : Controller
    {
        //DI/IoC
        private readonly IVeiculoRepository _veiculoRepository;
        private readonly IMarcaRepository _marcaRepository;
        private readonly IUnitOfWork _uow;

        public VeiculosController(
            IVeiculoRepository veiculoRepository, 
            IMarcaRepository marcaRepository,
            IUnitOfWork uow)
        {
            _veiculoRepository = veiculoRepository;
            _marcaRepository = marcaRepository;
            _uow = uow;
        }

        public async Task<IActionResult> Index()
        {
            var veiculos = await _veiculoRepository.GetWithMarcaAsync();
            ViewBag.Title = "Veiculos";
            return View(veiculos);
        }

        public async Task<IActionResult> AddEdit(int id)
        {
            VeiculoAddEditVM model = new VeiculoAddEditVM();
            model.Marcas = await carregarDDLMarcasAsync();

            if (id > 0)
            {
                var data = await _veiculoRepository.GetAsync(id);
                model.VehicleId = data.VehicleId;
                model.VehicleBrandId = data.VehicleTypeId;
                model.VehicleTypeId = data.VehicleTypeId;
                model.Name = data.Name;
                model.Active = data.Active;
                model.VehicleCode = data.VehicleCode;

            }
            return View(model);
        }

        private async Task<IEnumerable<SelectListItem>> carregarDDLMarcasAsync()
        {
            
            var marcas = await _marcaRepository.GetAsync();
            return marcas.Select(x => new SelectListItem { Value = x.VehicleBrandId.ToString(), Text = x.Name });
        }

        [HttpPost]
        public async Task<IActionResult> AddEdit(VeiculoAddEditVM model)
        {
            if (ModelState.IsValid)
            {
                if (model.VehicleId == 0)
                {
                    var veiculo = new Veiculo();
                    veiculo.VehicleBrandId = (int)model.VehicleBrandId;
                    veiculo.VehicleTypeId = (int)model.VehicleTypeId;
                    veiculo.Name = model.Name;
                    veiculo.Active = (int)model.Active;
                    veiculo.VehicleCode = model.VehicleCode;
                    _veiculoRepository.Add(veiculo);
                }
                else
                {
                    var veiculo = await _veiculoRepository.GetAsync(model.VehicleId);
                    veiculo.VehicleBrandId = (int)model.VehicleBrandId;
                    veiculo.VehicleTypeId = (int)model.VehicleTypeId;
                    veiculo.Name = model.Name;
                    veiculo.Active = (int)model.Active;
                    veiculo.VehicleCode = model.VehicleCode;
                    veiculo.DataAlteracao = DateTime.Now;
                    _veiculoRepository.Update(veiculo);
                }
                await _uow.CommitAsync();
                return RedirectToAction("Index");
            }

            model.Marcas = await carregarDDLMarcasAsync();
            return View(model);

        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var veiculo = await _veiculoRepository.GetAsync(id);
            if (veiculo == null)
            {
                return NotFound();
            }

            try
            {
                _veiculoRepository.Delete(veiculo);
                await _uow.CommitAsync();
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
