using CRUD.Context;
using CRUD.IRepositorio;
using CRUD.Models.Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Repositorio
{
    public class Cliente_Repositorio : ICliente_Repositorio
    {
        private readonly Banco_Dados _context;

        public Cliente_Repositorio(Banco_Dados context)
        {
            _context = context;
        }

        public void Adiciona (Cliente cliente)
        {
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