﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HealthMonitoringSystem.WinApp.DegreeService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Degree", Namespace="http://schemas.datacontract.org/2004/07/HealthMonitoringSystem.Entity", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Degree : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsActiveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsAdminField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ShortNameField;
        
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
        public bool IsActive {
            get {
                return this.IsActiveField;
            }
            set {
                if ((this.IsActiveField.Equals(value) != true)) {
                    this.IsActiveField = value;
                    this.RaisePropertyChanged("IsActive");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsAdmin {
            get {
                return this.IsAdminField;
            }
            set {
                if ((this.IsAdminField.Equals(value) != true)) {
                    this.IsAdminField = value;
                    this.RaisePropertyChanged("IsAdmin");
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
        public string ShortName {
            get {
                return this.ShortNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ShortNameField, value) != true)) {
                    this.ShortNameField = value;
                    this.RaisePropertyChanged("ShortName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ProcessResult", Namespace="http://schemas.datacontract.org/2004/07/HealthMonitoringSystem.Interfaces")]
    [System.SerializableAttribute()]
    public partial class ProcessResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] ErrorsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HealthMonitoringSystem.WinApp.DegreeService.ExtensionsBLLResult ResultField;
        
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
        public string[] Errors {
            get {
                return this.ErrorsField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorsField, value) != true)) {
                    this.ErrorsField = value;
                    this.RaisePropertyChanged("Errors");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HealthMonitoringSystem.WinApp.DegreeService.ExtensionsBLLResult Result {
            get {
                return this.ResultField;
            }
            set {
                if ((this.ResultField.Equals(value) != true)) {
                    this.ResultField = value;
                    this.RaisePropertyChanged("Result");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Extensions.BLLResult", Namespace="http://schemas.datacontract.org/2004/07/HealthMonitoringSystem.Interfaces")]
    public enum ExtensionsBLLResult : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Success = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NotVerified = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        InnerException = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Verified = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        AlreadyFound = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Referanced = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NotFound = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Error = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ServerDisable = 8,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DegreeService.IDegreeSol")]
    public interface IDegreeSol {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDegreeSol/Select", ReplyAction="http://tempuri.org/IDegreeSol/SelectResponse")]
        HealthMonitoringSystem.WinApp.DegreeService.Degree Select(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDegreeSol/Degrees", ReplyAction="http://tempuri.org/IDegreeSol/DegreesResponse")]
        HealthMonitoringSystem.WinApp.DegreeService.Degree[] Degrees(System.Nullable<bool> isActive);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDegreeSol/Insert", ReplyAction="http://tempuri.org/IDegreeSol/InsertResponse")]
        HealthMonitoringSystem.WinApp.DegreeService.ProcessResult Insert(HealthMonitoringSystem.WinApp.DegreeService.Degree newDegree);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDegreeSol/Update", ReplyAction="http://tempuri.org/IDegreeSol/UpdateResponse")]
        HealthMonitoringSystem.WinApp.DegreeService.ProcessResult Update(HealthMonitoringSystem.WinApp.DegreeService.Degree newInfoDegree);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDegreeSol/Delete", ReplyAction="http://tempuri.org/IDegreeSol/DeleteResponse")]
        HealthMonitoringSystem.WinApp.DegreeService.ProcessResult Delete(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDegreeSolChannel : HealthMonitoringSystem.WinApp.DegreeService.IDegreeSol, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DegreeSolClient : System.ServiceModel.ClientBase<HealthMonitoringSystem.WinApp.DegreeService.IDegreeSol>, HealthMonitoringSystem.WinApp.DegreeService.IDegreeSol {
        
        public DegreeSolClient() {
        }
        
        public DegreeSolClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DegreeSolClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DegreeSolClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DegreeSolClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public HealthMonitoringSystem.WinApp.DegreeService.Degree Select(int id) {
            return base.Channel.Select(id);
        }
        
        public HealthMonitoringSystem.WinApp.DegreeService.Degree[] Degrees(System.Nullable<bool> isActive) {
            return base.Channel.Degrees(isActive);
        }
        
        public HealthMonitoringSystem.WinApp.DegreeService.ProcessResult Insert(HealthMonitoringSystem.WinApp.DegreeService.Degree newDegree) {
            return base.Channel.Insert(newDegree);
        }
        
        public HealthMonitoringSystem.WinApp.DegreeService.ProcessResult Update(HealthMonitoringSystem.WinApp.DegreeService.Degree newInfoDegree) {
            return base.Channel.Update(newInfoDegree);
        }
        
        public HealthMonitoringSystem.WinApp.DegreeService.ProcessResult Delete(int id) {
            return base.Channel.Delete(id);
        }
    }
}
