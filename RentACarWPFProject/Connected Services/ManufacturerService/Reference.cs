﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentACarWPFProject.ManufacturerService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Manufacturer", Namespace="http://schemas.datacontract.org/2004/07/Common.Models")]
    [System.SerializableAttribute()]
    public partial class Manufacturer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] LogoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<RentACarWPFProject.ManufacturerService.CarModel> ModelsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Logo {
            get {
                return this.LogoField;
            }
            set {
                if ((object.ReferenceEquals(this.LogoField, value) != true)) {
                    this.LogoField = value;
                    this.RaisePropertyChanged("Logo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<RentACarWPFProject.ManufacturerService.CarModel> Models {
            get {
                return this.ModelsField;
            }
            set {
                if ((object.ReferenceEquals(this.ModelsField, value) != true)) {
                    this.ModelsField = value;
                    this.RaisePropertyChanged("Models");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CarModel", Namespace="http://schemas.datacontract.org/2004/07/Common.Models")]
    [System.SerializableAttribute()]
    public partial class CarModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ManufacturerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int YearField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ManufacturerId {
            get {
                return this.ManufacturerIdField;
            }
            set {
                if ((this.ManufacturerIdField.Equals(value) != true)) {
                    this.ManufacturerIdField = value;
                    this.RaisePropertyChanged("ManufacturerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Year {
            get {
                return this.YearField;
            }
            set {
                if ((this.YearField.Equals(value) != true)) {
                    this.YearField = value;
                    this.RaisePropertyChanged("Year");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ManufacturerService.IManufacturerService")]
    public interface IManufacturerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManufacturerService/GetManufacturers", ReplyAction="http://tempuri.org/IManufacturerService/GetManufacturersResponse")]
        RentACarWPFProject.ManufacturerService.GetManufacturersResponse GetManufacturers(RentACarWPFProject.ManufacturerService.GetManufacturersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManufacturerService/GetManufacturers", ReplyAction="http://tempuri.org/IManufacturerService/GetManufacturersResponse")]
        System.Threading.Tasks.Task<RentACarWPFProject.ManufacturerService.GetManufacturersResponse> GetManufacturersAsync(RentACarWPFProject.ManufacturerService.GetManufacturersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManufacturerService/AddNewManufacturer", ReplyAction="http://tempuri.org/IManufacturerService/AddNewManufacturerResponse")]
        RentACarWPFProject.ManufacturerService.AddNewManufacturerResponse AddNewManufacturer(RentACarWPFProject.ManufacturerService.AddNewManufacturerRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManufacturerService/AddNewManufacturer", ReplyAction="http://tempuri.org/IManufacturerService/AddNewManufacturerResponse")]
        System.Threading.Tasks.Task<RentACarWPFProject.ManufacturerService.AddNewManufacturerResponse> AddNewManufacturerAsync(RentACarWPFProject.ManufacturerService.AddNewManufacturerRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetManufacturers", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetManufacturersRequest {
        
        public GetManufacturersRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetManufacturersResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetManufacturersResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.Collections.Generic.List<RentACarWPFProject.ManufacturerService.Manufacturer> GetManufacturersResult;
        
        public GetManufacturersResponse() {
        }
        
        public GetManufacturersResponse(System.Collections.Generic.List<RentACarWPFProject.ManufacturerService.Manufacturer> GetManufacturersResult) {
            this.GetManufacturersResult = GetManufacturersResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AddNewManufacturer", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AddNewManufacturerRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public RentACarWPFProject.ManufacturerService.Manufacturer manufacturer;
        
        public AddNewManufacturerRequest() {
        }
        
        public AddNewManufacturerRequest(RentACarWPFProject.ManufacturerService.Manufacturer manufacturer) {
            this.manufacturer = manufacturer;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AddNewManufacturerResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AddNewManufacturerResponse {
        
        public AddNewManufacturerResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IManufacturerServiceChannel : RentACarWPFProject.ManufacturerService.IManufacturerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ManufacturerServiceClient : System.ServiceModel.ClientBase<RentACarWPFProject.ManufacturerService.IManufacturerService>, RentACarWPFProject.ManufacturerService.IManufacturerService {
        
        public ManufacturerServiceClient() {
        }
        
        public ManufacturerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ManufacturerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ManufacturerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ManufacturerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public RentACarWPFProject.ManufacturerService.GetManufacturersResponse GetManufacturers(RentACarWPFProject.ManufacturerService.GetManufacturersRequest request) {
            return base.Channel.GetManufacturers(request);
        }
        
        public System.Threading.Tasks.Task<RentACarWPFProject.ManufacturerService.GetManufacturersResponse> GetManufacturersAsync(RentACarWPFProject.ManufacturerService.GetManufacturersRequest request) {
            return base.Channel.GetManufacturersAsync(request);
        }
        
        public RentACarWPFProject.ManufacturerService.AddNewManufacturerResponse AddNewManufacturer(RentACarWPFProject.ManufacturerService.AddNewManufacturerRequest request) {
            return base.Channel.AddNewManufacturer(request);
        }
        
        public System.Threading.Tasks.Task<RentACarWPFProject.ManufacturerService.AddNewManufacturerResponse> AddNewManufacturerAsync(RentACarWPFProject.ManufacturerService.AddNewManufacturerRequest request) {
            return base.Channel.AddNewManufacturerAsync(request);
        }
    }
}
