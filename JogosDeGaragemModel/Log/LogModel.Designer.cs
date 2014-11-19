﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace JogosDeGaragemModel.Log
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class LogEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new LogEntities object using the connection string found in the 'LogEntities' section of the application configuration file.
        /// </summary>
        public LogEntities() : base("name=LogEntities", "LogEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new LogEntities object.
        /// </summary>
        public LogEntities(string connectionString) : base(connectionString, "LogEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new LogEntities object.
        /// </summary>
        public LogEntities(EntityConnection connection) : base(connection, "LogEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Log> Logs
        {
            get
            {
                if ((_Logs == null))
                {
                    _Logs = base.CreateObjectSet<Log>("Logs");
                }
                return _Logs;
            }
        }
        private ObjectSet<Log> _Logs;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Logs EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToLogs(Log log)
        {
            base.AddObject("Logs", log);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LogModel", Name="Log")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Log : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Log object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="dataAcao">Initial value of the DataAcao property.</param>
        /// <param name="acao">Initial value of the Acao property.</param>
        /// <param name="mensagem">Initial value of the Mensagem property.</param>
        public static Log CreateLog(global::System.Int32 id, global::System.DateTime dataAcao, global::System.String acao, global::System.String mensagem)
        {
            Log log = new Log();
            log.Id = id;
            log.DataAcao = dataAcao;
            log.Acao = acao;
            log.Mensagem = mensagem;
            return log;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime DataAcao
        {
            get
            {
                return _DataAcao;
            }
            set
            {
                OnDataAcaoChanging(value);
                ReportPropertyChanging("DataAcao");
                _DataAcao = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DataAcao");
                OnDataAcaoChanged();
            }
        }
        private global::System.DateTime _DataAcao;
        partial void OnDataAcaoChanging(global::System.DateTime value);
        partial void OnDataAcaoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Acao
        {
            get
            {
                return _Acao;
            }
            set
            {
                OnAcaoChanging(value);
                ReportPropertyChanging("Acao");
                _Acao = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Acao");
                OnAcaoChanged();
            }
        }
        private global::System.String _Acao;
        partial void OnAcaoChanging(global::System.String value);
        partial void OnAcaoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Mensagem
        {
            get
            {
                return _Mensagem;
            }
            set
            {
                OnMensagemChanging(value);
                ReportPropertyChanging("Mensagem");
                _Mensagem = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Mensagem");
                OnMensagemChanged();
            }
        }
        private global::System.String _Mensagem;
        partial void OnMensagemChanging(global::System.String value);
        partial void OnMensagemChanged();

        #endregion

    
    }

    #endregion

    
}