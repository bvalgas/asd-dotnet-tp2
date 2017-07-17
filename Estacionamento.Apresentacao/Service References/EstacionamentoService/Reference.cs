﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.34209
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace Estacionamento.Apresentacao.EstacionamentoService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EstacionamentoService.IEstacionamentoService")]
    public interface IEstacionamentoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstacionamentoService/Checkout", ReplyAction="http://tempuri.org/IEstacionamentoService/CheckoutResponse")]
        double Checkout(string placa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstacionamentoService/Checkout", ReplyAction="http://tempuri.org/IEstacionamentoService/CheckoutResponse")]
        System.Threading.Tasks.Task<double> CheckoutAsync(string placa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstacionamentoService/Checkin", ReplyAction="http://tempuri.org/IEstacionamentoService/CheckinResponse")]
        string Checkin(string placa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstacionamentoService/Checkin", ReplyAction="http://tempuri.org/IEstacionamentoService/CheckinResponse")]
        System.Threading.Tasks.Task<string> CheckinAsync(string placa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstacionamentoService/VagasRestantes", ReplyAction="http://tempuri.org/IEstacionamentoService/VagasRestantesResponse")]
        int VagasRestantes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstacionamentoService/VagasRestantes", ReplyAction="http://tempuri.org/IEstacionamentoService/VagasRestantesResponse")]
        System.Threading.Tasks.Task<int> VagasRestantesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEstacionamentoServiceChannel : Estacionamento.Apresentacao.EstacionamentoService.IEstacionamentoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EstacionamentoServiceClient : System.ServiceModel.ClientBase<Estacionamento.Apresentacao.EstacionamentoService.IEstacionamentoService>, Estacionamento.Apresentacao.EstacionamentoService.IEstacionamentoService {
        
        public EstacionamentoServiceClient() {
        }
        
        public EstacionamentoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EstacionamentoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EstacionamentoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EstacionamentoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Checkout(string placa) {
            return base.Channel.Checkout(placa);
        }
        
        public System.Threading.Tasks.Task<double> CheckoutAsync(string placa) {
            return base.Channel.CheckoutAsync(placa);
        }
        
        public string Checkin(string placa) {
            return base.Channel.Checkin(placa);
        }
        
        public System.Threading.Tasks.Task<string> CheckinAsync(string placa) {
            return base.Channel.CheckinAsync(placa);
        }
        
        public int VagasRestantes() {
            return base.Channel.VagasRestantes();
        }
        
        public System.Threading.Tasks.Task<int> VagasRestantesAsync() {
            return base.Channel.VagasRestantesAsync();
        }
    }
}
