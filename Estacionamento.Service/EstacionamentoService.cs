using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Estacionamento.Service
{
    public class EstacionamentoService : IEstacionamentoService
    {
        public double Checkout(string placa)
        {
            return Estacionamento.Negocio.Operacoes.Checkout(placa);
        }

        public string Checkin(string placa)
        {
            return Estacionamento.Negocio.Operacoes.Checkin(placa);
        }

        public int VagasRestantes()
        {
            return Estacionamento.Negocio.Operacoes.VAGAS_TOTAIS - Estacionamento.Negocio.Operacoes._estacionamento.Count();
        }
        
    }
}
