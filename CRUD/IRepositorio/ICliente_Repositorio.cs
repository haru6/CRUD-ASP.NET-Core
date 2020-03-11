using CRUD.Models.Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.IRepositorio
{
    public interface ICliente_Repositorio
    {
        void Adiciona(Cliente cliente);

        Cliente Detalhar(int id);

        void Alterar(Cliente cliente);

        void Remover(int id);

        IList<Cliente> Listar();
    }
}