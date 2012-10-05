﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Msts.Mvc.DataAccess.LinqData
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="pubs")]
	public partial class PubsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertemployee(employee instance);
    partial void Updateemployee(employee instance);
    partial void Deleteemployee(employee instance);
    partial void Insertjobs(jobs instance);
    partial void Updatejobs(jobs instance);
    partial void Deletejobs(jobs instance);
    #endregion
		
		public PubsDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["pubsConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public PubsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PubsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PubsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PubsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<employee> employee
		{
			get
			{
				return this.GetTable<employee>();
			}
		}
		
		public System.Data.Linq.Table<jobs> jobs
		{
			get
			{
				return this.GetTable<jobs>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.employee")]
	public partial class employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _emp_id;
		
		private string _fname;
		
		private System.Nullable<char> _minit;
		
		private string _lname;
		
		private short _job_id;
		
		private System.Nullable<byte> _job_lvl;
		
		private string _pub_id;
		
		private System.DateTime _hire_date;
		
		private EntityRef<jobs> _jobs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onemp_idChanging(string value);
    partial void Onemp_idChanged();
    partial void OnfnameChanging(string value);
    partial void OnfnameChanged();
    partial void OnminitChanging(System.Nullable<char> value);
    partial void OnminitChanged();
    partial void OnlnameChanging(string value);
    partial void OnlnameChanged();
    partial void Onjob_idChanging(short value);
    partial void Onjob_idChanged();
    partial void Onjob_lvlChanging(System.Nullable<byte> value);
    partial void Onjob_lvlChanged();
    partial void Onpub_idChanging(string value);
    partial void Onpub_idChanged();
    partial void Onhire_dateChanging(System.DateTime value);
    partial void Onhire_dateChanged();
    #endregion
		
		public employee()
		{
			this._jobs = default(EntityRef<jobs>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_emp_id", DbType="Char(9) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string emp_id
		{
			get
			{
				return this._emp_id;
			}
			set
			{
				if ((this._emp_id != value))
				{
					this.Onemp_idChanging(value);
					this.SendPropertyChanging();
					this._emp_id = value;
					this.SendPropertyChanged("emp_id");
					this.Onemp_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fname", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string fname
		{
			get
			{
				return this._fname;
			}
			set
			{
				if ((this._fname != value))
				{
					this.OnfnameChanging(value);
					this.SendPropertyChanging();
					this._fname = value;
					this.SendPropertyChanged("fname");
					this.OnfnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_minit", DbType="Char(1)")]
		public System.Nullable<char> minit
		{
			get
			{
				return this._minit;
			}
			set
			{
				if ((this._minit != value))
				{
					this.OnminitChanging(value);
					this.SendPropertyChanging();
					this._minit = value;
					this.SendPropertyChanged("minit");
					this.OnminitChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lname", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string lname
		{
			get
			{
				return this._lname;
			}
			set
			{
				if ((this._lname != value))
				{
					this.OnlnameChanging(value);
					this.SendPropertyChanging();
					this._lname = value;
					this.SendPropertyChanged("lname");
					this.OnlnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_job_id", DbType="SmallInt NOT NULL")]
		public short job_id
		{
			get
			{
				return this._job_id;
			}
			set
			{
				if ((this._job_id != value))
				{
					if (this._jobs.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onjob_idChanging(value);
					this.SendPropertyChanging();
					this._job_id = value;
					this.SendPropertyChanged("job_id");
					this.Onjob_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_job_lvl", DbType="TinyInt")]
		public System.Nullable<byte> job_lvl
		{
			get
			{
				return this._job_lvl;
			}
			set
			{
				if ((this._job_lvl != value))
				{
					this.Onjob_lvlChanging(value);
					this.SendPropertyChanging();
					this._job_lvl = value;
					this.SendPropertyChanged("job_lvl");
					this.Onjob_lvlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pub_id", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string pub_id
		{
			get
			{
				return this._pub_id;
			}
			set
			{
				if ((this._pub_id != value))
				{
					this.Onpub_idChanging(value);
					this.SendPropertyChanging();
					this._pub_id = value;
					this.SendPropertyChanged("pub_id");
					this.Onpub_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hire_date", DbType="DateTime NOT NULL")]
		public System.DateTime hire_date
		{
			get
			{
				return this._hire_date;
			}
			set
			{
				if ((this._hire_date != value))
				{
					this.Onhire_dateChanging(value);
					this.SendPropertyChanging();
					this._hire_date = value;
					this.SendPropertyChanged("hire_date");
					this.Onhire_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="jobs_employee", Storage="_jobs", ThisKey="job_id", OtherKey="job_id", IsForeignKey=true)]
		public jobs jobs
		{
			get
			{
				return this._jobs.Entity;
			}
			set
			{
				jobs previousValue = this._jobs.Entity;
				if (((previousValue != value) 
							|| (this._jobs.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._jobs.Entity = null;
						previousValue.employee.Remove(this);
					}
					this._jobs.Entity = value;
					if ((value != null))
					{
						value.employee.Add(this);
						this._job_id = value.job_id;
					}
					else
					{
						this._job_id = default(short);
					}
					this.SendPropertyChanged("jobs");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.jobs")]
	public partial class jobs : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private short _job_id;
		
		private string _job_desc;
		
		private byte _min_lvl;
		
		private byte _max_lvl;
		
		private EntitySet<employee> _employee;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onjob_idChanging(short value);
    partial void Onjob_idChanged();
    partial void Onjob_descChanging(string value);
    partial void Onjob_descChanged();
    partial void Onmin_lvlChanging(byte value);
    partial void Onmin_lvlChanged();
    partial void Onmax_lvlChanging(byte value);
    partial void Onmax_lvlChanged();
    #endregion
		
		public jobs()
		{
			this._employee = new EntitySet<employee>(new Action<employee>(this.attach_employee), new Action<employee>(this.detach_employee));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_job_id", AutoSync=AutoSync.OnInsert, DbType="SmallInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public short job_id
		{
			get
			{
				return this._job_id;
			}
			set
			{
				if ((this._job_id != value))
				{
					this.Onjob_idChanging(value);
					this.SendPropertyChanging();
					this._job_id = value;
					this.SendPropertyChanged("job_id");
					this.Onjob_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_job_desc", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string job_desc
		{
			get
			{
				return this._job_desc;
			}
			set
			{
				if ((this._job_desc != value))
				{
					this.Onjob_descChanging(value);
					this.SendPropertyChanging();
					this._job_desc = value;
					this.SendPropertyChanged("job_desc");
					this.Onjob_descChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_min_lvl", DbType="TinyInt NOT NULL")]
		public byte min_lvl
		{
			get
			{
				return this._min_lvl;
			}
			set
			{
				if ((this._min_lvl != value))
				{
					this.Onmin_lvlChanging(value);
					this.SendPropertyChanging();
					this._min_lvl = value;
					this.SendPropertyChanged("min_lvl");
					this.Onmin_lvlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_max_lvl", DbType="TinyInt NOT NULL")]
		public byte max_lvl
		{
			get
			{
				return this._max_lvl;
			}
			set
			{
				if ((this._max_lvl != value))
				{
					this.Onmax_lvlChanging(value);
					this.SendPropertyChanging();
					this._max_lvl = value;
					this.SendPropertyChanged("max_lvl");
					this.Onmax_lvlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="jobs_employee", Storage="_employee", ThisKey="job_id", OtherKey="job_id")]
		public EntitySet<employee> employee
		{
			get
			{
				return this._employee;
			}
			set
			{
				this._employee.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_employee(employee entity)
		{
			this.SendPropertyChanging();
			entity.jobs = this;
		}
		
		private void detach_employee(employee entity)
		{
			this.SendPropertyChanging();
			entity.jobs = null;
		}
	}
}
#pragma warning restore 1591