using CRUD.IRepositorio;
using CRUD.Models.Classe;
using CRUD.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Regra_de_Negocio
{
    public class ClienteRegra : ICliente_Regras
    {
        public Cliente complemento (Cliente cliente)
        {
            if(cliente.Capital <= 10000)
            {
                cliente.status_cliente = Status_Cliente.Ativo;
                cliente.classificacao = Classificacao.C;
                return cliente;
            }
            else if (cliente.Capital <= 1000000)
            {
                cliente.status_cliente = Status_Cliente.Ativo;
                cliente.classificacao = Classificacao.B;
                return cliente;
            }
            else
            {
                cliente.status_cliente = Status_Cliente.Ativo;
                cliente.classificacao = Classificacao.A;
                return cliente;
            }
        }

        public Cliente quarentena (Cliente cliente)
        {
            if (DateTime.Now.Year > cliente.Data_Fundacao.Year)
            {
                if (DateTime.Now.Month >= cliente.Data_Fundacao.Month)
                {
                    if (DateTime.Now.Day >= cliente.Data_Fundacao.Day)
                    {
                        cliente.Quarentena = false;
                        return cliente;
                    }
                    else
                    {
                        cliente.Quarentena = true;
                        return cliente;
                    }
                }
                else
                {
                    cliente.Quarentena = true;
                    return cliente;
                }
            }
            else
            {
                cliente.Quarentena = true;
                return cliente;
            }
        }
    }
}
