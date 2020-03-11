using CRUD.IRepositorio;
using CRUD.Models.Classe;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Controllers
{
    public class FormularioController : Controller
    {
        private readonly ICliente_Repositorio _repositorio;

        public FormularioController(ICliente_Repositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public IActionResult Index()
        {
            IList<Cliente> clientes = _repositorio.Listar();
            return View(clientes);
        }

        public IActionResult Cadastro()
        {
            var cliente = new Cliente();
            return PartialView(cliente);
        }

        [HttpPost]
        public IActionResult Cadastrar(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _repositorio.Adiciona(cliente);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Cadastro", cliente);
            }
        }

        public IActionResult Detalhar(int id)
        {
            var cliente = _repositorio.Detalhar(id);
            return PartialView(cliente);
        }

        public IActionResult Deletar(int id)
        {
            var cliente = _repositorio.Detalhar(id);
            return PartialView(cliente);
        }
        [HttpPost]
        public IActionResult Apagar(int id)
        {
            _repositorio.Remover(id);
            return RedirectToAction("Index");
        }
        
        public IActionResult Atualizar(int id)
        {
            var cliente = _repositorio.Detalhar(id);
            return View(cliente);
        }
        [HttpPost]
        public IActionResult Editar(int id, Cliente cliente)
        {
            var c = new Cliente();
            c.Id = id;
            c.Razao_Social = cliente.Razao_Social;
            c.Cnpj = cliente.Cnpj;
            c.Capital = cliente.Capital;
            c.Data_Fundacao = cliente.Data_Fundacao;
            c.Quarentena = cliente.Quarentena;
            c.status_cliente = cliente.status_cliente;
            c.classificacao = cliente.classificacao;
            _repositorio.Alterar(c);
            return RedirectToAction("Index");
        }
    }
}
