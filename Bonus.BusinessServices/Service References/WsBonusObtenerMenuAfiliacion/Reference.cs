﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bonus.BusinessServices.WsBonusObtenerMenuAfiliacion {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="AppBonus", ConfigurationName="WsBonusObtenerMenuAfiliacion.wsmenafiSoapPort")]
    public interface wsmenafiSoapPort {
        
        [System.ServiceModel.OperationContractAttribute(Action="AppBonusaction/AWSMENAFI.Execute", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Bonus.BusinessServices.WsBonusObtenerMenuAfiliacion.ExecuteResponse Execute(Bonus.BusinessServices.WsBonusObtenerMenuAfiliacion.ExecuteRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="AppBonusaction/AWSMENAFI.Execute", ReplyAction="*")]
        System.Threading.Tasks.Task<Bonus.BusinessServices.WsBonusObtenerMenuAfiliacion.ExecuteResponse> ExecuteAsync(Bonus.BusinessServices.WsBonusObtenerMenuAfiliacion.ExecuteRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="Lismenafi.LismenafiItem", Namespace="AppBonus")]
    public partial class LismenafiLismenafiItem : object, System.ComponentModel.INotifyPropertyChanged {
        
        private short mensecField;
        
        private string mendesField;
        
        /// <remarks/>
        public short mensec {
            get {
                return this.mensecField;
            }
            set {
                this.mensecField = value;
                this.RaisePropertyChanged("mensec");
            }
        }
        
        /// <remarks/>
        public string mendes {
            get {
                return this.mendesField;
            }
            set {
                this.mendesField = value;
                this.RaisePropertyChanged("mendes");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="wsmenafi.Execute", WrapperNamespace="AppBonus", IsWrapped=true)]
    public partial class ExecuteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="AppBonus", Order=0)]
        public short Cantidadcta;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="AppBonus", Order=1)]
        public string Ctaprscod;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="AppBonus", Order=2)]
        public short Ctacod;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="AppBonus", Order=3)]
        public string Pctaasocod;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="AppBonus", Order=4)]
        public string Pctatip;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="AppBonus", Order=5)]
        public string Pctaautcnj;
        
        public ExecuteRequest() {
        }
        
        public ExecuteRequest(short Cantidadcta, string Ctaprscod, short Ctacod, string Pctaasocod, string Pctatip, string Pctaautcnj) {
            this.Cantidadcta = Cantidadcta;
            this.Ctaprscod = Ctaprscod;
            this.Ctacod = Ctacod;
            this.Pctaasocod = Pctaasocod;
            this.Pctatip = Pctatip;
            this.Pctaautcnj = Pctaautcnj;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="wsmenafi.ExecuteResponse", WrapperNamespace="AppBonus", IsWrapped=true)]
    public partial class ExecuteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="AppBonus", Order=0)]
        public short Coderror;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="AppBonus", Order=1)]
        public string Msjerror;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="AppBonus", Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public Bonus.BusinessServices.WsBonusObtenerMenuAfiliacion.LismenafiLismenafiItem[] Carritomen;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="AppBonus", Order=3)]
        public sbyte Existeprs;
        
        public ExecuteResponse() {
        }
        
        public ExecuteResponse(short Coderror, string Msjerror, Bonus.BusinessServices.WsBonusObtenerMenuAfiliacion.LismenafiLismenafiItem[] Carritomen, sbyte Existeprs) {
            this.Coderror = Coderror;
            this.Msjerror = Msjerror;
            this.Carritomen = Carritomen;
            this.Existeprs = Existeprs;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsmenafiSoapPortChannel : Bonus.BusinessServices.WsBonusObtenerMenuAfiliacion.wsmenafiSoapPort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsmenafiSoapPortClient : System.ServiceModel.ClientBase<Bonus.BusinessServices.WsBonusObtenerMenuAfiliacion.wsmenafiSoapPort>, Bonus.BusinessServices.WsBonusObtenerMenuAfiliacion.wsmenafiSoapPort {
        
        public wsmenafiSoapPortClient() {
        }
        
        public wsmenafiSoapPortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsmenafiSoapPortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsmenafiSoapPortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsmenafiSoapPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Bonus.BusinessServices.WsBonusObtenerMenuAfiliacion.ExecuteResponse Bonus.BusinessServices.WsBonusObtenerMenuAfiliacion.wsmenafiSoapPort.Execute(Bonus.BusinessServices.WsBonusObtenerMenuAfiliacion.ExecuteRequest request) {
            return base.Channel.Execute(request);
        }
        
        public short Execute(short Cantidadcta, string Ctaprscod, short Ctacod, string Pctaasocod, string Pctatip, string Pctaautcnj, out string Msjerror, out Bonus.BusinessServices.WsBonusObtenerMenuAfiliacion.LismenafiLismenafiItem[] Carritomen, out sbyte Existeprs) {
            Bonus.BusinessServices.WsBonusObtenerMenuAfiliacion.ExecuteRequest inValue = new Bonus.BusinessServices.WsBonusObtenerMenuAfiliacion.ExecuteRequest();
            inValue.Cantidadcta = Cantidadcta;
            inValue.Ctaprscod = Ctaprscod;
            inValue.Ctacod = Ctacod;
            inValue.Pctaasocod = Pctaasocod;
            inValue.Pctatip = Pctatip;
            inValue.Pctaautcnj = Pctaautcnj;
            Bonus.BusinessServices.WsBonusObtenerMenuAfiliacion.ExecuteResponse retVal = ((Bonus.BusinessServices.WsBonusObtenerMenuAfiliacion.wsmenafiSoapPort)(this)).Execute(inValue);
            Msjerror = retVal.Msjerror;
            Carritomen = retVal.Carritomen;
            Existeprs = retVal.Existeprs;
            return retVal.Coderror;
        }
        
        public System.Threading.Tasks.Task<Bonus.BusinessServices.WsBonusObtenerMenuAfiliacion.ExecuteResponse> ExecuteAsync(Bonus.BusinessServices.WsBonusObtenerMenuAfiliacion.ExecuteRequest request) {
            return base.Channel.ExecuteAsync(request);
        }
    }
}
