﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bonus.BusinessServices.WsBonusAfilicacionCliente {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="AppBonus", ConfigurationName="WsBonusAfilicacionCliente.wsaficlinSoapPort")]
    public interface wsaficlinSoapPort {
        
        [System.ServiceModel.OperationContractAttribute(Action="AppBonusaction/AWSAFICLIN.Execute", ReplyAction="*")]
        Bonus.BusinessServices.WsBonusAfilicacionCliente.ExecuteResponse Execute(Bonus.BusinessServices.WsBonusAfilicacionCliente.ExecuteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="AppBonusaction/AWSAFICLIN.Execute", ReplyAction="*")]
        System.Threading.Tasks.Task<Bonus.BusinessServices.WsBonusAfilicacionCliente.ExecuteResponse> ExecuteAsync(Bonus.BusinessServices.WsBonusAfilicacionCliente.ExecuteRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExecuteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="wsaficlin.Execute", Namespace="AppBonus", Order=0)]
        public Bonus.BusinessServices.WsBonusAfilicacionCliente.ExecuteRequestBody Body;
        
        public ExecuteRequest() {
        }
        
        public ExecuteRequest(Bonus.BusinessServices.WsBonusAfilicacionCliente.ExecuteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="AppBonus")]
    public partial class ExecuteRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public sbyte Tipopc;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Userid;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public long Idcodemp;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Ptccod;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string Pcnjcod;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public sbyte Tipdatcli;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string Prscod_in;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string Ctaprscod_in;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=8)]
        public short Ctacod_in;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string Pctaasocod_in;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=10)]
        public short Tipdoccod;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=11)]
        public string Prsnrodoc;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=12)]
        public string Prsapepat;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=13)]
        public string Prsapemat;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=14)]
        public string Prsprinom;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=15)]
        public string Prssegnom;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=16)]
        public string Prsternom;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=17)]
        public string Prssex;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=18)]
        public sbyte Estcivcod;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=19)]
        public string Oprsfecnac;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=20)]
        public string Nacprs;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=21)]
        public sbyte Dattel;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=22)]
        public int Prspretlf_1;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=23)]
        public int Prspretlf_2;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=24)]
        public int Prspretlf_3;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=25)]
        public sbyte Prsflgmov_1;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=26)]
        public sbyte Prsflgmov_2;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=27)]
        public sbyte Prsflgmov_3;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=28)]
        public long Prsnrotlf_1;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=29)]
        public long Prsnrotlf_2;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=30)]
        public long Prsnrotlf_3;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=31)]
        public string Prsredprv_1;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=32)]
        public string Prsredprv_2;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=33)]
        public string Prsredprv_3;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=34)]
        public sbyte Datcor;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=35)]
        public string Prsmai_1;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=36)]
        public string Prsmai_2;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=37)]
        public string Prsmai_3;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=38)]
        public string Direccion;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=39)]
        public string Referencia;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=40)]
        public string Dptocod;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=41)]
        public string Provcod;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=42)]
        public string Distcod;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=43)]
        public string Dirncooy;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=44)]
        public string Dirncoox;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=45)]
        public string Ocupacion;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=46)]
        public string Centrolabores;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=47)]
        public string Organismopublico;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=48)]
        public string Cargopep;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=49)]
        public string Flgtieveh;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=50)]
        public string Flgtiehij;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=51)]
        public sbyte Prsedadhjo_1;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=52)]
        public sbyte Prsedadhjo_2;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=53)]
        public sbyte Prsedadhjo_3;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=54)]
        public sbyte Prsedadhjo_4;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=55)]
        public sbyte Prsedadhjo_5;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=56)]
        public sbyte Prsedadhjo_6;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=57)]
        public string Prshijsex_1;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=58)]
        public string Prshijsex_2;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=59)]
        public string Prshijsex_3;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=60)]
        public string Prshijsex_4;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=61)]
        public string Prshijsex_5;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=62)]
        public string Prshijsex_6;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=63)]
        public long Tarcod;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=64)]
        public sbyte Modpag;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=65)]
        public long Nrotrns;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=66)]
        public long Codprom;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=67)]
        public string Prsfirma;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=68)]
        public string Prsfirma2;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=69)]
        public string Taralias;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=70)]
        public short Taranno;
        
        public ExecuteRequestBody() {
        }
        
        public ExecuteRequestBody(
                    sbyte Tipopc, 
                    string Userid, 
                    long Idcodemp, 
                    string Ptccod, 
                    string Pcnjcod, 
                    sbyte Tipdatcli, 
                    string Prscod_in, 
                    string Ctaprscod_in, 
                    short Ctacod_in, 
                    string Pctaasocod_in, 
                    short Tipdoccod, 
                    string Prsnrodoc, 
                    string Prsapepat, 
                    string Prsapemat, 
                    string Prsprinom, 
                    string Prssegnom, 
                    string Prsternom, 
                    string Prssex, 
                    sbyte Estcivcod, 
                    string Oprsfecnac, 
                    string Nacprs, 
                    sbyte Dattel, 
                    int Prspretlf_1, 
                    int Prspretlf_2, 
                    int Prspretlf_3, 
                    sbyte Prsflgmov_1, 
                    sbyte Prsflgmov_2, 
                    sbyte Prsflgmov_3, 
                    long Prsnrotlf_1, 
                    long Prsnrotlf_2, 
                    long Prsnrotlf_3, 
                    string Prsredprv_1, 
                    string Prsredprv_2, 
                    string Prsredprv_3, 
                    sbyte Datcor, 
                    string Prsmai_1, 
                    string Prsmai_2, 
                    string Prsmai_3, 
                    string Direccion, 
                    string Referencia, 
                    string Dptocod, 
                    string Provcod, 
                    string Distcod, 
                    string Dirncooy, 
                    string Dirncoox, 
                    string Ocupacion, 
                    string Centrolabores, 
                    string Organismopublico, 
                    string Cargopep, 
                    string Flgtieveh, 
                    string Flgtiehij, 
                    sbyte Prsedadhjo_1, 
                    sbyte Prsedadhjo_2, 
                    sbyte Prsedadhjo_3, 
                    sbyte Prsedadhjo_4, 
                    sbyte Prsedadhjo_5, 
                    sbyte Prsedadhjo_6, 
                    string Prshijsex_1, 
                    string Prshijsex_2, 
                    string Prshijsex_3, 
                    string Prshijsex_4, 
                    string Prshijsex_5, 
                    string Prshijsex_6, 
                    long Tarcod, 
                    sbyte Modpag, 
                    long Nrotrns, 
                    long Codprom, 
                    string Prsfirma, 
                    string Prsfirma2, 
                    string Taralias, 
                    short Taranno) {
            this.Tipopc = Tipopc;
            this.Userid = Userid;
            this.Idcodemp = Idcodemp;
            this.Ptccod = Ptccod;
            this.Pcnjcod = Pcnjcod;
            this.Tipdatcli = Tipdatcli;
            this.Prscod_in = Prscod_in;
            this.Ctaprscod_in = Ctaprscod_in;
            this.Ctacod_in = Ctacod_in;
            this.Pctaasocod_in = Pctaasocod_in;
            this.Tipdoccod = Tipdoccod;
            this.Prsnrodoc = Prsnrodoc;
            this.Prsapepat = Prsapepat;
            this.Prsapemat = Prsapemat;
            this.Prsprinom = Prsprinom;
            this.Prssegnom = Prssegnom;
            this.Prsternom = Prsternom;
            this.Prssex = Prssex;
            this.Estcivcod = Estcivcod;
            this.Oprsfecnac = Oprsfecnac;
            this.Nacprs = Nacprs;
            this.Dattel = Dattel;
            this.Prspretlf_1 = Prspretlf_1;
            this.Prspretlf_2 = Prspretlf_2;
            this.Prspretlf_3 = Prspretlf_3;
            this.Prsflgmov_1 = Prsflgmov_1;
            this.Prsflgmov_2 = Prsflgmov_2;
            this.Prsflgmov_3 = Prsflgmov_3;
            this.Prsnrotlf_1 = Prsnrotlf_1;
            this.Prsnrotlf_2 = Prsnrotlf_2;
            this.Prsnrotlf_3 = Prsnrotlf_3;
            this.Prsredprv_1 = Prsredprv_1;
            this.Prsredprv_2 = Prsredprv_2;
            this.Prsredprv_3 = Prsredprv_3;
            this.Datcor = Datcor;
            this.Prsmai_1 = Prsmai_1;
            this.Prsmai_2 = Prsmai_2;
            this.Prsmai_3 = Prsmai_3;
            this.Direccion = Direccion;
            this.Referencia = Referencia;
            this.Dptocod = Dptocod;
            this.Provcod = Provcod;
            this.Distcod = Distcod;
            this.Dirncooy = Dirncooy;
            this.Dirncoox = Dirncoox;
            this.Ocupacion = Ocupacion;
            this.Centrolabores = Centrolabores;
            this.Organismopublico = Organismopublico;
            this.Cargopep = Cargopep;
            this.Flgtieveh = Flgtieveh;
            this.Flgtiehij = Flgtiehij;
            this.Prsedadhjo_1 = Prsedadhjo_1;
            this.Prsedadhjo_2 = Prsedadhjo_2;
            this.Prsedadhjo_3 = Prsedadhjo_3;
            this.Prsedadhjo_4 = Prsedadhjo_4;
            this.Prsedadhjo_5 = Prsedadhjo_5;
            this.Prsedadhjo_6 = Prsedadhjo_6;
            this.Prshijsex_1 = Prshijsex_1;
            this.Prshijsex_2 = Prshijsex_2;
            this.Prshijsex_3 = Prshijsex_3;
            this.Prshijsex_4 = Prshijsex_4;
            this.Prshijsex_5 = Prshijsex_5;
            this.Prshijsex_6 = Prshijsex_6;
            this.Tarcod = Tarcod;
            this.Modpag = Modpag;
            this.Nrotrns = Nrotrns;
            this.Codprom = Codprom;
            this.Prsfirma = Prsfirma;
            this.Prsfirma2 = Prsfirma2;
            this.Taralias = Taralias;
            this.Taranno = Taranno;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExecuteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="wsaficlin.ExecuteResponse", Namespace="AppBonus", Order=0)]
        public Bonus.BusinessServices.WsBonusAfilicacionCliente.ExecuteResponseBody Body;
        
        public ExecuteResponse() {
        }
        
        public ExecuteResponse(Bonus.BusinessServices.WsBonusAfilicacionCliente.ExecuteResponseBody Body) {
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
        
        public ExecuteResponseBody() {
        }
        
        public ExecuteResponseBody(short Coderror, string Msjerror) {
            this.Coderror = Coderror;
            this.Msjerror = Msjerror;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsaficlinSoapPortChannel : Bonus.BusinessServices.WsBonusAfilicacionCliente.wsaficlinSoapPort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsaficlinSoapPortClient : System.ServiceModel.ClientBase<Bonus.BusinessServices.WsBonusAfilicacionCliente.wsaficlinSoapPort>, Bonus.BusinessServices.WsBonusAfilicacionCliente.wsaficlinSoapPort {
        
        public wsaficlinSoapPortClient() {
        }
        
        public wsaficlinSoapPortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsaficlinSoapPortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsaficlinSoapPortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsaficlinSoapPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Bonus.BusinessServices.WsBonusAfilicacionCliente.ExecuteResponse Bonus.BusinessServices.WsBonusAfilicacionCliente.wsaficlinSoapPort.Execute(Bonus.BusinessServices.WsBonusAfilicacionCliente.ExecuteRequest request) {
            return base.Channel.Execute(request);
        }
        
        public short Execute(
                    sbyte Tipopc, 
                    string Userid, 
                    long Idcodemp, 
                    string Ptccod, 
                    string Pcnjcod, 
                    sbyte Tipdatcli, 
                    string Prscod_in, 
                    string Ctaprscod_in, 
                    short Ctacod_in, 
                    string Pctaasocod_in, 
                    short Tipdoccod, 
                    string Prsnrodoc, 
                    string Prsapepat, 
                    string Prsapemat, 
                    string Prsprinom, 
                    string Prssegnom, 
                    string Prsternom, 
                    string Prssex, 
                    sbyte Estcivcod, 
                    string Oprsfecnac, 
                    string Nacprs, 
                    sbyte Dattel, 
                    int Prspretlf_1, 
                    int Prspretlf_2, 
                    int Prspretlf_3, 
                    sbyte Prsflgmov_1, 
                    sbyte Prsflgmov_2, 
                    sbyte Prsflgmov_3, 
                    long Prsnrotlf_1, 
                    long Prsnrotlf_2, 
                    long Prsnrotlf_3, 
                    string Prsredprv_1, 
                    string Prsredprv_2, 
                    string Prsredprv_3, 
                    sbyte Datcor, 
                    string Prsmai_1, 
                    string Prsmai_2, 
                    string Prsmai_3, 
                    string Direccion, 
                    string Referencia, 
                    string Dptocod, 
                    string Provcod, 
                    string Distcod, 
                    string Dirncooy, 
                    string Dirncoox, 
                    string Ocupacion, 
                    string Centrolabores, 
                    string Organismopublico, 
                    string Cargopep, 
                    string Flgtieveh, 
                    string Flgtiehij, 
                    sbyte Prsedadhjo_1, 
                    sbyte Prsedadhjo_2, 
                    sbyte Prsedadhjo_3, 
                    sbyte Prsedadhjo_4, 
                    sbyte Prsedadhjo_5, 
                    sbyte Prsedadhjo_6, 
                    string Prshijsex_1, 
                    string Prshijsex_2, 
                    string Prshijsex_3, 
                    string Prshijsex_4, 
                    string Prshijsex_5, 
                    string Prshijsex_6, 
                    long Tarcod, 
                    sbyte Modpag, 
                    long Nrotrns, 
                    long Codprom, 
                    string Prsfirma, 
                    string Prsfirma2, 
                    string Taralias, 
                    short Taranno, 
                    out string Msjerror) {
            Bonus.BusinessServices.WsBonusAfilicacionCliente.ExecuteRequest inValue = new Bonus.BusinessServices.WsBonusAfilicacionCliente.ExecuteRequest();
            inValue.Body = new Bonus.BusinessServices.WsBonusAfilicacionCliente.ExecuteRequestBody();
            inValue.Body.Tipopc = Tipopc;
            inValue.Body.Userid = Userid;
            inValue.Body.Idcodemp = Idcodemp;
            inValue.Body.Ptccod = Ptccod;
            inValue.Body.Pcnjcod = Pcnjcod;
            inValue.Body.Tipdatcli = Tipdatcli;
            inValue.Body.Prscod_in = Prscod_in;
            inValue.Body.Ctaprscod_in = Ctaprscod_in;
            inValue.Body.Ctacod_in = Ctacod_in;
            inValue.Body.Pctaasocod_in = Pctaasocod_in;
            inValue.Body.Tipdoccod = Tipdoccod;
            inValue.Body.Prsnrodoc = Prsnrodoc;
            inValue.Body.Prsapepat = Prsapepat;
            inValue.Body.Prsapemat = Prsapemat;
            inValue.Body.Prsprinom = Prsprinom;
            inValue.Body.Prssegnom = Prssegnom;
            inValue.Body.Prsternom = Prsternom;
            inValue.Body.Prssex = Prssex;
            inValue.Body.Estcivcod = Estcivcod;
            inValue.Body.Oprsfecnac = Oprsfecnac;
            inValue.Body.Nacprs = Nacprs;
            inValue.Body.Dattel = Dattel;
            inValue.Body.Prspretlf_1 = Prspretlf_1;
            inValue.Body.Prspretlf_2 = Prspretlf_2;
            inValue.Body.Prspretlf_3 = Prspretlf_3;
            inValue.Body.Prsflgmov_1 = Prsflgmov_1;
            inValue.Body.Prsflgmov_2 = Prsflgmov_2;
            inValue.Body.Prsflgmov_3 = Prsflgmov_3;
            inValue.Body.Prsnrotlf_1 = Prsnrotlf_1;
            inValue.Body.Prsnrotlf_2 = Prsnrotlf_2;
            inValue.Body.Prsnrotlf_3 = Prsnrotlf_3;
            inValue.Body.Prsredprv_1 = Prsredprv_1;
            inValue.Body.Prsredprv_2 = Prsredprv_2;
            inValue.Body.Prsredprv_3 = Prsredprv_3;
            inValue.Body.Datcor = Datcor;
            inValue.Body.Prsmai_1 = Prsmai_1;
            inValue.Body.Prsmai_2 = Prsmai_2;
            inValue.Body.Prsmai_3 = Prsmai_3;
            inValue.Body.Direccion = Direccion;
            inValue.Body.Referencia = Referencia;
            inValue.Body.Dptocod = Dptocod;
            inValue.Body.Provcod = Provcod;
            inValue.Body.Distcod = Distcod;
            inValue.Body.Dirncooy = Dirncooy;
            inValue.Body.Dirncoox = Dirncoox;
            inValue.Body.Ocupacion = Ocupacion;
            inValue.Body.Centrolabores = Centrolabores;
            inValue.Body.Organismopublico = Organismopublico;
            inValue.Body.Cargopep = Cargopep;
            inValue.Body.Flgtieveh = Flgtieveh;
            inValue.Body.Flgtiehij = Flgtiehij;
            inValue.Body.Prsedadhjo_1 = Prsedadhjo_1;
            inValue.Body.Prsedadhjo_2 = Prsedadhjo_2;
            inValue.Body.Prsedadhjo_3 = Prsedadhjo_3;
            inValue.Body.Prsedadhjo_4 = Prsedadhjo_4;
            inValue.Body.Prsedadhjo_5 = Prsedadhjo_5;
            inValue.Body.Prsedadhjo_6 = Prsedadhjo_6;
            inValue.Body.Prshijsex_1 = Prshijsex_1;
            inValue.Body.Prshijsex_2 = Prshijsex_2;
            inValue.Body.Prshijsex_3 = Prshijsex_3;
            inValue.Body.Prshijsex_4 = Prshijsex_4;
            inValue.Body.Prshijsex_5 = Prshijsex_5;
            inValue.Body.Prshijsex_6 = Prshijsex_6;
            inValue.Body.Tarcod = Tarcod;
            inValue.Body.Modpag = Modpag;
            inValue.Body.Nrotrns = Nrotrns;
            inValue.Body.Codprom = Codprom;
            inValue.Body.Prsfirma = Prsfirma;
            inValue.Body.Prsfirma2 = Prsfirma2;
            inValue.Body.Taralias = Taralias;
            inValue.Body.Taranno = Taranno;
            Bonus.BusinessServices.WsBonusAfilicacionCliente.ExecuteResponse retVal = ((Bonus.BusinessServices.WsBonusAfilicacionCliente.wsaficlinSoapPort)(this)).Execute(inValue);
            Msjerror = retVal.Body.Msjerror;
            return retVal.Body.Coderror;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Bonus.BusinessServices.WsBonusAfilicacionCliente.ExecuteResponse> Bonus.BusinessServices.WsBonusAfilicacionCliente.wsaficlinSoapPort.ExecuteAsync(Bonus.BusinessServices.WsBonusAfilicacionCliente.ExecuteRequest request) {
            return base.Channel.ExecuteAsync(request);
        }
        
        public System.Threading.Tasks.Task<Bonus.BusinessServices.WsBonusAfilicacionCliente.ExecuteResponse> ExecuteAsync(
                    sbyte Tipopc, 
                    string Userid, 
                    long Idcodemp, 
                    string Ptccod, 
                    string Pcnjcod, 
                    sbyte Tipdatcli, 
                    string Prscod_in, 
                    string Ctaprscod_in, 
                    short Ctacod_in, 
                    string Pctaasocod_in, 
                    short Tipdoccod, 
                    string Prsnrodoc, 
                    string Prsapepat, 
                    string Prsapemat, 
                    string Prsprinom, 
                    string Prssegnom, 
                    string Prsternom, 
                    string Prssex, 
                    sbyte Estcivcod, 
                    string Oprsfecnac, 
                    string Nacprs, 
                    sbyte Dattel, 
                    int Prspretlf_1, 
                    int Prspretlf_2, 
                    int Prspretlf_3, 
                    sbyte Prsflgmov_1, 
                    sbyte Prsflgmov_2, 
                    sbyte Prsflgmov_3, 
                    long Prsnrotlf_1, 
                    long Prsnrotlf_2, 
                    long Prsnrotlf_3, 
                    string Prsredprv_1, 
                    string Prsredprv_2, 
                    string Prsredprv_3, 
                    sbyte Datcor, 
                    string Prsmai_1, 
                    string Prsmai_2, 
                    string Prsmai_3, 
                    string Direccion, 
                    string Referencia, 
                    string Dptocod, 
                    string Provcod, 
                    string Distcod, 
                    string Dirncooy, 
                    string Dirncoox, 
                    string Ocupacion, 
                    string Centrolabores, 
                    string Organismopublico, 
                    string Cargopep, 
                    string Flgtieveh, 
                    string Flgtiehij, 
                    sbyte Prsedadhjo_1, 
                    sbyte Prsedadhjo_2, 
                    sbyte Prsedadhjo_3, 
                    sbyte Prsedadhjo_4, 
                    sbyte Prsedadhjo_5, 
                    sbyte Prsedadhjo_6, 
                    string Prshijsex_1, 
                    string Prshijsex_2, 
                    string Prshijsex_3, 
                    string Prshijsex_4, 
                    string Prshijsex_5, 
                    string Prshijsex_6, 
                    long Tarcod, 
                    sbyte Modpag, 
                    long Nrotrns, 
                    long Codprom, 
                    string Prsfirma, 
                    string Prsfirma2, 
                    string Taralias, 
                    short Taranno) {
            Bonus.BusinessServices.WsBonusAfilicacionCliente.ExecuteRequest inValue = new Bonus.BusinessServices.WsBonusAfilicacionCliente.ExecuteRequest();
            inValue.Body = new Bonus.BusinessServices.WsBonusAfilicacionCliente.ExecuteRequestBody();
            inValue.Body.Tipopc = Tipopc;
            inValue.Body.Userid = Userid;
            inValue.Body.Idcodemp = Idcodemp;
            inValue.Body.Ptccod = Ptccod;
            inValue.Body.Pcnjcod = Pcnjcod;
            inValue.Body.Tipdatcli = Tipdatcli;
            inValue.Body.Prscod_in = Prscod_in;
            inValue.Body.Ctaprscod_in = Ctaprscod_in;
            inValue.Body.Ctacod_in = Ctacod_in;
            inValue.Body.Pctaasocod_in = Pctaasocod_in;
            inValue.Body.Tipdoccod = Tipdoccod;
            inValue.Body.Prsnrodoc = Prsnrodoc;
            inValue.Body.Prsapepat = Prsapepat;
            inValue.Body.Prsapemat = Prsapemat;
            inValue.Body.Prsprinom = Prsprinom;
            inValue.Body.Prssegnom = Prssegnom;
            inValue.Body.Prsternom = Prsternom;
            inValue.Body.Prssex = Prssex;
            inValue.Body.Estcivcod = Estcivcod;
            inValue.Body.Oprsfecnac = Oprsfecnac;
            inValue.Body.Nacprs = Nacprs;
            inValue.Body.Dattel = Dattel;
            inValue.Body.Prspretlf_1 = Prspretlf_1;
            inValue.Body.Prspretlf_2 = Prspretlf_2;
            inValue.Body.Prspretlf_3 = Prspretlf_3;
            inValue.Body.Prsflgmov_1 = Prsflgmov_1;
            inValue.Body.Prsflgmov_2 = Prsflgmov_2;
            inValue.Body.Prsflgmov_3 = Prsflgmov_3;
            inValue.Body.Prsnrotlf_1 = Prsnrotlf_1;
            inValue.Body.Prsnrotlf_2 = Prsnrotlf_2;
            inValue.Body.Prsnrotlf_3 = Prsnrotlf_3;
            inValue.Body.Prsredprv_1 = Prsredprv_1;
            inValue.Body.Prsredprv_2 = Prsredprv_2;
            inValue.Body.Prsredprv_3 = Prsredprv_3;
            inValue.Body.Datcor = Datcor;
            inValue.Body.Prsmai_1 = Prsmai_1;
            inValue.Body.Prsmai_2 = Prsmai_2;
            inValue.Body.Prsmai_3 = Prsmai_3;
            inValue.Body.Direccion = Direccion;
            inValue.Body.Referencia = Referencia;
            inValue.Body.Dptocod = Dptocod;
            inValue.Body.Provcod = Provcod;
            inValue.Body.Distcod = Distcod;
            inValue.Body.Dirncooy = Dirncooy;
            inValue.Body.Dirncoox = Dirncoox;
            inValue.Body.Ocupacion = Ocupacion;
            inValue.Body.Centrolabores = Centrolabores;
            inValue.Body.Organismopublico = Organismopublico;
            inValue.Body.Cargopep = Cargopep;
            inValue.Body.Flgtieveh = Flgtieveh;
            inValue.Body.Flgtiehij = Flgtiehij;
            inValue.Body.Prsedadhjo_1 = Prsedadhjo_1;
            inValue.Body.Prsedadhjo_2 = Prsedadhjo_2;
            inValue.Body.Prsedadhjo_3 = Prsedadhjo_3;
            inValue.Body.Prsedadhjo_4 = Prsedadhjo_4;
            inValue.Body.Prsedadhjo_5 = Prsedadhjo_5;
            inValue.Body.Prsedadhjo_6 = Prsedadhjo_6;
            inValue.Body.Prshijsex_1 = Prshijsex_1;
            inValue.Body.Prshijsex_2 = Prshijsex_2;
            inValue.Body.Prshijsex_3 = Prshijsex_3;
            inValue.Body.Prshijsex_4 = Prshijsex_4;
            inValue.Body.Prshijsex_5 = Prshijsex_5;
            inValue.Body.Prshijsex_6 = Prshijsex_6;
            inValue.Body.Tarcod = Tarcod;
            inValue.Body.Modpag = Modpag;
            inValue.Body.Nrotrns = Nrotrns;
            inValue.Body.Codprom = Codprom;
            inValue.Body.Prsfirma = Prsfirma;
            inValue.Body.Prsfirma2 = Prsfirma2;
            inValue.Body.Taralias = Taralias;
            inValue.Body.Taranno = Taranno;
            return ((Bonus.BusinessServices.WsBonusAfilicacionCliente.wsaficlinSoapPort)(this)).ExecuteAsync(inValue);
        }
    }
}
