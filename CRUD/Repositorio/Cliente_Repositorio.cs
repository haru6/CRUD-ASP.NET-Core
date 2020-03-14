using CRUD.Context;
using CRUD.IRepositorio;
using CRUD.Models.Classe;
using CRUD.Regra_de_Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Repositorio
{
    public class Cliente_Repositorio : ICliente_Repositorio
    {
        private readonly Banco_Dados _context;
        private readonly ICliente_Regras _regras;

        public Cliente_Repositorio(Banco_Dados context, ICliente_Regras regras)
        {
            _context = context;
            _regras = regras;
        }

        public void Adiciona (Cliente cliente)
        {
            cliente = _regras.complemento(cliente);
            cliente = _regras.quarentena(cliente);
            _context.Clientes.Add(cliente);
           _context.SaveChanges();
        }

        public Cliente Detalhar(int id)
        {
            var cliente = _context.Clientes.Find(id);
            return cliente;
        }

        public void Alterar(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            _context.SaveChanges();
        }
        
        public void Remover(int id)
        {
            var cliente = new Cliente() { Id = id };
            _context.Clientes.Remove(cliente);
            _context.SaveChanges();
        }

        public IList<Cliente> Listar()
        {
           return _context.Clientes.ToList();
        }
    }
}