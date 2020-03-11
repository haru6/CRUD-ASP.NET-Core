using CRUD.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models.Classe
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Razao_Social { get; set; }
        public string Cnpj { get; set; }
        public DateTime Data_Fundacao { get; set; }
        public decimal Capital { get; set; }
        public bool Quarentena { get; set; }
        public Status_Cliente status_cliente { get; set; }
        public Classificacao classificacao { get; set; }

    }
}
