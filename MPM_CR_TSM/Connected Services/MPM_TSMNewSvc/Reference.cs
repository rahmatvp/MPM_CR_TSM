﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MPM_CR_TSM.MPM_TSMNewSvc {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CallContext", Namespace="http://schemas.microsoft.com/dynamics/2013/01/datacontracts")]
    [System.SerializableAttribute()]
    public partial class CallContext : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompanyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LanguageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PartitionKeyField;
        
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
        public string Company {
            get {
                return this.CompanyField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyField, value) != true)) {
                    this.CompanyField = value;
                    this.RaisePropertyChanged("Company");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Language {
            get {
                return this.LanguageField;
            }
            set {
                if ((object.ReferenceEquals(this.LanguageField, value) != true)) {
                    this.LanguageField = value;
                    this.RaisePropertyChanged("Language");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MessageId {
            get {
                return this.MessageIdField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageIdField, value) != true)) {
                    this.MessageIdField = value;
                    this.RaisePropertyChanged("MessageId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PartitionKey {
            get {
                return this.PartitionKeyField;
            }
            set {
                if ((object.ReferenceEquals(this.PartitionKeyField, value) != true)) {
                    this.PartitionKeyField = value;
                    this.RaisePropertyChanged("PartitionKey");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Infolog", Namespace="http://schemas.microsoft.com/dynamics/2013/01/datacontracts")]
    [System.SerializableAttribute()]
    public partial class Infolog : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MPM_CR_TSM.MPM_TSMNewSvc.InfologEntry[] EntriesField;
        
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
        public MPM_CR_TSM.MPM_TSMNewSvc.InfologEntry[] Entries {
            get {
                return this.EntriesField;
            }
            set {
                if ((object.ReferenceEquals(this.EntriesField, value) != true)) {
                    this.EntriesField = value;
                    this.RaisePropertyChanged("Entries");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="InfologEntry", Namespace="http://schemas.microsoft.com/dynamics/2013/01/datacontracts")]
    [System.SerializableAttribute()]
    public partial class InfologEntry : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MPM_CR_TSM.MPM_TSMNewSvc.InfologType TypeField;
        
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
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MPM_CR_TSM.MPM_TSMNewSvc.InfologType Type {
            get {
                return this.TypeField;
            }
            set {
                if ((this.TypeField.Equals(value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="InfologType", Namespace="http://schemas.microsoft.com/dynamics/2013/01/datacontracts")]
    public enum InfologType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Info = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Warning = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Error = 2,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MPM_TSMNew_Temp", Namespace="http://schemas.datacontract.org/2004/07/Dynamics.AX.Application")]
    [System.SerializableAttribute()]
    public partial class MPM_TSMNew_Temp : MPM_CR_TSM.MPM_TSMNewSvc.XppObjectBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime prmCheckInDateTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime prmCheckOutDateTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string prmDriverCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string prmTransIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string prmlogCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string prmlogStatusField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime prmCheckInDateTime {
            get {
                return this.prmCheckInDateTimeField;
            }
            set {
                if ((this.prmCheckInDateTimeField.Equals(value) != true)) {
                    this.prmCheckInDateTimeField = value;
                    this.RaisePropertyChanged("prmCheckInDateTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime prmCheckOutDateTime {
            get {
                return this.prmCheckOutDateTimeField;
            }
            set {
                if ((this.prmCheckOutDateTimeField.Equals(value) != true)) {
                    this.prmCheckOutDateTimeField = value;
                    this.RaisePropertyChanged("prmCheckOutDateTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string prmDriverCode {
            get {
                return this.prmDriverCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.prmDriverCodeField, value) != true)) {
                    this.prmDriverCodeField = value;
                    this.RaisePropertyChanged("prmDriverCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string prmTransId {
            get {
                return this.prmTransIdField;
            }
            set {
                if ((object.ReferenceEquals(this.prmTransIdField, value) != true)) {
                    this.prmTransIdField = value;
                    this.RaisePropertyChanged("prmTransId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string prmlogCode {
            get {
                return this.prmlogCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.prmlogCodeField, value) != true)) {
                    this.prmlogCodeField = value;
                    this.RaisePropertyChanged("prmlogCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string prmlogStatus {
            get {
                return this.prmlogStatusField;
            }
            set {
                if ((object.ReferenceEquals(this.prmlogStatusField, value) != true)) {
                    this.prmlogStatusField = value;
                    this.RaisePropertyChanged("prmlogStatus");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProxyBase", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.Dynamics.AX.KernelInterop")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MPM_CR_TSM.MPM_TSMNewSvc.XppObjectBase))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MPM_CR_TSM.MPM_TSMNewSvc.MPM_TSMNew_Temp))]
    public partial class ProxyBase : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.Runtime.Serialization.DataContractAttribute(Name="XppObjectBase", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.Dynamics.Ax.Xpp")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MPM_CR_TSM.MPM_TSMNewSvc.MPM_TSMNew_Temp))]
    public partial class XppObjectBase : MPM_CR_TSM.MPM_TSMNewSvc.ProxyBase {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Fault", Namespace="http://schemas.microsoft.com/dynamics/2013/01/datacontracts")]
    [System.SerializableAttribute()]
    public partial class Fault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ExceptionMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ExceptionTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid RequestIdField;
        
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
        public string ExceptionMessage {
            get {
                return this.ExceptionMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ExceptionMessageField, value) != true)) {
                    this.ExceptionMessageField = value;
                    this.RaisePropertyChanged("ExceptionMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ExceptionType {
            get {
                return this.ExceptionTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.ExceptionTypeField, value) != true)) {
                    this.ExceptionTypeField = value;
                    this.RaisePropertyChanged("ExceptionType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid RequestId {
            get {
                return this.RequestIdField;
            }
            set {
                if ((this.RequestIdField.Equals(value) != true)) {
                    this.RequestIdField = value;
                    this.RaisePropertyChanged("RequestId");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tempuri.org", ConfigurationName="MPM_TSMNewSvc.MPM_TSMNew_SvcCntr")]
    public interface MPM_TSMNew_SvcCntr {
        
        // CODEGEN: Generating message contract since message postTSMAbsenDriver has headers
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MPM_TSMNew_SvcCntr/postTSMAbsenDriver", ReplyAction="http://tempuri.org/MPM_TSMNew_SvcCntr/postTSMAbsenDriverResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MPM_CR_TSM.MPM_TSMNewSvc.Fault), Action="http://tempuri.org/MPM_TSMNew_SvcCntr/Fault", Name="Fault", Namespace="http://schemas.microsoft.com/dynamics/2013/01/datacontracts")]
        MPM_CR_TSM.MPM_TSMNewSvc.postTSMAbsenDriverResponse postTSMAbsenDriver(MPM_CR_TSM.MPM_TSMNewSvc.postTSMAbsenDriver request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MPM_TSMNew_SvcCntr/postTSMAbsenDriver", ReplyAction="http://tempuri.org/MPM_TSMNew_SvcCntr/postTSMAbsenDriverResponse")]
        System.Threading.Tasks.Task<MPM_CR_TSM.MPM_TSMNewSvc.postTSMAbsenDriverResponse> postTSMAbsenDriverAsync(MPM_CR_TSM.MPM_TSMNewSvc.postTSMAbsenDriver request);
        
        // CODEGEN: Generating message contract since message getRuleOT_WFH has headers
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MPM_TSMNew_SvcCntr/getRuleOT_WFH", ReplyAction="http://tempuri.org/MPM_TSMNew_SvcCntr/getRuleOT_WFHResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MPM_CR_TSM.MPM_TSMNewSvc.Fault), Action="http://tempuri.org/MPM_TSMNew_SvcCntr/Fault", Name="Fault", Namespace="http://schemas.microsoft.com/dynamics/2013/01/datacontracts")]
        MPM_CR_TSM.MPM_TSMNewSvc.getRuleOT_WFHResponse getRuleOT_WFH(MPM_CR_TSM.MPM_TSMNewSvc.getRuleOT_WFH request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MPM_TSMNew_SvcCntr/getRuleOT_WFH", ReplyAction="http://tempuri.org/MPM_TSMNew_SvcCntr/getRuleOT_WFHResponse")]
        System.Threading.Tasks.Task<MPM_CR_TSM.MPM_TSMNewSvc.getRuleOT_WFHResponse> getRuleOT_WFHAsync(MPM_CR_TSM.MPM_TSMNewSvc.getRuleOT_WFH request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="postTSMAbsenDriver", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class postTSMAbsenDriver {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/dynamics/2013/01/datacontracts")]
        public MPM_CR_TSM.MPM_TSMNewSvc.CallContext CallContext;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=0)]
        public System.DateTime ApprovedDateTime;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=1)]
        public System.DateTime CheckInDateTime;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=2)]
        public System.DateTime CheckOutDateTime;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=3)]
        public string CustId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=4)]
        public string CustName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=5)]
        public string DriverCode;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=6)]
        public string DriverName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=7)]
        public string Nopol;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=8)]
        public string Notes;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=9)]
        public string OutOfTown;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=10)]
        public string PICName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=11)]
        public decimal Scoring;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=12)]
        public string TempDriverCode;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=13)]
        public string Town_City;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=14)]
        public string TransID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=15)]
        public decimal UsageKMEnd;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=16)]
        public decimal UsageKMStart;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=17)]
        public string approvalType;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=18)]
        public string approvedBy;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=19)]
        public string typeOfUse;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=20)]
        public string typeOfWork;
        
        public postTSMAbsenDriver() {
        }
        
        public postTSMAbsenDriver(
                    MPM_CR_TSM.MPM_TSMNewSvc.CallContext CallContext, 
                    System.DateTime ApprovedDateTime, 
                    System.DateTime CheckInDateTime, 
                    System.DateTime CheckOutDateTime, 
                    string CustId, 
                    string CustName, 
                    string DriverCode, 
                    string DriverName, 
                    string Nopol, 
                    string Notes, 
                    string OutOfTown, 
                    string PICName, 
                    decimal Scoring, 
                    string TempDriverCode, 
                    string Town_City, 
                    string TransID, 
                    decimal UsageKMEnd, 
                    decimal UsageKMStart, 
                    string approvalType, 
                    string approvedBy, 
                    string typeOfUse, 
                    string typeOfWork) {
            this.CallContext = CallContext;
            this.ApprovedDateTime = ApprovedDateTime;
            this.CheckInDateTime = CheckInDateTime;
            this.CheckOutDateTime = CheckOutDateTime;
            this.CustId = CustId;
            this.CustName = CustName;
            this.DriverCode = DriverCode;
            this.DriverName = DriverName;
            this.Nopol = Nopol;
            this.Notes = Notes;
            this.OutOfTown = OutOfTown;
            this.PICName = PICName;
            this.Scoring = Scoring;
            this.TempDriverCode = TempDriverCode;
            this.Town_City = Town_City;
            this.TransID = TransID;
            this.UsageKMEnd = UsageKMEnd;
            this.UsageKMStart = UsageKMStart;
            this.approvalType = approvalType;
            this.approvedBy = approvedBy;
            this.typeOfUse = typeOfUse;
            this.typeOfWork = typeOfWork;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="postTSMAbsenDriverResponse", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class postTSMAbsenDriverResponse {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/dynamics/2013/01/datacontracts")]
        public MPM_CR_TSM.MPM_TSMNewSvc.Infolog Infolog;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=0)]
        public MPM_CR_TSM.MPM_TSMNewSvc.MPM_TSMNew_Temp[] result;
        
        public postTSMAbsenDriverResponse() {
        }
        
        public postTSMAbsenDriverResponse(MPM_CR_TSM.MPM_TSMNewSvc.Infolog Infolog, MPM_CR_TSM.MPM_TSMNewSvc.MPM_TSMNew_Temp[] result) {
            this.Infolog = Infolog;
            this.result = result;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getRuleOT_WFH", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class getRuleOT_WFH {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/dynamics/2013/01/datacontracts")]
        public MPM_CR_TSM.MPM_TSMNewSvc.CallContext CallContext;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=0)]
        public string DriverCode;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=1)]
        public string typeOfWork;
        
        public getRuleOT_WFH() {
        }
        
        public getRuleOT_WFH(MPM_CR_TSM.MPM_TSMNewSvc.CallContext CallContext, string DriverCode, string typeOfWork) {
            this.CallContext = CallContext;
            this.DriverCode = DriverCode;
            this.typeOfWork = typeOfWork;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getRuleOT_WFHResponse", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class getRuleOT_WFHResponse {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/dynamics/2013/01/datacontracts")]
        public MPM_CR_TSM.MPM_TSMNewSvc.Infolog Infolog;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=0)]
        public MPM_CR_TSM.MPM_TSMNewSvc.MPM_TSMNew_Temp[] result;
        
        public getRuleOT_WFHResponse() {
        }
        
        public getRuleOT_WFHResponse(MPM_CR_TSM.MPM_TSMNewSvc.Infolog Infolog, MPM_CR_TSM.MPM_TSMNewSvc.MPM_TSMNew_Temp[] result) {
            this.Infolog = Infolog;
            this.result = result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MPM_TSMNew_SvcCntrChannel : MPM_CR_TSM.MPM_TSMNewSvc.MPM_TSMNew_SvcCntr, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MPM_TSMNew_SvcCntrClient : System.ServiceModel.ClientBase<MPM_CR_TSM.MPM_TSMNewSvc.MPM_TSMNew_SvcCntr>, MPM_CR_TSM.MPM_TSMNewSvc.MPM_TSMNew_SvcCntr {
        
        public MPM_TSMNew_SvcCntrClient() {
        }
        
        public MPM_TSMNew_SvcCntrClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MPM_TSMNew_SvcCntrClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MPM_TSMNew_SvcCntrClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MPM_TSMNew_SvcCntrClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MPM_CR_TSM.MPM_TSMNewSvc.postTSMAbsenDriverResponse MPM_CR_TSM.MPM_TSMNewSvc.MPM_TSMNew_SvcCntr.postTSMAbsenDriver(MPM_CR_TSM.MPM_TSMNewSvc.postTSMAbsenDriver request) {
            return base.Channel.postTSMAbsenDriver(request);
        }
        
        public MPM_CR_TSM.MPM_TSMNewSvc.Infolog postTSMAbsenDriver(
                    MPM_CR_TSM.MPM_TSMNewSvc.CallContext CallContext, 
                    System.DateTime ApprovedDateTime, 
                    System.DateTime CheckInDateTime, 
                    System.DateTime CheckOutDateTime, 
                    string CustId, 
                    string CustName, 
                    string DriverCode, 
                    string DriverName, 
                    string Nopol, 
                    string Notes, 
                    string OutOfTown, 
                    string PICName, 
                    decimal Scoring, 
                    string TempDriverCode, 
                    string Town_City, 
                    string TransID, 
                    decimal UsageKMEnd, 
                    decimal UsageKMStart, 
                    string approvalType, 
                    string approvedBy, 
                    string typeOfUse, 
                    string typeOfWork, 
                    out MPM_CR_TSM.MPM_TSMNewSvc.MPM_TSMNew_Temp[] result) {
            MPM_CR_TSM.MPM_TSMNewSvc.postTSMAbsenDriver inValue = new MPM_CR_TSM.MPM_TSMNewSvc.postTSMAbsenDriver();
            inValue.CallContext = CallContext;
            inValue.ApprovedDateTime = ApprovedDateTime;
            inValue.CheckInDateTime = CheckInDateTime;
            inValue.CheckOutDateTime = CheckOutDateTime;
            inValue.CustId = CustId;
            inValue.CustName = CustName;
            inValue.DriverCode = DriverCode;
            inValue.DriverName = DriverName;
            inValue.Nopol = Nopol;
            inValue.Notes = Notes;
            inValue.OutOfTown = OutOfTown;
            inValue.PICName = PICName;
            inValue.Scoring = Scoring;
            inValue.TempDriverCode = TempDriverCode;
            inValue.Town_City = Town_City;
            inValue.TransID = TransID;
            inValue.UsageKMEnd = UsageKMEnd;
            inValue.UsageKMStart = UsageKMStart;
            inValue.approvalType = approvalType;
            inValue.approvedBy = approvedBy;
            inValue.typeOfUse = typeOfUse;
            inValue.typeOfWork = typeOfWork;
            MPM_CR_TSM.MPM_TSMNewSvc.postTSMAbsenDriverResponse retVal = ((MPM_CR_TSM.MPM_TSMNewSvc.MPM_TSMNew_SvcCntr)(this)).postTSMAbsenDriver(inValue);
            result = retVal.result;
            return retVal.Infolog;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MPM_CR_TSM.MPM_TSMNewSvc.postTSMAbsenDriverResponse> MPM_CR_TSM.MPM_TSMNewSvc.MPM_TSMNew_SvcCntr.postTSMAbsenDriverAsync(MPM_CR_TSM.MPM_TSMNewSvc.postTSMAbsenDriver request) {
            return base.Channel.postTSMAbsenDriverAsync(request);
        }
        
        public System.Threading.Tasks.Task<MPM_CR_TSM.MPM_TSMNewSvc.postTSMAbsenDriverResponse> postTSMAbsenDriverAsync(
                    MPM_CR_TSM.MPM_TSMNewSvc.CallContext CallContext, 
                    System.DateTime ApprovedDateTime, 
                    System.DateTime CheckInDateTime, 
                    System.DateTime CheckOutDateTime, 
                    string CustId, 
                    string CustName, 
                    string DriverCode, 
                    string DriverName, 
                    string Nopol, 
                    string Notes, 
                    string OutOfTown, 
                    string PICName, 
                    decimal Scoring, 
                    string TempDriverCode, 
                    string Town_City, 
                    string TransID, 
                    decimal UsageKMEnd, 
                    decimal UsageKMStart, 
                    string approvalType, 
                    string approvedBy, 
                    string typeOfUse, 
                    string typeOfWork) {
            MPM_CR_TSM.MPM_TSMNewSvc.postTSMAbsenDriver inValue = new MPM_CR_TSM.MPM_TSMNewSvc.postTSMAbsenDriver();
            inValue.CallContext = CallContext;
            inValue.ApprovedDateTime = ApprovedDateTime;
            inValue.CheckInDateTime = CheckInDateTime;
            inValue.CheckOutDateTime = CheckOutDateTime;
            inValue.CustId = CustId;
            inValue.CustName = CustName;
            inValue.DriverCode = DriverCode;
            inValue.DriverName = DriverName;
            inValue.Nopol = Nopol;
            inValue.Notes = Notes;
            inValue.OutOfTown = OutOfTown;
            inValue.PICName = PICName;
            inValue.Scoring = Scoring;
            inValue.TempDriverCode = TempDriverCode;
            inValue.Town_City = Town_City;
            inValue.TransID = TransID;
            inValue.UsageKMEnd = UsageKMEnd;
            inValue.UsageKMStart = UsageKMStart;
            inValue.approvalType = approvalType;
            inValue.approvedBy = approvedBy;
            inValue.typeOfUse = typeOfUse;
            inValue.typeOfWork = typeOfWork;
            return ((MPM_CR_TSM.MPM_TSMNewSvc.MPM_TSMNew_SvcCntr)(this)).postTSMAbsenDriverAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MPM_CR_TSM.MPM_TSMNewSvc.getRuleOT_WFHResponse MPM_CR_TSM.MPM_TSMNewSvc.MPM_TSMNew_SvcCntr.getRuleOT_WFH(MPM_CR_TSM.MPM_TSMNewSvc.getRuleOT_WFH request) {
            return base.Channel.getRuleOT_WFH(request);
        }
        
        public MPM_CR_TSM.MPM_TSMNewSvc.Infolog getRuleOT_WFH(MPM_CR_TSM.MPM_TSMNewSvc.CallContext CallContext, string DriverCode, string typeOfWork, out MPM_CR_TSM.MPM_TSMNewSvc.MPM_TSMNew_Temp[] result) {
            MPM_CR_TSM.MPM_TSMNewSvc.getRuleOT_WFH inValue = new MPM_CR_TSM.MPM_TSMNewSvc.getRuleOT_WFH();
            inValue.CallContext = CallContext;
            inValue.DriverCode = DriverCode;
            inValue.typeOfWork = typeOfWork;
            MPM_CR_TSM.MPM_TSMNewSvc.getRuleOT_WFHResponse retVal = ((MPM_CR_TSM.MPM_TSMNewSvc.MPM_TSMNew_SvcCntr)(this)).getRuleOT_WFH(inValue);
            result = retVal.result;
            return retVal.Infolog;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MPM_CR_TSM.MPM_TSMNewSvc.getRuleOT_WFHResponse> MPM_CR_TSM.MPM_TSMNewSvc.MPM_TSMNew_SvcCntr.getRuleOT_WFHAsync(MPM_CR_TSM.MPM_TSMNewSvc.getRuleOT_WFH request) {
            return base.Channel.getRuleOT_WFHAsync(request);
        }
        
        public System.Threading.Tasks.Task<MPM_CR_TSM.MPM_TSMNewSvc.getRuleOT_WFHResponse> getRuleOT_WFHAsync(MPM_CR_TSM.MPM_TSMNewSvc.CallContext CallContext, string DriverCode, string typeOfWork) {
            MPM_CR_TSM.MPM_TSMNewSvc.getRuleOT_WFH inValue = new MPM_CR_TSM.MPM_TSMNewSvc.getRuleOT_WFH();
            inValue.CallContext = CallContext;
            inValue.DriverCode = DriverCode;
            inValue.typeOfWork = typeOfWork;
            return ((MPM_CR_TSM.MPM_TSMNewSvc.MPM_TSMNew_SvcCntr)(this)).getRuleOT_WFHAsync(inValue);
        }
    }
}
