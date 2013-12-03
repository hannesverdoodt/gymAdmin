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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="gymcheckin")]
public partial class GymCheckinDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void Insertgym_checkin(gym_checkin instance);
  partial void Updategym_checkin(gym_checkin instance);
  partial void Deletegym_checkin(gym_checkin instance);
  partial void Inserttbl_user(tbl_user instance);
  partial void Updatetbl_user(tbl_user instance);
  partial void Deletetbl_user(tbl_user instance);
  partial void Insertgym_user(gym_user instance);
  partial void Updategym_user(gym_user instance);
  partial void Deletegym_user(gym_user instance);
  partial void Inserttbl_checkin(tbl_checkin instance);
  partial void Updatetbl_checkin(tbl_checkin instance);
  partial void Deletetbl_checkin(tbl_checkin instance);
  partial void Inserttbl_function(tbl_function instance);
  partial void Updatetbl_function(tbl_function instance);
  partial void Deletetbl_function(tbl_function instance);
  #endregion

	public GymCheckinDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["gymcheckin"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public GymCheckinDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public GymCheckinDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public GymCheckinDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public GymCheckinDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<gym_checkin> gym_checkins
	{
		get
		{
			return this.GetTable<gym_checkin>();
		}
	}
	
	public System.Data.Linq.Table<tbl_user> tbl_users
	{
		get
		{
			return this.GetTable<tbl_user>();
		}
	}
	
	public System.Data.Linq.Table<gym_user> gym_users
	{
		get
		{
			return this.GetTable<gym_user>();
		}
	}
	
	public System.Data.Linq.Table<tbl_checkin> tbl_checkins
	{
		get
		{
			return this.GetTable<tbl_checkin>();
		}
	}
	
	public System.Data.Linq.Table<tbl_function> tbl_functions
	{
		get
		{
			return this.GetTable<tbl_function>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.gym_checkins")]
public partial class gym_checkin : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _checkin_id;
	
	private System.Nullable<int> _checkin_userid;
	
	private System.Nullable<System.DateTime> _checkin_timestamp;
	
	private string _checkin_userfirstname;
	
	private EntityRef<gym_user> _gym_user;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Oncheckin_idChanging(int value);
    partial void Oncheckin_idChanged();
    partial void Oncheckin_useridChanging(System.Nullable<int> value);
    partial void Oncheckin_useridChanged();
    partial void Oncheckin_timestampChanging(System.Nullable<System.DateTime> value);
    partial void Oncheckin_timestampChanged();
    partial void Oncheckin_userfirstnameChanging(string value);
    partial void Oncheckin_userfirstnameChanged();
    #endregion
	
	public gym_checkin()
	{
		this._gym_user = default(EntityRef<gym_user>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_checkin_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int checkin_id
	{
		get
		{
			return this._checkin_id;
		}
		set
		{
			if ((this._checkin_id != value))
			{
				this.Oncheckin_idChanging(value);
				this.SendPropertyChanging();
				this._checkin_id = value;
				this.SendPropertyChanged("checkin_id");
				this.Oncheckin_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_checkin_userid", DbType="Int")]
	public System.Nullable<int> checkin_userid
	{
		get
		{
			return this._checkin_userid;
		}
		set
		{
			if ((this._checkin_userid != value))
			{
				if (this._gym_user.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.Oncheckin_useridChanging(value);
				this.SendPropertyChanging();
				this._checkin_userid = value;
				this.SendPropertyChanged("checkin_userid");
				this.Oncheckin_useridChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_checkin_timestamp", DbType="DateTime2")]
	public System.Nullable<System.DateTime> checkin_timestamp
	{
		get
		{
			return this._checkin_timestamp;
		}
		set
		{
			if ((this._checkin_timestamp != value))
			{
				this.Oncheckin_timestampChanging(value);
				this.SendPropertyChanging();
				this._checkin_timestamp = value;
				this.SendPropertyChanged("checkin_timestamp");
				this.Oncheckin_timestampChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_checkin_userfirstname", DbType="VarChar(50)")]
	public string checkin_userfirstname
	{
		get
		{
			return this._checkin_userfirstname;
		}
		set
		{
			if ((this._checkin_userfirstname != value))
			{
				this.Oncheckin_userfirstnameChanging(value);
				this.SendPropertyChanging();
				this._checkin_userfirstname = value;
				this.SendPropertyChanged("checkin_userfirstname");
				this.Oncheckin_userfirstnameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="gym_user_gym_checkin", Storage="_gym_user", ThisKey="checkin_userid", OtherKey="user_id", IsForeignKey=true)]
	public gym_user gym_user
	{
		get
		{
			return this._gym_user.Entity;
		}
		set
		{
			gym_user previousValue = this._gym_user.Entity;
			if (((previousValue != value) 
						|| (this._gym_user.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._gym_user.Entity = null;
					previousValue.gym_checkins.Remove(this);
				}
				this._gym_user.Entity = value;
				if ((value != null))
				{
					value.gym_checkins.Add(this);
					this._checkin_userid = value.user_id;
				}
				else
				{
					this._checkin_userid = default(Nullable<int>);
				}
				this.SendPropertyChanged("gym_user");
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_users")]
public partial class tbl_user : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _user_id;
	
	private string _user_firstname;
	
	private string _user_lastname;
	
	private string _user_tiwtter;
	
	private string _user_picture;
	
	private string _user_password;
	
	private System.Nullable<int> _fk_function_id;
	
	private System.Nullable<int> _user_allowed;
	
	private EntitySet<tbl_checkin> _tbl_checkins;
	
	private EntityRef<tbl_function> _tbl_function;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onuser_idChanging(int value);
    partial void Onuser_idChanged();
    partial void Onuser_firstnameChanging(string value);
    partial void Onuser_firstnameChanged();
    partial void Onuser_lastnameChanging(string value);
    partial void Onuser_lastnameChanged();
    partial void Onuser_tiwtterChanging(string value);
    partial void Onuser_tiwtterChanged();
    partial void Onuser_pictureChanging(string value);
    partial void Onuser_pictureChanged();
    partial void Onuser_passwordChanging(string value);
    partial void Onuser_passwordChanged();
    partial void Onfk_function_idChanging(System.Nullable<int> value);
    partial void Onfk_function_idChanged();
    partial void Onuser_allowedChanging(System.Nullable<int> value);
    partial void Onuser_allowedChanged();
    #endregion
	
	public tbl_user()
	{
		this._tbl_checkins = new EntitySet<tbl_checkin>(new Action<tbl_checkin>(this.attach_tbl_checkins), new Action<tbl_checkin>(this.detach_tbl_checkins));
		this._tbl_function = default(EntityRef<tbl_function>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int user_id
	{
		get
		{
			return this._user_id;
		}
		set
		{
			if ((this._user_id != value))
			{
				this.Onuser_idChanging(value);
				this.SendPropertyChanging();
				this._user_id = value;
				this.SendPropertyChanged("user_id");
				this.Onuser_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_firstname", DbType="VarChar(50)")]
	public string user_firstname
	{
		get
		{
			return this._user_firstname;
		}
		set
		{
			if ((this._user_firstname != value))
			{
				this.Onuser_firstnameChanging(value);
				this.SendPropertyChanging();
				this._user_firstname = value;
				this.SendPropertyChanged("user_firstname");
				this.Onuser_firstnameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_lastname", DbType="VarChar(50)")]
	public string user_lastname
	{
		get
		{
			return this._user_lastname;
		}
		set
		{
			if ((this._user_lastname != value))
			{
				this.Onuser_lastnameChanging(value);
				this.SendPropertyChanging();
				this._user_lastname = value;
				this.SendPropertyChanged("user_lastname");
				this.Onuser_lastnameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_tiwtter", DbType="VarChar(50)")]
	public string user_tiwtter
	{
		get
		{
			return this._user_tiwtter;
		}
		set
		{
			if ((this._user_tiwtter != value))
			{
				this.Onuser_tiwtterChanging(value);
				this.SendPropertyChanging();
				this._user_tiwtter = value;
				this.SendPropertyChanged("user_tiwtter");
				this.Onuser_tiwtterChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_picture", DbType="VarChar(128)")]
	public string user_picture
	{
		get
		{
			return this._user_picture;
		}
		set
		{
			if ((this._user_picture != value))
			{
				this.Onuser_pictureChanging(value);
				this.SendPropertyChanging();
				this._user_picture = value;
				this.SendPropertyChanged("user_picture");
				this.Onuser_pictureChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_password", DbType="VarChar(50)")]
	public string user_password
	{
		get
		{
			return this._user_password;
		}
		set
		{
			if ((this._user_password != value))
			{
				this.Onuser_passwordChanging(value);
				this.SendPropertyChanging();
				this._user_password = value;
				this.SendPropertyChanged("user_password");
				this.Onuser_passwordChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fk_function_id", DbType="Int")]
	public System.Nullable<int> fk_function_id
	{
		get
		{
			return this._fk_function_id;
		}
		set
		{
			if ((this._fk_function_id != value))
			{
				if (this._tbl_function.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.Onfk_function_idChanging(value);
				this.SendPropertyChanging();
				this._fk_function_id = value;
				this.SendPropertyChanged("fk_function_id");
				this.Onfk_function_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_allowed", DbType="Int")]
	public System.Nullable<int> user_allowed
	{
		get
		{
			return this._user_allowed;
		}
		set
		{
			if ((this._user_allowed != value))
			{
				this.Onuser_allowedChanging(value);
				this.SendPropertyChanging();
				this._user_allowed = value;
				this.SendPropertyChanged("user_allowed");
				this.Onuser_allowedChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_user_tbl_checkin", Storage="_tbl_checkins", ThisKey="user_id", OtherKey="fk_user_id")]
	public EntitySet<tbl_checkin> tbl_checkins
	{
		get
		{
			return this._tbl_checkins;
		}
		set
		{
			this._tbl_checkins.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_function_tbl_user", Storage="_tbl_function", ThisKey="fk_function_id", OtherKey="function_id", IsForeignKey=true)]
	public tbl_function tbl_function
	{
		get
		{
			return this._tbl_function.Entity;
		}
		set
		{
			tbl_function previousValue = this._tbl_function.Entity;
			if (((previousValue != value) 
						|| (this._tbl_function.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._tbl_function.Entity = null;
					previousValue.tbl_users.Remove(this);
				}
				this._tbl_function.Entity = value;
				if ((value != null))
				{
					value.tbl_users.Add(this);
					this._fk_function_id = value.function_id;
				}
				else
				{
					this._fk_function_id = default(Nullable<int>);
				}
				this.SendPropertyChanged("tbl_function");
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
	
	private void attach_tbl_checkins(tbl_checkin entity)
	{
		this.SendPropertyChanging();
		entity.tbl_user = this;
	}
	
	private void detach_tbl_checkins(tbl_checkin entity)
	{
		this.SendPropertyChanging();
		entity.tbl_user = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.gym_users")]
public partial class gym_user : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _user_id;
	
	private string _user_name;
	
	private string _user_firstname;
	
	private string _user_twitter;
	
	private string _user_imagehash;
	
	private EntitySet<gym_checkin> _gym_checkins;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onuser_idChanging(int value);
    partial void Onuser_idChanged();
    partial void Onuser_nameChanging(string value);
    partial void Onuser_nameChanged();
    partial void Onuser_firstnameChanging(string value);
    partial void Onuser_firstnameChanged();
    partial void Onuser_twitterChanging(string value);
    partial void Onuser_twitterChanged();
    partial void Onuser_imagehashChanging(string value);
    partial void Onuser_imagehashChanged();
    #endregion
	
	public gym_user()
	{
		this._gym_checkins = new EntitySet<gym_checkin>(new Action<gym_checkin>(this.attach_gym_checkins), new Action<gym_checkin>(this.detach_gym_checkins));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int user_id
	{
		get
		{
			return this._user_id;
		}
		set
		{
			if ((this._user_id != value))
			{
				this.Onuser_idChanging(value);
				this.SendPropertyChanging();
				this._user_id = value;
				this.SendPropertyChanged("user_id");
				this.Onuser_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_name", DbType="VarChar(50)")]
	public string user_name
	{
		get
		{
			return this._user_name;
		}
		set
		{
			if ((this._user_name != value))
			{
				this.Onuser_nameChanging(value);
				this.SendPropertyChanging();
				this._user_name = value;
				this.SendPropertyChanged("user_name");
				this.Onuser_nameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_firstname", DbType="VarChar(50)")]
	public string user_firstname
	{
		get
		{
			return this._user_firstname;
		}
		set
		{
			if ((this._user_firstname != value))
			{
				this.Onuser_firstnameChanging(value);
				this.SendPropertyChanging();
				this._user_firstname = value;
				this.SendPropertyChanged("user_firstname");
				this.Onuser_firstnameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_twitter", DbType="VarChar(50)")]
	public string user_twitter
	{
		get
		{
			return this._user_twitter;
		}
		set
		{
			if ((this._user_twitter != value))
			{
				this.Onuser_twitterChanging(value);
				this.SendPropertyChanging();
				this._user_twitter = value;
				this.SendPropertyChanged("user_twitter");
				this.Onuser_twitterChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_imagehash", DbType="VarChar(MAX)")]
	public string user_imagehash
	{
		get
		{
			return this._user_imagehash;
		}
		set
		{
			if ((this._user_imagehash != value))
			{
				this.Onuser_imagehashChanging(value);
				this.SendPropertyChanging();
				this._user_imagehash = value;
				this.SendPropertyChanged("user_imagehash");
				this.Onuser_imagehashChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="gym_user_gym_checkin", Storage="_gym_checkins", ThisKey="user_id", OtherKey="checkin_userid")]
	public EntitySet<gym_checkin> gym_checkins
	{
		get
		{
			return this._gym_checkins;
		}
		set
		{
			this._gym_checkins.Assign(value);
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
	
	private void attach_gym_checkins(gym_checkin entity)
	{
		this.SendPropertyChanging();
		entity.gym_user = this;
	}
	
	private void detach_gym_checkins(gym_checkin entity)
	{
		this.SendPropertyChanging();
		entity.gym_user = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_checkin")]
public partial class tbl_checkin : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _checkin_id;
	
	private System.Nullable<int> _fk_user_id;
	
	private System.Nullable<System.DateTime> _checkin_datetime;
	
	private EntityRef<tbl_user> _tbl_user;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Oncheckin_idChanging(int value);
    partial void Oncheckin_idChanged();
    partial void Onfk_user_idChanging(System.Nullable<int> value);
    partial void Onfk_user_idChanged();
    partial void Oncheckin_datetimeChanging(System.Nullable<System.DateTime> value);
    partial void Oncheckin_datetimeChanged();
    #endregion
	
	public tbl_checkin()
	{
		this._tbl_user = default(EntityRef<tbl_user>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_checkin_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int checkin_id
	{
		get
		{
			return this._checkin_id;
		}
		set
		{
			if ((this._checkin_id != value))
			{
				this.Oncheckin_idChanging(value);
				this.SendPropertyChanging();
				this._checkin_id = value;
				this.SendPropertyChanged("checkin_id");
				this.Oncheckin_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fk_user_id", DbType="Int")]
	public System.Nullable<int> fk_user_id
	{
		get
		{
			return this._fk_user_id;
		}
		set
		{
			if ((this._fk_user_id != value))
			{
				if (this._tbl_user.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.Onfk_user_idChanging(value);
				this.SendPropertyChanging();
				this._fk_user_id = value;
				this.SendPropertyChanged("fk_user_id");
				this.Onfk_user_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_checkin_datetime", DbType="DateTime2")]
	public System.Nullable<System.DateTime> checkin_datetime
	{
		get
		{
			return this._checkin_datetime;
		}
		set
		{
			if ((this._checkin_datetime != value))
			{
				this.Oncheckin_datetimeChanging(value);
				this.SendPropertyChanging();
				this._checkin_datetime = value;
				this.SendPropertyChanged("checkin_datetime");
				this.Oncheckin_datetimeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_user_tbl_checkin", Storage="_tbl_user", ThisKey="fk_user_id", OtherKey="user_id", IsForeignKey=true)]
	public tbl_user tbl_user
	{
		get
		{
			return this._tbl_user.Entity;
		}
		set
		{
			tbl_user previousValue = this._tbl_user.Entity;
			if (((previousValue != value) 
						|| (this._tbl_user.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._tbl_user.Entity = null;
					previousValue.tbl_checkins.Remove(this);
				}
				this._tbl_user.Entity = value;
				if ((value != null))
				{
					value.tbl_checkins.Add(this);
					this._fk_user_id = value.user_id;
				}
				else
				{
					this._fk_user_id = default(Nullable<int>);
				}
				this.SendPropertyChanged("tbl_user");
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_functions")]
public partial class tbl_function : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _function_id;
	
	private string _function_name;
	
	private EntitySet<tbl_user> _tbl_users;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onfunction_idChanging(int value);
    partial void Onfunction_idChanged();
    partial void Onfunction_nameChanging(string value);
    partial void Onfunction_nameChanged();
    #endregion
	
	public tbl_function()
	{
		this._tbl_users = new EntitySet<tbl_user>(new Action<tbl_user>(this.attach_tbl_users), new Action<tbl_user>(this.detach_tbl_users));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_function_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int function_id
	{
		get
		{
			return this._function_id;
		}
		set
		{
			if ((this._function_id != value))
			{
				this.Onfunction_idChanging(value);
				this.SendPropertyChanging();
				this._function_id = value;
				this.SendPropertyChanged("function_id");
				this.Onfunction_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_function_name", DbType="VarChar(50)")]
	public string function_name
	{
		get
		{
			return this._function_name;
		}
		set
		{
			if ((this._function_name != value))
			{
				this.Onfunction_nameChanging(value);
				this.SendPropertyChanging();
				this._function_name = value;
				this.SendPropertyChanged("function_name");
				this.Onfunction_nameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_function_tbl_user", Storage="_tbl_users", ThisKey="function_id", OtherKey="fk_function_id")]
	public EntitySet<tbl_user> tbl_users
	{
		get
		{
			return this._tbl_users;
		}
		set
		{
			this._tbl_users.Assign(value);
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
	
	private void attach_tbl_users(tbl_user entity)
	{
		this.SendPropertyChanging();
		entity.tbl_function = this;
	}
	
	private void detach_tbl_users(tbl_user entity)
	{
		this.SendPropertyChanging();
		entity.tbl_function = null;
	}
}
#pragma warning restore 1591
