﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UCSF.Data
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="UCSF")]
	public partial class UCSDDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPrincipalInvestigator(PrincipalInvestigator instance);
    partial void UpdatePrincipalInvestigator(PrincipalInvestigator instance);
    partial void DeletePrincipalInvestigator(PrincipalInvestigator instance);
    partial void InsertGrantPrincipal(GrantPrincipal instance);
    partial void UpdateGrantPrincipal(GrantPrincipal instance);
    partial void DeleteGrantPrincipal(GrantPrincipal instance);
    partial void InsertGrant(Grant instance);
    partial void UpdateGrant(Grant instance);
    partial void DeleteGrant(Grant instance);
    #endregion
		
		public UCSDDataContext() : 
				base(global::UCSF.Data.Properties.Settings.Default.UCSFConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public UCSDDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UCSDDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UCSDDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UCSDDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<PrincipalInvestigator> PrincipalInvestigators
		{
			get
			{
				return this.GetTable<PrincipalInvestigator>();
			}
		}
		
		public System.Data.Linq.Table<GrantPrincipal> GrantPrincipals
		{
			get
			{
				return this.GetTable<GrantPrincipal>();
			}
		}
		
		public System.Data.Linq.Table<Grant> Grants
		{
			get
			{
				return this.GetTable<Grant>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PrincipalInvestigator")]
	public partial class PrincipalInvestigator : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _PrincipalInvestigatorId;
		
		private int _PrincipalInvestigator_Id;
		
		private string _Name;
		
		private EntitySet<GrantPrincipal> _GrantPrincipals;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPrincipalInvestigatorIdChanging(System.Guid value);
    partial void OnPrincipalInvestigatorIdChanged();
    partial void OnPrincipalInvestigator_IdChanging(int value);
    partial void OnPrincipalInvestigator_IdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public PrincipalInvestigator()
		{
			this._GrantPrincipals = new EntitySet<GrantPrincipal>(new Action<GrantPrincipal>(this.attach_GrantPrincipals), new Action<GrantPrincipal>(this.detach_GrantPrincipals));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrincipalInvestigatorId", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true, UpdateCheck=UpdateCheck.Never)]
		public System.Guid PrincipalInvestigatorId
		{
			get
			{
				return this._PrincipalInvestigatorId;
			}
			set
			{
				if ((this._PrincipalInvestigatorId != value))
				{
					this.OnPrincipalInvestigatorIdChanging(value);
					this.SendPropertyChanging();
					this._PrincipalInvestigatorId = value;
					this.SendPropertyChanged("PrincipalInvestigatorId");
					this.OnPrincipalInvestigatorIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrincipalInvestigator_Id", DbType="Int NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public int PrincipalInvestigator_Id
		{
			get
			{
				return this._PrincipalInvestigator_Id;
			}
			set
			{
				if ((this._PrincipalInvestigator_Id != value))
				{
					this.OnPrincipalInvestigator_IdChanging(value);
					this.SendPropertyChanging();
					this._PrincipalInvestigator_Id = value;
					this.SendPropertyChanged("PrincipalInvestigator_Id");
					this.OnPrincipalInvestigator_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PrincipalInvestigator_GrantPrincipal", Storage="_GrantPrincipals", ThisKey="PrincipalInvestigatorId", OtherKey="PrincipalInvestigatorId")]
		public EntitySet<GrantPrincipal> GrantPrincipals
		{
			get
			{
				return this._GrantPrincipals;
			}
			set
			{
				this._GrantPrincipals.Assign(value);
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
		
		private void attach_GrantPrincipals(GrantPrincipal entity)
		{
			this.SendPropertyChanging();
			entity.PrincipalInvestigator = this;
		}
		
		private void detach_GrantPrincipals(GrantPrincipal entity)
		{
			this.SendPropertyChanging();
			entity.PrincipalInvestigator = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.GrantPrincipal")]
	public partial class GrantPrincipal : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _GrantPrincipalId;
		
		private System.Guid _GrantId;
		
		private System.Guid _PrincipalInvestigatorId;
		
		private EntityRef<PrincipalInvestigator> _PrincipalInvestigator;
		
		private EntityRef<Grant> _Grant;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnGrantPrincipalIdChanging(System.Guid value);
    partial void OnGrantPrincipalIdChanged();
    partial void OnGrantIdChanging(System.Guid value);
    partial void OnGrantIdChanged();
    partial void OnPrincipalInvestigatorIdChanging(System.Guid value);
    partial void OnPrincipalInvestigatorIdChanged();
    #endregion
		
		public GrantPrincipal()
		{
			this._PrincipalInvestigator = default(EntityRef<PrincipalInvestigator>);
			this._Grant = default(EntityRef<Grant>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GrantPrincipalId", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true, UpdateCheck=UpdateCheck.Never)]
		public System.Guid GrantPrincipalId
		{
			get
			{
				return this._GrantPrincipalId;
			}
			set
			{
				if ((this._GrantPrincipalId != value))
				{
					this.OnGrantPrincipalIdChanging(value);
					this.SendPropertyChanging();
					this._GrantPrincipalId = value;
					this.SendPropertyChanged("GrantPrincipalId");
					this.OnGrantPrincipalIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GrantId", DbType="UniqueIdentifier NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public System.Guid GrantId
		{
			get
			{
				return this._GrantId;
			}
			set
			{
				if ((this._GrantId != value))
				{
					if (this._Grant.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnGrantIdChanging(value);
					this.SendPropertyChanging();
					this._GrantId = value;
					this.SendPropertyChanged("GrantId");
					this.OnGrantIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrincipalInvestigatorId", DbType="UniqueIdentifier NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public System.Guid PrincipalInvestigatorId
		{
			get
			{
				return this._PrincipalInvestigatorId;
			}
			set
			{
				if ((this._PrincipalInvestigatorId != value))
				{
					if (this._PrincipalInvestigator.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPrincipalInvestigatorIdChanging(value);
					this.SendPropertyChanging();
					this._PrincipalInvestigatorId = value;
					this.SendPropertyChanged("PrincipalInvestigatorId");
					this.OnPrincipalInvestigatorIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PrincipalInvestigator_GrantPrincipal", Storage="_PrincipalInvestigator", ThisKey="PrincipalInvestigatorId", OtherKey="PrincipalInvestigatorId", IsForeignKey=true)]
		public PrincipalInvestigator PrincipalInvestigator
		{
			get
			{
				return this._PrincipalInvestigator.Entity;
			}
			set
			{
				PrincipalInvestigator previousValue = this._PrincipalInvestigator.Entity;
				if (((previousValue != value) 
							|| (this._PrincipalInvestigator.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PrincipalInvestigator.Entity = null;
						previousValue.GrantPrincipals.Remove(this);
					}
					this._PrincipalInvestigator.Entity = value;
					if ((value != null))
					{
						value.GrantPrincipals.Add(this);
						this._PrincipalInvestigatorId = value.PrincipalInvestigatorId;
					}
					else
					{
						this._PrincipalInvestigatorId = default(System.Guid);
					}
					this.SendPropertyChanged("PrincipalInvestigator");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Grant_GrantPrincipal", Storage="_Grant", ThisKey="GrantId", OtherKey="GrantId", IsForeignKey=true)]
		public Grant Grant
		{
			get
			{
				return this._Grant.Entity;
			}
			set
			{
				Grant previousValue = this._Grant.Entity;
				if (((previousValue != value) 
							|| (this._Grant.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Grant.Entity = null;
						previousValue.GrantPrincipals.Remove(this);
					}
					this._Grant.Entity = value;
					if ((value != null))
					{
						value.GrantPrincipals.Add(this);
						this._GrantId = value.GrantId;
					}
					else
					{
						this._GrantId = default(System.Guid);
					}
					this.SendPropertyChanged("Grant");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Grant]")]
	public partial class Grant : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _GrantId;
		
		private int _ApplicationId;
		
		private string _Activity;
		
		private string _AdministeringIC;
		
		private int _ApplicationType;
		
		private System.Nullable<bool> _ARRAFunded;
		
		private System.Nullable<System.DateTime> _BudgetStart;
		
		private System.Nullable<System.DateTime> _BudgetEnd;
		
		private string _FOANumber;
		
		private string _FullProjectNum;
		
		private string _FundingICS;
		
		private int _FY;
		
		private string _OrgCity;
		
		private string _OrgCountry;
		
		private string _OrgDistrict;
		
		private int _OrgDUNS;
		
		private string _OrgDept;
		
		private string _OrgFIPS;
		
		private string _OrgState;
		
		private string _OrgZip;
		
		private string _ICName;
		
		private string _OrgName;
		
		private string _ProjectTitle;
		
		private System.Nullable<System.DateTime> _ProjectStart;
		
		private System.Nullable<System.DateTime> _ProjectEnd;
		
		private string _CoreProjectNumber;
		
		private string _XML;
		
		private EntitySet<GrantPrincipal> _GrantPrincipals;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnGrantIdChanging(System.Guid value);
    partial void OnGrantIdChanged();
    partial void OnApplicationIdChanging(int value);
    partial void OnApplicationIdChanged();
    partial void OnActivityChanging(string value);
    partial void OnActivityChanged();
    partial void OnAdministeringICChanging(string value);
    partial void OnAdministeringICChanged();
    partial void OnApplicationTypeChanging(int value);
    partial void OnApplicationTypeChanged();
    partial void OnARRAFundedChanging(System.Nullable<bool> value);
    partial void OnARRAFundedChanged();
    partial void OnBudgetStartChanging(System.Nullable<System.DateTime> value);
    partial void OnBudgetStartChanged();
    partial void OnBudgetEndChanging(System.Nullable<System.DateTime> value);
    partial void OnBudgetEndChanged();
    partial void OnFOANumberChanging(string value);
    partial void OnFOANumberChanged();
    partial void OnFullProjectNumChanging(string value);
    partial void OnFullProjectNumChanged();
    partial void OnFundingICSChanging(string value);
    partial void OnFundingICSChanged();
    partial void OnFYChanging(int value);
    partial void OnFYChanged();
    partial void OnOrgCityChanging(string value);
    partial void OnOrgCityChanged();
    partial void OnOrgCountryChanging(string value);
    partial void OnOrgCountryChanged();
    partial void OnOrgDistrictChanging(string value);
    partial void OnOrgDistrictChanged();
    partial void OnOrgDUNSChanging(int value);
    partial void OnOrgDUNSChanged();
    partial void OnOrgDeptChanging(string value);
    partial void OnOrgDeptChanged();
    partial void OnOrgFIPSChanging(string value);
    partial void OnOrgFIPSChanged();
    partial void OnOrgStateChanging(string value);
    partial void OnOrgStateChanged();
    partial void OnOrgZipChanging(string value);
    partial void OnOrgZipChanged();
    partial void OnICNameChanging(string value);
    partial void OnICNameChanged();
    partial void OnOrgNameChanging(string value);
    partial void OnOrgNameChanged();
    partial void OnProjectTitleChanging(string value);
    partial void OnProjectTitleChanged();
    partial void OnProjectStartChanging(System.Nullable<System.DateTime> value);
    partial void OnProjectStartChanged();
    partial void OnProjectEndChanging(System.Nullable<System.DateTime> value);
    partial void OnProjectEndChanged();
    partial void OnCoreProjectNumberChanging(string value);
    partial void OnCoreProjectNumberChanged();
    partial void OnXMLChanging(string value);
    partial void OnXMLChanged();
    #endregion
		
		public Grant()
		{
			this._GrantPrincipals = new EntitySet<GrantPrincipal>(new Action<GrantPrincipal>(this.attach_GrantPrincipals), new Action<GrantPrincipal>(this.detach_GrantPrincipals));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GrantId", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true, UpdateCheck=UpdateCheck.Never)]
		public System.Guid GrantId
		{
			get
			{
				return this._GrantId;
			}
			set
			{
				if ((this._GrantId != value))
				{
					this.OnGrantIdChanging(value);
					this.SendPropertyChanging();
					this._GrantId = value;
					this.SendPropertyChanged("GrantId");
					this.OnGrantIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ApplicationId", DbType="Int NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public int ApplicationId
		{
			get
			{
				return this._ApplicationId;
			}
			set
			{
				if ((this._ApplicationId != value))
				{
					this.OnApplicationIdChanging(value);
					this.SendPropertyChanging();
					this._ApplicationId = value;
					this.SendPropertyChanged("ApplicationId");
					this.OnApplicationIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Activity", DbType="VarChar(50) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Activity
		{
			get
			{
				return this._Activity;
			}
			set
			{
				if ((this._Activity != value))
				{
					this.OnActivityChanging(value);
					this.SendPropertyChanging();
					this._Activity = value;
					this.SendPropertyChanged("Activity");
					this.OnActivityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdministeringIC", DbType="VarChar(50) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string AdministeringIC
		{
			get
			{
				return this._AdministeringIC;
			}
			set
			{
				if ((this._AdministeringIC != value))
				{
					this.OnAdministeringICChanging(value);
					this.SendPropertyChanging();
					this._AdministeringIC = value;
					this.SendPropertyChanged("AdministeringIC");
					this.OnAdministeringICChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ApplicationType", DbType="Int NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public int ApplicationType
		{
			get
			{
				return this._ApplicationType;
			}
			set
			{
				if ((this._ApplicationType != value))
				{
					this.OnApplicationTypeChanging(value);
					this.SendPropertyChanging();
					this._ApplicationType = value;
					this.SendPropertyChanged("ApplicationType");
					this.OnApplicationTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ARRAFunded", DbType="Bit", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<bool> ARRAFunded
		{
			get
			{
				return this._ARRAFunded;
			}
			set
			{
				if ((this._ARRAFunded != value))
				{
					this.OnARRAFundedChanging(value);
					this.SendPropertyChanging();
					this._ARRAFunded = value;
					this.SendPropertyChanged("ARRAFunded");
					this.OnARRAFundedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BudgetStart", DbType="DateTime", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<System.DateTime> BudgetStart
		{
			get
			{
				return this._BudgetStart;
			}
			set
			{
				if ((this._BudgetStart != value))
				{
					this.OnBudgetStartChanging(value);
					this.SendPropertyChanging();
					this._BudgetStart = value;
					this.SendPropertyChanged("BudgetStart");
					this.OnBudgetStartChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BudgetEnd", DbType="DateTime", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<System.DateTime> BudgetEnd
		{
			get
			{
				return this._BudgetEnd;
			}
			set
			{
				if ((this._BudgetEnd != value))
				{
					this.OnBudgetEndChanging(value);
					this.SendPropertyChanging();
					this._BudgetEnd = value;
					this.SendPropertyChanged("BudgetEnd");
					this.OnBudgetEndChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FOANumber", DbType="VarChar(255)", UpdateCheck=UpdateCheck.Never)]
		public string FOANumber
		{
			get
			{
				return this._FOANumber;
			}
			set
			{
				if ((this._FOANumber != value))
				{
					this.OnFOANumberChanging(value);
					this.SendPropertyChanging();
					this._FOANumber = value;
					this.SendPropertyChanged("FOANumber");
					this.OnFOANumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullProjectNum", DbType="VarChar(255)", UpdateCheck=UpdateCheck.Never)]
		public string FullProjectNum
		{
			get
			{
				return this._FullProjectNum;
			}
			set
			{
				if ((this._FullProjectNum != value))
				{
					this.OnFullProjectNumChanging(value);
					this.SendPropertyChanging();
					this._FullProjectNum = value;
					this.SendPropertyChanged("FullProjectNum");
					this.OnFullProjectNumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FundingICS", DbType="VarChar(400)", UpdateCheck=UpdateCheck.Never)]
		public string FundingICS
		{
			get
			{
				return this._FundingICS;
			}
			set
			{
				if ((this._FundingICS != value))
				{
					this.OnFundingICSChanging(value);
					this.SendPropertyChanging();
					this._FundingICS = value;
					this.SendPropertyChanged("FundingICS");
					this.OnFundingICSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FY", DbType="Int NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public int FY
		{
			get
			{
				return this._FY;
			}
			set
			{
				if ((this._FY != value))
				{
					this.OnFYChanging(value);
					this.SendPropertyChanging();
					this._FY = value;
					this.SendPropertyChanged("FY");
					this.OnFYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrgCity", DbType="VarChar(255)", UpdateCheck=UpdateCheck.Never)]
		public string OrgCity
		{
			get
			{
				return this._OrgCity;
			}
			set
			{
				if ((this._OrgCity != value))
				{
					this.OnOrgCityChanging(value);
					this.SendPropertyChanging();
					this._OrgCity = value;
					this.SendPropertyChanged("OrgCity");
					this.OnOrgCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrgCountry", DbType="VarChar(255)", UpdateCheck=UpdateCheck.Never)]
		public string OrgCountry
		{
			get
			{
				return this._OrgCountry;
			}
			set
			{
				if ((this._OrgCountry != value))
				{
					this.OnOrgCountryChanging(value);
					this.SendPropertyChanging();
					this._OrgCountry = value;
					this.SendPropertyChanged("OrgCountry");
					this.OnOrgCountryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrgDistrict", DbType="VarChar(255)", UpdateCheck=UpdateCheck.Never)]
		public string OrgDistrict
		{
			get
			{
				return this._OrgDistrict;
			}
			set
			{
				if ((this._OrgDistrict != value))
				{
					this.OnOrgDistrictChanging(value);
					this.SendPropertyChanging();
					this._OrgDistrict = value;
					this.SendPropertyChanged("OrgDistrict");
					this.OnOrgDistrictChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrgDUNS", DbType="Int NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public int OrgDUNS
		{
			get
			{
				return this._OrgDUNS;
			}
			set
			{
				if ((this._OrgDUNS != value))
				{
					this.OnOrgDUNSChanging(value);
					this.SendPropertyChanging();
					this._OrgDUNS = value;
					this.SendPropertyChanged("OrgDUNS");
					this.OnOrgDUNSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrgDept", DbType="VarChar(255)", UpdateCheck=UpdateCheck.Never)]
		public string OrgDept
		{
			get
			{
				return this._OrgDept;
			}
			set
			{
				if ((this._OrgDept != value))
				{
					this.OnOrgDeptChanging(value);
					this.SendPropertyChanging();
					this._OrgDept = value;
					this.SendPropertyChanged("OrgDept");
					this.OnOrgDeptChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrgFIPS", DbType="VarChar(255)", UpdateCheck=UpdateCheck.Never)]
		public string OrgFIPS
		{
			get
			{
				return this._OrgFIPS;
			}
			set
			{
				if ((this._OrgFIPS != value))
				{
					this.OnOrgFIPSChanging(value);
					this.SendPropertyChanging();
					this._OrgFIPS = value;
					this.SendPropertyChanged("OrgFIPS");
					this.OnOrgFIPSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrgState", DbType="VarChar(2)", UpdateCheck=UpdateCheck.Never)]
		public string OrgState
		{
			get
			{
				return this._OrgState;
			}
			set
			{
				if ((this._OrgState != value))
				{
					this.OnOrgStateChanging(value);
					this.SendPropertyChanging();
					this._OrgState = value;
					this.SendPropertyChanged("OrgState");
					this.OnOrgStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrgZip", DbType="VarChar(9)", UpdateCheck=UpdateCheck.Never)]
		public string OrgZip
		{
			get
			{
				return this._OrgZip;
			}
			set
			{
				if ((this._OrgZip != value))
				{
					this.OnOrgZipChanging(value);
					this.SendPropertyChanging();
					this._OrgZip = value;
					this.SendPropertyChanged("OrgZip");
					this.OnOrgZipChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ICName", DbType="VarChar(255)", UpdateCheck=UpdateCheck.Never)]
		public string ICName
		{
			get
			{
				return this._ICName;
			}
			set
			{
				if ((this._ICName != value))
				{
					this.OnICNameChanging(value);
					this.SendPropertyChanging();
					this._ICName = value;
					this.SendPropertyChanged("ICName");
					this.OnICNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrgName", DbType="VarChar(255)", UpdateCheck=UpdateCheck.Never)]
		public string OrgName
		{
			get
			{
				return this._OrgName;
			}
			set
			{
				if ((this._OrgName != value))
				{
					this.OnOrgNameChanging(value);
					this.SendPropertyChanging();
					this._OrgName = value;
					this.SendPropertyChanged("OrgName");
					this.OnOrgNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProjectTitle", DbType="VarChar(255)", UpdateCheck=UpdateCheck.Never)]
		public string ProjectTitle
		{
			get
			{
				return this._ProjectTitle;
			}
			set
			{
				if ((this._ProjectTitle != value))
				{
					this.OnProjectTitleChanging(value);
					this.SendPropertyChanging();
					this._ProjectTitle = value;
					this.SendPropertyChanged("ProjectTitle");
					this.OnProjectTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProjectStart", DbType="DateTime", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<System.DateTime> ProjectStart
		{
			get
			{
				return this._ProjectStart;
			}
			set
			{
				if ((this._ProjectStart != value))
				{
					this.OnProjectStartChanging(value);
					this.SendPropertyChanging();
					this._ProjectStart = value;
					this.SendPropertyChanged("ProjectStart");
					this.OnProjectStartChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProjectEnd", DbType="DateTime", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<System.DateTime> ProjectEnd
		{
			get
			{
				return this._ProjectEnd;
			}
			set
			{
				if ((this._ProjectEnd != value))
				{
					this.OnProjectEndChanging(value);
					this.SendPropertyChanging();
					this._ProjectEnd = value;
					this.SendPropertyChanged("ProjectEnd");
					this.OnProjectEndChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CoreProjectNumber", DbType="VarChar(50)", UpdateCheck=UpdateCheck.Never)]
		public string CoreProjectNumber
		{
			get
			{
				return this._CoreProjectNumber;
			}
			set
			{
				if ((this._CoreProjectNumber != value))
				{
					this.OnCoreProjectNumberChanging(value);
					this.SendPropertyChanging();
					this._CoreProjectNumber = value;
					this.SendPropertyChanged("CoreProjectNumber");
					this.OnCoreProjectNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_XML", DbType="VarChar(MAX)", UpdateCheck=UpdateCheck.Never)]
		public string XML
		{
			get
			{
				return this._XML;
			}
			set
			{
				if ((this._XML != value))
				{
					this.OnXMLChanging(value);
					this.SendPropertyChanging();
					this._XML = value;
					this.SendPropertyChanged("XML");
					this.OnXMLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Grant_GrantPrincipal", Storage="_GrantPrincipals", ThisKey="GrantId", OtherKey="GrantId")]
		public EntitySet<GrantPrincipal> GrantPrincipals
		{
			get
			{
				return this._GrantPrincipals;
			}
			set
			{
				this._GrantPrincipals.Assign(value);
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
		
		private void attach_GrantPrincipals(GrantPrincipal entity)
		{
			this.SendPropertyChanging();
			entity.Grant = this;
		}
		
		private void detach_GrantPrincipals(GrantPrincipal entity)
		{
			this.SendPropertyChanging();
			entity.Grant = null;
		}
	}
}
#pragma warning restore 1591