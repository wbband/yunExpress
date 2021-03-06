//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMS.Data.Context
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Infrastructure;
    
    using LMS.Data.Entity;
    
    
    internal partial class InStorageWeightDeviation_Mapping : EntityTypeConfiguration<InStorageWeightDeviation>
    {
        public InStorageWeightDeviation_Mapping()
        {                        
              this.HasKey(t => t.InStorageWeightDeviationID);        
              this.ToTable("InStorageWeightDeviations");
              this.Property(t => t.InStorageWeightDeviationID).HasColumnName("InStorageWeightDeviationID");
              this.Property(t => t.CustomerCode).HasColumnName("CustomerCode").HasMaxLength(20);
              this.Property(t => t.CustomerName).HasColumnName("CustomerName").HasMaxLength(128);
              this.Property(t => t.ShippingMethodID).HasColumnName("ShippingMethodID");
              this.Property(t => t.ShippingMethodName).HasColumnName("ShippingMethodName").HasMaxLength(100);
              this.Property(t => t.DeviationValue).HasColumnName("DeviationValue");
              this.Property(t => t.Status).HasColumnName("Status");
              this.Property(t => t.CreatedOn).HasColumnName("CreatedOn");
              this.Property(t => t.CreatedBy).HasColumnName("CreatedBy").HasMaxLength(50);
              this.Property(t => t.LastUpdatedOn).HasColumnName("LastUpdatedOn");
              this.Property(t => t.LastUpdatedBy).HasColumnName("LastUpdatedBy").HasMaxLength(50);
         }
    }
}
