﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client_HafizhPratama_2017096.ServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MathFault", Namespace="http://schemas.datacontract.org/2004/07/ServiceMtk_P2_096")]
    [System.SerializableAttribute()]
    public partial class MathFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PesanField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Kode {
            get {
                return this.KodeField;
            }
            set {
                if ((object.ReferenceEquals(this.KodeField, value) != true)) {
                    this.KodeField = value;
                    this.RaisePropertyChanged("Kode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Pesan {
            get {
                return this.PesanField;
            }
            set {
                if ((object.ReferenceEquals(this.PesanField, value) != true)) {
                    this.PesanField = value;
                    this.RaisePropertyChanged("Pesan");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IMatematika")]
    public interface IMatematika {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/Tambah", ReplyAction="http://tempuri.org/IMatematika/TambahResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Client_HafizhPratama_2017096.ServiceReference2.MathFault), Action="http://tempuri.org/IMatematika/TambahMathFaultFault", Name="MathFault", Namespace="http://schemas.datacontract.org/2004/07/ServiceMtk_P2_096")]
        int Tambah(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/Tambah", ReplyAction="http://tempuri.org/IMatematika/TambahResponse")]
        System.Threading.Tasks.Task<int> TambahAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/Kurang", ReplyAction="http://tempuri.org/IMatematika/KurangResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Client_HafizhPratama_2017096.ServiceReference2.MathFault), Action="http://tempuri.org/IMatematika/KurangMathFaultFault", Name="MathFault", Namespace="http://schemas.datacontract.org/2004/07/ServiceMtk_P2_096")]
        int Kurang(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/Kurang", ReplyAction="http://tempuri.org/IMatematika/KurangResponse")]
        System.Threading.Tasks.Task<int> KurangAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/Kali", ReplyAction="http://tempuri.org/IMatematika/KaliResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Client_HafizhPratama_2017096.ServiceReference2.MathFault), Action="http://tempuri.org/IMatematika/KaliMathFaultFault", Name="MathFault", Namespace="http://schemas.datacontract.org/2004/07/ServiceMtk_P2_096")]
        int Kali(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/Kali", ReplyAction="http://tempuri.org/IMatematika/KaliResponse")]
        System.Threading.Tasks.Task<int> KaliAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/Bagi", ReplyAction="http://tempuri.org/IMatematika/BagiResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Client_HafizhPratama_2017096.ServiceReference2.MathFault), Action="http://tempuri.org/IMatematika/BagiMathFaultFault", Name="MathFault", Namespace="http://schemas.datacontract.org/2004/07/ServiceMtk_P2_096")]
        int Bagi(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/Bagi", ReplyAction="http://tempuri.org/IMatematika/BagiResponse")]
        System.Threading.Tasks.Task<int> BagiAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/TKoordinat", ReplyAction="http://tempuri.org/IMatematika/TKoordinatResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Client_HafizhPratama_2017096.ServiceReference2.MathFault), Action="http://tempuri.org/IMatematika/TKoordinatMathFaultFault", Name="MathFault", Namespace="http://schemas.datacontract.org/2004/07/ServiceMtk_P2_096")]
        ServiceMtk_P2_096.Koordinat TKoordinat(ServiceMtk_P2_096.Koordinat a, ServiceMtk_P2_096.Koordinat b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/TKoordinat", ReplyAction="http://tempuri.org/IMatematika/TKoordinatResponse")]
        System.Threading.Tasks.Task<ServiceMtk_P2_096.Koordinat> TKoordinatAsync(ServiceMtk_P2_096.Koordinat a, ServiceMtk_P2_096.Koordinat b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMatematikaChannel : Client_HafizhPratama_2017096.ServiceReference2.IMatematika, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MatematikaClient : System.ServiceModel.ClientBase<Client_HafizhPratama_2017096.ServiceReference2.IMatematika>, Client_HafizhPratama_2017096.ServiceReference2.IMatematika {
        
        public MatematikaClient() {
        }
        
        public MatematikaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MatematikaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MatematikaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MatematikaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Tambah(int a, int b) {
            return base.Channel.Tambah(a, b);
        }
        
        public System.Threading.Tasks.Task<int> TambahAsync(int a, int b) {
            return base.Channel.TambahAsync(a, b);
        }
        
        public int Kurang(int a, int b) {
            return base.Channel.Kurang(a, b);
        }
        
        public System.Threading.Tasks.Task<int> KurangAsync(int a, int b) {
            return base.Channel.KurangAsync(a, b);
        }
        
        public int Kali(int a, int b) {
            return base.Channel.Kali(a, b);
        }
        
        public System.Threading.Tasks.Task<int> KaliAsync(int a, int b) {
            return base.Channel.KaliAsync(a, b);
        }
        
        public int Bagi(int a, int b) {
            return base.Channel.Bagi(a, b);
        }
        
        public System.Threading.Tasks.Task<int> BagiAsync(int a, int b) {
            return base.Channel.BagiAsync(a, b);
        }
        
        public ServiceMtk_P2_096.Koordinat TKoordinat(ServiceMtk_P2_096.Koordinat a, ServiceMtk_P2_096.Koordinat b) {
            return base.Channel.TKoordinat(a, b);
        }
        
        public System.Threading.Tasks.Task<ServiceMtk_P2_096.Koordinat> TKoordinatAsync(ServiceMtk_P2_096.Koordinat a, ServiceMtk_P2_096.Koordinat b) {
            return base.Channel.TKoordinatAsync(a, b);
        }
    }
}
