using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Negocio
{
    /// <summary>
    /// Classe com as operações de um estacionamento.
    /// </summary>
    public sealed class Operacoes
    {
        public const int VAGAS_TOTAIS = 15;
        public static IDictionary<string, DateTime> _estacionamento = new Dictionary<string, DateTime>();

        /// <summary>
        /// Valida se a operação checkin pode ser realizada
        /// </summary>
        private static bool ValidarCheckin(string placa,out string retorno)
        {
            if (String.Equals(placa.Trim(), string.Empty))
            {
                retorno = String.Format("Placa inválida.", placa);
                return false;
            }

            if (_estacionamento.Count == VAGAS_TOTAIS)
            {
                retorno = "Estacionamento cheio!";
                return false;
            }

            if (_estacionamento.ContainsKey(placa))
            {
                retorno = String.Format("Carro placa '{0} já existe!", placa);
                return false;
            }
            retorno = "";
            return true;
        }

        /// <summary>
        /// Valida se a operação de checkout pode ser realizada
        /// </summary>
        private static bool ValidarCheckout(string placa)
        { 
            if (String.Equals(placa.Trim(), string.Empty))
                throw new Exception(String.Format("Placa inválida.", placa));

            if (!_estacionamento.ContainsKey(placa))
                throw new Exception(String.Format("Carro placa '{0}' NÃO existe!", placa));

            return true;
        }

        /// <summary>
        /// Registra a entrada de um carro no estacionamento.
        /// </summary>
        public static string Checkin(string placa)
        {
            var retorno = "";
            if(ValidarCheckin(placa,out retorno))
            {
                _estacionamento.Add(placa, DateTime.Now);
            }

            return retorno;
        }

        /// <summary>
        /// Registra a saída de um carro do estacionamento.
        /// </summary>
        public static double Checkout(string placa)
        {
            ValidarCheckout(placa);
            DateTime horaEntrada = _estacionamento[placa];

            _estacionamento.Remove(placa);

            return CalcularValorEstacionamento(horaEntrada, DateTime.Now);
        }

        /// <summary>
        /// Calcula o valor com base no tempo de permanência
        /// </summary>
        private static double CalcularValorEstacionamento(DateTime entrada, DateTime saida)
        {
            var permanencia = saida.Subtract(entrada);
            return Math.Round((permanencia.TotalMinutes / 3), 2); // 3 reais é o valor mínimo
        }

    }
}
