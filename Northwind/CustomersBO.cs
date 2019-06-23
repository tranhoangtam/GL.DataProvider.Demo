using System;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using Northwind.DataAccess;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using GL.DataProvider;

namespace Northwind.BusinessObjects
{
	/// <summary>
	/// Project's generated by SQL CSharp .Net
	/// Generated Class for Table : Customers.
	/// Date: 19/06/2019
	/// Author: Trần Hoàng Tâm
	/// Email: tranhoangtam@gmail.com 
	/// </summary>
	[DataContract]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "Northwind.BusinessObjects")]
	public partial class Customers:BusinessObject
	{
		#region Field
		private string m_CustomerID;
		private string m_CompanyName;
		private string m_ContactName;
		private string m_ContactTitle;
		private string m_Address;
		private string m_City;
		private string m_Region;
		private string m_PostalCode;
		private string m_Country;
		private string m_Phone;
		private string m_Fax;
		
		
		~Customers()
		{
		}

		public Customers()
		{
			State=States.Added;
		}
		public Customers(
			string customerid,
			string companyname,
			string contactname,
			string contacttitle,
			string address,
			string city,
			string region,
			string postalcode,
			string country,
			string phone,
			string fax)
		{
			 m_CustomerID=customerid;
			 m_CompanyName=companyname;
			 m_ContactName=contactname;
			 m_ContactTitle=contacttitle;
			 m_Address=address;
			 m_City=city;
			 m_Region=region;
			 m_PostalCode=postalcode;
			 m_Country=country;
			 m_Phone=phone;
			 m_Fax=fax;
			State=States.Added;
		}
		
		public Customers
		(
			Customers obj
		)
		{
			 m_CustomerID= obj.m_CustomerID;
			 m_CompanyName= obj.m_CompanyName;
			 m_ContactName= obj.m_ContactName;
			 m_ContactTitle= obj.m_ContactTitle;
			 m_Address= obj.m_Address;
			 m_City= obj.m_City;
			 m_Region= obj.m_Region;
			 m_PostalCode= obj.m_PostalCode;
			 m_Country= obj.m_Country;
			 m_Phone= obj.m_Phone;
			 m_Fax= obj.m_Fax;
			State=obj.State;
		}
		
		 [OperationContract]
		public object[] ToArray()
		{
			return new object[]
				{
					CustomerID,
					CompanyName,
					ContactName,
					ContactTitle,
					Address,
					City,
					Region,
					PostalCode,
					Country,
					Phone,
					Fax
				};
		}
		 [OperationContract]
		public DataTable ToData()
		{
			var dt=DesignTable();
			dt.Rows.Clear();
			var dr = dt.NewRow();
			dr["CustomerID"]=CustomerID;
			dr["CompanyName"]=CompanyName;
			dr["ContactName"]=ContactName;
			dr["ContactTitle"]=ContactTitle;
			dr["Address"]=Address;
			dr["City"]=City;
			dr["Region"]=Region;
			dr["PostalCode"]=PostalCode;
			dr["Country"]=Country;
			dr["Phone"]=Phone;
			dr["Fax"]=Fax;
			dt.Rows.Add(dr);
			return dt;
		}
		public static implicit operator Customers(DataRowView e)
		{
			if (e == null) return null;
			var dr = e.Row;
			return new  CustomersDA().MapObject(dr);
		}
		public static implicit operator Customers(DataRow e)
		{
			if (e == null) return null;
			return new  CustomersDA().MapObject(e);
		}
		public static List<Customers> ToList(DataTable dataTable)
		{
			if (dataTable == null) return new List<Customers>();
			return new CustomersDA().MapObject(dataTable);
		}
		#endregion
		
		#region Event
		public event PropertyChangedEventHandler PropertyChanged;
		protected void OnPropertyChanged(string name)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null)
			{
				handler(this, new PropertyChangedEventArgs(name));
			}
		}
		#endregion
		
		#region Property
		[DataMember]
		[DisplayName(@"CustomerID")]
		[Category("Column")]
		public string CustomerID
		{
			get
			{
				return m_CustomerID;
			}
			set
			{
				if (m_CustomerID != value)
				{
					m_CustomerID= value;
					OnPropertyChanged("CustomerID");
				}
			}
		}
		[DataMember]
		[DisplayName(@"CompanyName")]
		[Category("Column")]
		public string CompanyName
		{
			get
			{
				return m_CompanyName;
			}
			set
			{
				if (m_CompanyName != value)
				{
					m_CompanyName= value;
					OnPropertyChanged("CompanyName");
				}
			}
		}
		[DataMember]
		[DisplayName(@"ContactName")]
		[Category("Column")]
		public string ContactName
		{
			get
			{
				return m_ContactName;
			}
			set
			{
				if (m_ContactName != value)
				{
					m_ContactName= value;
					OnPropertyChanged("ContactName");
				}
			}
		}
		[DataMember]
		[DisplayName(@"ContactTitle")]
		[Category("Column")]
		public string ContactTitle
		{
			get
			{
				return m_ContactTitle;
			}
			set
			{
				if (m_ContactTitle != value)
				{
					m_ContactTitle= value;
					OnPropertyChanged("ContactTitle");
				}
			}
		}
		[DataMember]
		[DisplayName(@"Address")]
		[Category("Column")]
		public string Address
		{
			get
			{
				return m_Address;
			}
			set
			{
				if (m_Address != value)
				{
					m_Address= value;
					OnPropertyChanged("Address");
				}
			}
		}
		[DataMember]
		[DisplayName(@"City")]
		[Category("Column")]
		public string City
		{
			get
			{
				return m_City;
			}
			set
			{
				if (m_City != value)
				{
					m_City= value;
					OnPropertyChanged("City");
				}
			}
		}
		[DataMember]
		[DisplayName(@"Region")]
		[Category("Column")]
		public string Region
		{
			get
			{
				return m_Region;
			}
			set
			{
				if (m_Region != value)
				{
					m_Region= value;
					OnPropertyChanged("Region");
				}
			}
		}
		[DataMember]
		[DisplayName(@"PostalCode")]
		[Category("Column")]
		public string PostalCode
		{
			get
			{
				return m_PostalCode;
			}
			set
			{
				if (m_PostalCode != value)
				{
					m_PostalCode= value;
					OnPropertyChanged("PostalCode");
				}
			}
		}
		[DataMember]
		[DisplayName(@"Country")]
		[Category("Column")]
		public string Country
		{
			get
			{
				return m_Country;
			}
			set
			{
				if (m_Country != value)
				{
					m_Country= value;
					OnPropertyChanged("Country");
				}
			}
		}
		[DataMember]
		[DisplayName(@"Phone")]
		[Category("Column")]
		public string Phone
		{
			get
			{
				return m_Phone;
			}
			set
			{
				if (m_Phone != value)
				{
					m_Phone= value;
					OnPropertyChanged("Phone");
				}
			}
		}
		[DataMember]
		[DisplayName(@"Fax")]
		[Category("Column")]
		public string Fax
		{
			get
			{
				return m_Fax;
			}
			set
			{
				if (m_Fax != value)
				{
					m_Fax= value;
					OnPropertyChanged("Fax");
				}
			}
		}
		public DataTable DesignTable()
		{
			 var m_table = new DataTable("Customers");
			m_table.Columns.Add("CustomerID", typeof(string)).MaxLength=5;
			m_table.Columns.Add("CompanyName", typeof(string)).MaxLength=40;
			m_table.Columns.Add("ContactName", typeof(string)).MaxLength=30;
			m_table.Columns.Add("ContactTitle", typeof(string)).MaxLength=30;
			m_table.Columns.Add("Address", typeof(string)).MaxLength=60;
			m_table.Columns.Add("City", typeof(string)).MaxLength=15;
			m_table.Columns.Add("Region", typeof(string)).MaxLength=15;
			m_table.Columns.Add("PostalCode", typeof(string)).MaxLength=10;
			m_table.Columns.Add("Country", typeof(string)).MaxLength=15;
			m_table.Columns.Add("Phone", typeof(string)).MaxLength=24;
			m_table.Columns.Add("Fax", typeof(string)).MaxLength=24;
			m_table.Constraints.Add("PK_Customers", new DataColumn[]
			{
				m_table.Columns["CustomerID"],
			}, true);
			return m_table;
		}
		#endregion
		
	}

	#region Enum Fields

	public enum CustomersFields
		{
			CustomerID,
			CompanyName,
			ContactName,
			ContactTitle,
			Address,
			City,
			Region,
			PostalCode,
			Country,
			Phone,
			Fax,
			Lock,
			None
		}

	#endregion

}