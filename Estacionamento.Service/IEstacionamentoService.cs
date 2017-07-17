using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Estacionamento.Service
{
    [ServiceContract]
    public interface IEstacionamentoService
    {
        [OperationContract]
        double Checkout(string placa);
        
        [OperationContract]
        string Checkin(string placa);

        [OperationContract]
        int VagasRestantes();

    }

}
