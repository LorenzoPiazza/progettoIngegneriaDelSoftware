﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServerLegaUtente {
    using System.Runtime.Serialization;
    using System;
    using Client.Dominio;

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Utente", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Utente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private bool IsAdminField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Lega", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Lega : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.ServerLegaUtente.Squadra SquadraAdminField;
        
        private int NumeroSquadreTotaliField;
        
        private int CreditiInizialiSquadraField;
        
        private int NumeroPorField;
        
        private int NumeroDifField;
        
        private int NumeroCenField;
        
        private int NumeroAttField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.ServerLegaUtente.Mercato MercatoAttivoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.ServerLegaUtente.ListaSvincolati ListaSvincolatiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.ServerLegaUtente.Squadra[] SquadreField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public Client.ServerLegaUtente.Squadra SquadraAdmin {
            get {
                return this.SquadraAdminField;
            }
            set {
                if ((object.ReferenceEquals(this.SquadraAdminField, value) != true)) {
                    this.SquadraAdminField = value;
                    this.RaisePropertyChanged("SquadraAdmin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public int NumeroSquadreTotali {
            get {
                return this.NumeroSquadreTotaliField;
            }
            set {
                if ((this.NumeroSquadreTotaliField.Equals(value) != true)) {
                    this.NumeroSquadreTotaliField = value;
                    this.RaisePropertyChanged("NumeroSquadreTotali");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int CreditiInizialiSquadra {
            get {
                return this.CreditiInizialiSquadraField;
            }
            set {
                if ((this.CreditiInizialiSquadraField.Equals(value) != true)) {
                    this.CreditiInizialiSquadraField = value;
                    this.RaisePropertyChanged("CreditiInizialiSquadra");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int NumeroPor {
            get {
                return this.NumeroPorField;
            }
            set {
                if ((this.NumeroPorField.Equals(value) != true)) {
                    this.NumeroPorField = value;
                    this.RaisePropertyChanged("NumeroPor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int NumeroDif {
            get {
                return this.NumeroDifField;
            }
            set {
                if ((this.NumeroDifField.Equals(value) != true)) {
                    this.NumeroDifField = value;
                    this.RaisePropertyChanged("NumeroDif");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public int NumeroCen {
            get {
                return this.NumeroCenField;
            }
            set {
                if ((this.NumeroCenField.Equals(value) != true)) {
                    this.NumeroCenField = value;
                    this.RaisePropertyChanged("NumeroCen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public int NumeroAtt {
            get {
                return this.NumeroAttField;
            }
            set {
                if ((this.NumeroAttField.Equals(value) != true)) {
                    this.NumeroAttField = value;
                    this.RaisePropertyChanged("NumeroAtt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public Client.ServerLegaUtente.Mercato MercatoAttivo {
            get {
                return this.MercatoAttivoField;
            }
            set {
                if ((object.ReferenceEquals(this.MercatoAttivoField, value) != true)) {
                    this.MercatoAttivoField = value;
                    this.RaisePropertyChanged("MercatoAttivo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public Client.ServerLegaUtente.ListaSvincolati ListaSvincolati {
            get {
                return this.ListaSvincolatiField;
            }
            set {
                if ((object.ReferenceEquals(this.ListaSvincolatiField, value) != true)) {
                    this.ListaSvincolatiField = value;
                    this.RaisePropertyChanged("ListaSvincolati");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public Client.ServerLegaUtente.Squadra[] Squadre {
            get {
                return this.SquadreField;
            }
            set {
                if ((object.ReferenceEquals(this.SquadreField, value) != true)) {
                    this.SquadreField = value;
                    this.RaisePropertyChanged("Squadre");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Squadra", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Squadra : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        private int CreditResiduiField;
        
        private int NumeroPorField;
        
        private int NumeroDifField;
        
        private int NumeroCenField;
        
        private int NumeroAttField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.ServerLegaUtente.Giocatore[] GiocatoriField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.ServerLegaUtente.Lega LegaField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public int CreditResidui {
            get {
                return this.CreditResiduiField;
            }
            set {
                if ((this.CreditResiduiField.Equals(value) != true)) {
                    this.CreditResiduiField = value;
                    this.RaisePropertyChanged("CreditResidui");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int NumeroPor {
            get {
                return this.NumeroPorField;
            }
            set {
                if ((this.NumeroPorField.Equals(value) != true)) {
                    this.NumeroPorField = value;
                    this.RaisePropertyChanged("NumeroPor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int NumeroDif {
            get {
                return this.NumeroDifField;
            }
            set {
                if ((this.NumeroDifField.Equals(value) != true)) {
                    this.NumeroDifField = value;
                    this.RaisePropertyChanged("NumeroDif");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int NumeroCen {
            get {
                return this.NumeroCenField;
            }
            set {
                if ((this.NumeroCenField.Equals(value) != true)) {
                    this.NumeroCenField = value;
                    this.RaisePropertyChanged("NumeroCen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public int NumeroAtt {
            get {
                return this.NumeroAttField;
            }
            set {
                if ((this.NumeroAttField.Equals(value) != true)) {
                    this.NumeroAttField = value;
                    this.RaisePropertyChanged("NumeroAtt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public Client.ServerLegaUtente.Giocatore[] Giocatori {
            get {
                return this.GiocatoriField;
            }
            set {
                if ((object.ReferenceEquals(this.GiocatoriField, value) != true)) {
                    this.GiocatoriField = value;
                    this.RaisePropertyChanged("Giocatori");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public Client.ServerLegaUtente.Lega Lega {
            get {
                return this.LegaField;
            }
            set {
                if ((object.ReferenceEquals(this.LegaField, value) != true)) {
                    this.LegaField = value;
                    this.RaisePropertyChanged("Lega");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Mercato", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Mercato : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.ServerLegaUtente.Lega LegaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.ServerLegaUtente.Asta[] AsteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.ServerLegaUtente.Squadra[] SquadreField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public Client.ServerLegaUtente.Lega Lega {
            get {
                return this.LegaField;
            }
            set {
                if ((object.ReferenceEquals(this.LegaField, value) != true)) {
                    this.LegaField = value;
                    this.RaisePropertyChanged("Lega");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public Client.ServerLegaUtente.Asta[] Aste {
            get {
                return this.AsteField;
            }
            set {
                if ((object.ReferenceEquals(this.AsteField, value) != true)) {
                    this.AsteField = value;
                    this.RaisePropertyChanged("Aste");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public Client.ServerLegaUtente.Squadra[] Squadre {
            get {
                return this.SquadreField;
            }
            set {
                if ((object.ReferenceEquals(this.SquadreField, value) != true)) {
                    this.SquadreField = value;
                    this.RaisePropertyChanged("Squadre");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ListaSvincolati", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class ListaSvincolati : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.DateTime DataCaricamentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.ServerLegaUtente.Giocatore[] GiocatoriField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime DataCaricamento {
            get {
                return this.DataCaricamentoField;
            }
            set {
                if ((this.DataCaricamentoField.Equals(value) != true)) {
                    this.DataCaricamentoField = value;
                    this.RaisePropertyChanged("DataCaricamento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public Client.ServerLegaUtente.Giocatore[] Giocatori {
            get {
                return this.GiocatoriField;
            }
            set {
                if ((object.ReferenceEquals(this.GiocatoriField, value) != true)) {
                    this.GiocatoriField = value;
                    this.RaisePropertyChanged("Giocatori");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Giocatore", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Giocatore : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeSquadraField;
        
        private int PrezzoAcquistoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string NomeSquadra {
            get {
                return this.NomeSquadraField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeSquadraField, value) != true)) {
                    this.NomeSquadraField = value;
                    this.RaisePropertyChanged("NomeSquadra");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int PrezzoAcquisto {
            get {
                return this.PrezzoAcquistoField;
            }
            set {
                if ((this.PrezzoAcquistoField.Equals(value) != true)) {
                    this.PrezzoAcquistoField = value;
                    this.RaisePropertyChanged("PrezzoAcquisto");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Asta", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Asta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int UltimaOffertaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.ServerLegaUtente.Squadra UltimoOfferenteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.ServerLegaUtente.Squadra[] SquadreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.ServerLegaUtente.Giocatore GiocatoreField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int UltimaOfferta {
            get {
                return this.UltimaOffertaField;
            }
            set {
                if ((this.UltimaOffertaField.Equals(value) != true)) {
                    this.UltimaOffertaField = value;
                    this.RaisePropertyChanged("UltimaOfferta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public Client.ServerLegaUtente.Squadra UltimoOfferente {
            get {
                return this.UltimoOfferenteField;
            }
            set {
                if ((object.ReferenceEquals(this.UltimoOfferenteField, value) != true)) {
                    this.UltimoOfferenteField = value;
                    this.RaisePropertyChanged("UltimoOfferente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public Client.ServerLegaUtente.Squadra[] Squadre {
            get {
                return this.SquadreField;
            }
            set {
                if ((object.ReferenceEquals(this.SquadreField, value) != true)) {
                    this.SquadreField = value;
                    this.RaisePropertyChanged("Squadre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public Client.ServerLegaUtente.Giocatore Giocatore {
            get {
                return this.GiocatoreField;
            }
            set {
                if ((object.ReferenceEquals(this.GiocatoreField, value) != true)) {
                    this.GiocatoreField = value;
                    this.RaisePropertyChanged("Giocatore");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServerLegaUtente.GestioneUtenteControllerSoap")]
    public interface GestioneUtenteControllerSoap {
        
        // CODEGEN: Generazione di un contratto di messaggio perché il nome di elemento nome dallo spazio dei nomi http://tempuri.org/ non è contrassegnato come nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CreaLega", ReplyAction="*")]
        Client.ServerLegaUtente.CreaLegaResponse CreaLega(Client.ServerLegaUtente.CreaLegaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CreaLega", ReplyAction="*")]
        System.Threading.Tasks.Task<Client.ServerLegaUtente.CreaLegaResponse> CreaLegaAsync(Client.ServerLegaUtente.CreaLegaRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreaLegaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreaLega", Namespace="http://tempuri.org/", Order=0)]
        public Client.ServerLegaUtente.CreaLegaRequestBody Body;
        
        public CreaLegaRequest() {
        }
        
        public CreaLegaRequest(Client.ServerLegaUtente.CreaLegaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CreaLegaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nome;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int numeroPartecipanti;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public Client.ServerLegaUtente.Utente utente;
        
        public CreaLegaRequestBody() {
        }
        
        public CreaLegaRequestBody(string nome, int numeroPartecipanti, Client.ServerLegaUtente.Utente utente) {
            this.nome = nome;
            this.numeroPartecipanti = numeroPartecipanti;
            this.utente = utente;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreaLegaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreaLegaResponse", Namespace="http://tempuri.org/", Order=0)]
        public Client.ServerLegaUtente.CreaLegaResponseBody Body;
        
        public CreaLegaResponse() {
        }
        
        public CreaLegaResponse(Client.ServerLegaUtente.CreaLegaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CreaLegaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Client.ServerLegaUtente.Lega CreaLegaResult;
        
        public CreaLegaResponseBody() {
        }
        
        public CreaLegaResponseBody(Client.ServerLegaUtente.Lega CreaLegaResult) {
            this.CreaLegaResult = CreaLegaResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface GestioneUtenteControllerSoapChannel : Client.ServerLegaUtente.GestioneUtenteControllerSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GestioneUtenteControllerSoapClient : System.ServiceModel.ClientBase<Client.ServerLegaUtente.GestioneUtenteControllerSoap>, Client.ServerLegaUtente.GestioneUtenteControllerSoap {
        
        public GestioneUtenteControllerSoapClient() {
        }
        
        public GestioneUtenteControllerSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GestioneUtenteControllerSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GestioneUtenteControllerSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GestioneUtenteControllerSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Client.ServerLegaUtente.CreaLegaResponse Client.ServerLegaUtente.GestioneUtenteControllerSoap.CreaLega(Client.ServerLegaUtente.CreaLegaRequest request) {
            return base.Channel.CreaLega(request);
        }
        
        public Client.ServerLegaUtente.Lega CreaLega(string nome, int numeroPartecipanti, Client.ServerLegaUtente.Utente utente) {
            Client.ServerLegaUtente.CreaLegaRequest inValue = new Client.ServerLegaUtente.CreaLegaRequest();
            inValue.Body = new Client.ServerLegaUtente.CreaLegaRequestBody();
            inValue.Body.nome = nome;
            inValue.Body.numeroPartecipanti = numeroPartecipanti;
            inValue.Body.utente = utente;
            Client.ServerLegaUtente.CreaLegaResponse retVal = ((Client.ServerLegaUtente.GestioneUtenteControllerSoap)(this)).CreaLega(inValue);
            return retVal.Body.CreaLegaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Client.ServerLegaUtente.CreaLegaResponse> Client.ServerLegaUtente.GestioneUtenteControllerSoap.CreaLegaAsync(Client.ServerLegaUtente.CreaLegaRequest request) {
            return base.Channel.CreaLegaAsync(request);
        }
        
        public System.Threading.Tasks.Task<Client.ServerLegaUtente.CreaLegaResponse> CreaLegaAsync(string nome, int numeroPartecipanti, Client.ServerLegaUtente.Utente utente) {
            Client.ServerLegaUtente.CreaLegaRequest inValue = new Client.ServerLegaUtente.CreaLegaRequest();
            inValue.Body = new Client.ServerLegaUtente.CreaLegaRequestBody();
            inValue.Body.nome = nome;
            inValue.Body.numeroPartecipanti = numeroPartecipanti;
            inValue.Body.utente = utente;
            return ((Client.ServerLegaUtente.GestioneUtenteControllerSoap)(this)).CreaLegaAsync(inValue);
        }

        internal Dominio.Lega CreaLega(string text, int value, Dominio.Utente utenteNav)
        {
            throw new NotImplementedException();
        }

        internal bool CambiaPassword(string text1, string text2, string text3, string text4, Dominio.Utente utenteNav)
        {
            throw new NotImplementedException();
        }

        internal void UniscitiAMercato(Dominio.Squadra squadra)
        {
            throw new NotImplementedException();
        }
    }
}
