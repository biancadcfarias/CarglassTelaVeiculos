using Carglass.TI.Domain.Contracts.Infra;
using Carglass.TI.Domain.Contracts.Repositories;
using Carglass.TI.Domain.Entities;
using Carglass.TI.Domain.Enums;
using Carglass.TI.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Carglass.TI.UI.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IUnitOfWork _uow;

        public UsuariosController(
            IUsuarioRepository usuariorepository,
            IUnitOfWork uow)
        {
            _usuarioRepository = usuariorepository;
            _uow = uow;
        }

        public async Task<IActionResult> Index()
        {
            var usuarios = await _usuarioRepository.GetAsync();
            return View(usuarios);
        }

        public async Task<IActionResult> AddEdit(int id)
        {
            UsuarioAddEditVM model = new UsuarioAddEditVM();
            model.Generos = carregarDDLGeneros();

            if (id > 0)
            {
                var data = await _usuarioRepository.GetAsync(id);
                model.Id = data.Id;
                model.Nome = data.Nome;
                model.Email = data.Email;
                model.Senha = data.Senha;
            }
            return View(model);
        }



        [HttpPost]
        public async Task<IActionResult> AddEdit(UsuarioAddEditVM model)
        {
            if (ModelState.IsValid)
            {
                if (model.Id == 0)
                {
                    var usuario = new Usuario();
                    usuario.Nome = model.Nome;
                    usuario.Email = model.Email;
                    usuario.Senha = model.Senha;
                    usuario.Genero = (Genero)model.Genero;
                    _usuarioRepository.Add(usuario);
                }
                else
                {
                    var usuario = await _usuarioRepository.GetAsync(model.Id);
                    usuario.Nome = model.Nome;
                    usuario.Email = model.Email;
                    usuario.Genero = (Genero)model.Genero;
                    usuario.DataAlteracao = DateTime.Now;
                    _usuarioRepository.Update(usuario);
                }
                await _uow.CommitAsync();
                return RedirectToAction("Index");
            }

            model.Generos = carregarDDLGeneros();
            return View(model);

        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var veiculo = await _usuarioRepository.GetAsync(id);
            if (veiculo == null)
            {
                return NotFound();
            }

            try
            {
                _usuarioRepository.Delete(veiculo);
                await _uow.CommitAsync();
            }

            catch
            {
                // Criar log
                return new StatusCodeResult(500);
            }
            return Ok();
        }


        private IEnumerable<SelectListItem> carregarDDLGeneros()
        {
            var ddlGeneros = new List<SelectListItem>();
            var generos = Enum.GetValues(typeof(Genero));
            foreach (Genero g in generos)
            {
                var text = Enum.GetName(g);
                var value = (int)g;

                ddlGeneros.Add(new SelectListItem(text, value.ToString()));
            }
            return ddlGeneros;
        }
    }
}
