using CRUD.Models.Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.IRepositorio
{
    public interface ICliente_Regras
    {
        Cliente complemento(Cliente cliente);

        Cliente quarentena(Cliente cliente);
    }
}
