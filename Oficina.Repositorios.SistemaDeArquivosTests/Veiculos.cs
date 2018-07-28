using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaDeArquivosTests
{
    class Veiculos
    {
        //public Veiculo()
        //{
        //    Id = Guid.NewGuid();
        //}


        public Guid Id { get; set; } = Guid.NewGuid();
        public string Placa { get; set; }
        public int Ano { get; set; }
        public string Observacao { get; set; }

        public Modelo Modelo { get; set; }
        public Cor Cor { get; set; }

        public Combustivel Combustivel { get; set; }
        public Cambio Cambio { get; set; }

    }
}
