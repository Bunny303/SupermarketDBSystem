#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using SupermarketModelMySql;

namespace SupermarketModelMySql	
{
	[Table("products")]
	[ConcurrencyControl(OptimisticConcurrencyControlStrategy.Changed)]
	[KeyGenerator(KeyGenerator.Autoinc)]
	public partial class Product
	{
		private int productID;
		[Column("ProductID", OpenAccessType = OpenAccessType.Int32, IsBackendCalculated = true, IsPrimaryKey = true, Length = 0, Scale = 0, SqlType = "integer")]
		[Storage("productID")]
		public virtual int ProductID
		{
			get
			{
				return this.productID;
			}
			set
			{
				this.productID = value;
			}
		}
		
		private int? vendorID;
		[Column("VendorID", OpenAccessType = OpenAccessType.Int32, IsNullable = true, Length = 0, Scale = 0, SqlType = "integer")]
		[Storage("vendorID")]
		public virtual int? VendorID
		{
			get
			{
				return this.vendorID;
			}
			set
			{
				this.vendorID = value;
			}
		}
		
		private int? measureID;
		[Column("MeasureID", OpenAccessType = OpenAccessType.Int32, IsNullable = true, Length = 0, Scale = 0, SqlType = "integer")]
		[Storage("measureID")]
		public virtual int? MeasureID
		{
			get
			{
				return this.measureID;
			}
			set
			{
				this.measureID = value;
			}
		}
		
		private string productName;
		[Column("Product Name", OpenAccessType = OpenAccessType.UnicodeStringVariableLength, Length = 45, Scale = 0, SqlType = "nvarchar")]
		[Storage("productName")]
		public virtual string ProductName
		{
			get
			{
				return this.productName;
			}
			set
			{
				this.productName = value;
			}
		}
		
		private long basePrice;
		[Column("Base Price", OpenAccessType = OpenAccessType.Decimal, Length = 10, Scale = 0, SqlType = "decimal")]
		[Storage("basePrice")]
		public virtual long BasePrice
		{
			get
			{
				return this.basePrice;
			}
			set
			{
				this.basePrice = value;
			}
		}
		
		private Measure measure;
		[ForeignKeyAssociation(ConstraintName = "MeasureID", SharedFields = "MeasureID", TargetFields = "MeasureID")]
		[Storage("measure")]
		public virtual Measure Measure
		{
			get
			{
				return this.measure;
			}
			set
			{
				this.measure = value;
			}
		}
		
		private Vendor vendor;
		[ForeignKeyAssociation(ConstraintName = "VendorID", SharedFields = "VendorID", TargetFields = "VendorID")]
		[Storage("vendor")]
		public virtual Vendor Vendor
		{
			get
			{
				return this.vendor;
			}
			set
			{
				this.vendor = value;
			}
		}
		
	}
}
#pragma warning restore 1591
