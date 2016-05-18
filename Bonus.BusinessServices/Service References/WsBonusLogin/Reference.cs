﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bonus.BusinessServices.WsBonusLogin {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="AppBonus", ConfigurationName="WsBonusLogin.wslogusugxSoapPort")]
    public interface wslogusugxSoapPort {
        
        [System.ServiceModel.OperationContractAttribute(Action="AppBonusaction/AWSLOGUSUGX.Execute", ReplyAction="*")]
        Bonus.BusinessServices.WsBonusLogin.ExecuteResponse Execute(Bonus.BusinessServices.WsBonusLogin.ExecuteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="AppBonusaction/AWSLOGUSUGX.Execute", ReplyAction="*")]
        System.Threading.Tasks.Task<Bonus.BusinessServices.WsBonusLogin.ExecuteResponse> ExecuteAsync(Bonus.BusinessServices.WsBonusLogin.ExecuteRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExecuteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="wslogusugx.Execute", Namespace="AppBonus", Order=0)]
        public Bonus.BusinessServices.WsBonusLogin.ExecuteRequestBody Body;
        
        public ExecuteRequest() {
        }
        
        public ExecuteRequest(Bonus.BusinessServices.WsBonusLogin.ExecuteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="AppBonus")]
    public partial class ExecuteRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Usucod;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Usucla;
        
        public ExecuteRequestBody() {
        }
        
        public ExecuteRequestBody(string Usucod, string Usucla) {
            this.Usucod = Usucod;
            this.Usucla = Usucla;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExecuteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="wslogusugx.ExecuteResponse", Namespace="AppBonus", Order=0)]
        public Bonus.BusinessServices.WsBonusLogin.ExecuteResponseBody Body;
        
        public ExecuteResponse() {
        }
        
        public ExecuteResponse(Bonus.BusinessServices.WsBonusLogin.ExecuteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="AppBonus")]
    public partial class ExecuteResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public short Coderror;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Msjerror;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public long Codpro;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Usunom;
        
        public ExecuteResponseBody() {
        }
        
        public ExecuteResponseBody(short Coderror, string Msjerror, long Codpro, string Usunom) {
            this.Coderror = Coderror;
            this.Msjerror = Msjerror;
            this.Codpro = Codpro;
            this.Usunom = Usunom;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wslogusugxSoapPortChannel : Bonus.BusinessServices.WsBonusLogin.wslogusugxSoapPort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wslogusugxSoapPortClient : System.ServiceModel.ClientBase<Bonus.BusinessServices.WsBonusLogin.wslogusugxSoapPort>, Bonus.BusinessServices.WsBonusLogin.wslogusugxSoapPort {
        
        public wslogusugxSoapPortClient() {
        }
        
        public wslogusugxSoapPortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wslogusugxSoapPortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wslogusugxSoapPortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wslogusugxSoapPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Bonus.BusinessServices.WsBonusLogin.ExecuteResponse Bonus.BusinessServices.WsBonusLogin.wslogusugxSoapPort.Execute(Bonus.BusinessServices.WsBonusLogin.ExecuteRequest request) {
            return base.Channel.Execute(request);
        }
        
        public short Execute(string Usucod, string Usucla, out string Msjerror, out long Codpro, out string Usunom) {
            Bonus.BusinessServices.WsBonusLogin.ExecuteRequest inValue = new Bonus.BusinessServices.WsBonusLogin.ExecuteRequest();
            inValue.Body = new Bonus.BusinessServices.WsBonusLogin.ExecuteRequestBody();
            inValue.Body.Usucod = Usucod;
            inValue.Body.Usucla = Usucla;
            Bonus.BusinessServices.WsBonusLogin.ExecuteResponse retVal = ((Bonus.BusinessServices.WsBonusLogin.wslogusugxSoapPort)(this)).Execute(inValue);
            Msjerror = retVal.Body.Msjerror;
            Codpro = retVal.Body.Codpro;
            Usunom = retVal.Body.Usunom;
            return retVal.Body.Coderror;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Bonus.BusinessServices.WsBonusLogin.ExecuteResponse> Bonus.BusinessServices.WsBonusLogin.wslogusugxSoapPort.ExecuteAsync(Bonus.BusinessServices.WsBonusLogin.ExecuteRequest request) {
            return base.Channel.ExecuteAsync(request);
        }
        
        public System.Threading.Tasks.Task<Bonus.BusinessServices.WsBonusLogin.ExecuteResponse> ExecuteAsync(string Usucod, string Usucla) {
            Bonus.BusinessServices.WsBonusLogin.ExecuteRequest inValue = new Bonus.BusinessServices.WsBonusLogin.ExecuteRequest();
            inValue.Body = new Bonus.BusinessServices.WsBonusLogin.ExecuteRequestBody();
            inValue.Body.Usucod = Usucod;
            inValue.Body.Usucla = Usucla;
            return ((Bonus.BusinessServices.WsBonusLogin.wslogusugxSoapPort)(this)).ExecuteAsync(inValue);
        }
    }
}
