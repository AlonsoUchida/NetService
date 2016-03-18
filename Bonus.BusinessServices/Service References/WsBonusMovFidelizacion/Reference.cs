﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bonus.BusinessServices.WsBonusMovFidelizacion {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="AppBonus", ConfigurationName="WsBonusMovFidelizacion.wsultmovptSoapPort")]
    public interface wsultmovptSoapPort {
        
        [System.ServiceModel.OperationContractAttribute(Action="AppBonusaction/AWSULTMOVPT.Execute", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Bonus.BusinessServices.WsBonusMovFidelizacion.ExecuteResponse Execute(Bonus.BusinessServices.WsBonusMovFidelizacion.ExecuteRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="AppBonusaction/AWSULTMOVPT.Execute", ReplyAction="*")]
        System.Threading.Tasks.Task<Bonus.BusinessServices.WsBonusMovFidelizacion.ExecuteResponse> ExecuteAsync(Bonus.BusinessServices.WsBonusMovFidelizacion.ExecuteRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="UltMovPto.UltMovPtoItem", Namespace="AppBonus")]
    public partial class UltMovPtoUltMovPtoItem : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string fchHorField;
        
        private string horProcField;
        
        private string fchProcField;
        
        private string fchAsigField;
        
        private string descripField;
        
        private double ptosAsigField;
        
        private double ptosCanjField;
        
        private string esCanjeField;
        
        /// <remarks/>
        public string FchHor {
            get {
                return this.fchHorField;
            }
            set {
                this.fchHorField = value;
                this.RaisePropertyChanged("FchHor");
            }
        }
        
        /// <remarks/>
        public string HorProc {
            get {
                return this.horProcField;
            }
            set {
                this.horProcField = value;
                this.RaisePropertyChanged("HorProc");
            }
        }
        
        /// <remarks/>
        public string FchProc {
            get {
                return this.fchProcField;
            }
            set {
                this.fchProcField = value;
                this.RaisePropertyChanged("FchProc");
            }
        }
        
        /// <remarks/>
        public string FchAsig {
            get {
                return this.fchAsigField;
            }
            set {
                this.fchAsigField = value;
                this.RaisePropertyChanged("FchAsig");
            }
        }
        
        /// <remarks/>
        public string Descrip {
            get {
                return this.descripField;
            }
            set {
                this.descripField = value;
                this.RaisePropertyChanged("Descrip");
            }
        }
        
        /// <remarks/>
        public double PtosAsig {
            get {
                return this.ptosAsigField;
            }
            set {
                this.ptosAsigField = value;
                this.RaisePropertyChanged("PtosAsig");
            }
        }
        
        /// <remarks/>
        public double PtosCanj {
            get {
                return this.ptosCanjField;
            }
            set {
                this.ptosCanjField = value;
                this.RaisePropertyChanged("PtosCanj");
            }
        }
        
        /// <remarks/>
        public string EsCanje {
            get {
                return this.esCanjeField;
            }
            set {
                this.esCanjeField = value;
                this.RaisePropertyChanged("EsCanje");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="wsultmovpt.Execute", WrapperNamespace="AppBonus", IsWrapped=true)]
    public partial class ExecuteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="AppBonus", Order=0)]
        public string Ctaprscod;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="AppBonus", Order=1)]
        public short Ctacod;
        
        public ExecuteRequest() {
        }
        
        public ExecuteRequest(string Ctaprscod, short Ctacod) {
            this.Ctaprscod = Ctaprscod;
            this.Ctacod = Ctacod;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="wsultmovpt.ExecuteResponse", WrapperNamespace="AppBonus", IsWrapped=true)]
    public partial class ExecuteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="AppBonus", Order=0)]
        public short Coderror;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="AppBonus", Order=1)]
        public string Msjerror;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="AppBonus", Order=2)]
        public int Nrotrn;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="AppBonus", Order=3)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public Bonus.BusinessServices.WsBonusMovFidelizacion.UltMovPtoUltMovPtoItem[] Transaccion;
        
        public ExecuteResponse() {
        }
        
        public ExecuteResponse(short Coderror, string Msjerror, int Nrotrn, Bonus.BusinessServices.WsBonusMovFidelizacion.UltMovPtoUltMovPtoItem[] Transaccion) {
            this.Coderror = Coderror;
            this.Msjerror = Msjerror;
            this.Nrotrn = Nrotrn;
            this.Transaccion = Transaccion;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsultmovptSoapPortChannel : Bonus.BusinessServices.WsBonusMovFidelizacion.wsultmovptSoapPort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsultmovptSoapPortClient : System.ServiceModel.ClientBase<Bonus.BusinessServices.WsBonusMovFidelizacion.wsultmovptSoapPort>, Bonus.BusinessServices.WsBonusMovFidelizacion.wsultmovptSoapPort {
        
        public wsultmovptSoapPortClient() {
        }
        
        public wsultmovptSoapPortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsultmovptSoapPortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsultmovptSoapPortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsultmovptSoapPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Bonus.BusinessServices.WsBonusMovFidelizacion.ExecuteResponse Bonus.BusinessServices.WsBonusMovFidelizacion.wsultmovptSoapPort.Execute(Bonus.BusinessServices.WsBonusMovFidelizacion.ExecuteRequest request) {
            return base.Channel.Execute(request);
        }
        
        public short Execute(string Ctaprscod, short Ctacod, out string Msjerror, out int Nrotrn, out Bonus.BusinessServices.WsBonusMovFidelizacion.UltMovPtoUltMovPtoItem[] Transaccion) {
            Bonus.BusinessServices.WsBonusMovFidelizacion.ExecuteRequest inValue = new Bonus.BusinessServices.WsBonusMovFidelizacion.ExecuteRequest();
            inValue.Ctaprscod = Ctaprscod;
            inValue.Ctacod = Ctacod;
            Bonus.BusinessServices.WsBonusMovFidelizacion.ExecuteResponse retVal = ((Bonus.BusinessServices.WsBonusMovFidelizacion.wsultmovptSoapPort)(this)).Execute(inValue);
            Msjerror = retVal.Msjerror;
            Nrotrn = retVal.Nrotrn;
            Transaccion = retVal.Transaccion;
            return retVal.Coderror;
        }
        
        public System.Threading.Tasks.Task<Bonus.BusinessServices.WsBonusMovFidelizacion.ExecuteResponse> ExecuteAsync(Bonus.BusinessServices.WsBonusMovFidelizacion.ExecuteRequest request) {
            return base.Channel.ExecuteAsync(request);
        }
    }
}