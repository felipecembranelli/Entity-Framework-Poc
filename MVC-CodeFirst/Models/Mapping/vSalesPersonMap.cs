using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MVC_CodeFirst.Models.Mapping
{
    public class vSalesPersonMap : EntityTypeConfiguration<vSalesPerson>
    {
        public vSalesPersonMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BusinessEntityID, t.FirstName, t.LastName, t.JobTitle, t.EmailPromotion, t.AddressLine1, t.City, t.StateProvinceName, t.PostalCode, t.CountryRegionName, t.SalesYTD, t.SalesLastYear });

            // Properties
            this.Property(t => t.BusinessEntityID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Title)
                .HasMaxLength(8);

            this.Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MiddleName)
                .HasMaxLength(50);

            this.Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Suffix)
                .HasMaxLength(10);

            this.Property(t => t.JobTitle)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PhoneNumber)
                .HasMaxLength(25);

            this.Property(t => t.PhoneNumberType)
                .HasMaxLength(50);

            this.Property(t => t.EmailAddress)
                .HasMaxLength(50);

            this.Property(t => t.EmailPromotion)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AddressLine1)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.AddressLine2)
                .HasMaxLength(60);

            this.Property(t => t.City)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.StateProvinceName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PostalCode)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.CountryRegionName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TerritoryName)
                .HasMaxLength(50);

            this.Property(t => t.TerritoryGroup)
                .HasMaxLength(50);

            this.Property(t => t.SalesYTD)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SalesLastYear)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("vSalesPerson", "Sales");
            this.Property(t => t.BusinessEntityID).HasColumnName("BusinessEntityID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.MiddleName).HasColumnName("MiddleName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.Suffix).HasColumnName("Suffix");
            this.Property(t => t.JobTitle).HasColumnName("JobTitle");
            this.Property(t => t.PhoneNumber).HasColumnName("PhoneNumber");
            this.Property(t => t.PhoneNumberType).HasColumnName("PhoneNumberType");
            this.Property(t => t.EmailAddress).HasColumnName("EmailAddress");
            this.Property(t => t.EmailPromotion).HasColumnName("EmailPromotion");
            this.Property(t => t.AddressLine1).HasColumnName("AddressLine1");
            this.Property(t => t.AddressLine2).HasColumnName("AddressLine2");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.StateProvinceName).HasColumnName("StateProvinceName");
            this.Property(t => t.PostalCode).HasColumnName("PostalCode");
            this.Property(t => t.CountryRegionName).HasColumnName("CountryRegionName");
            this.Property(t => t.TerritoryName).HasColumnName("TerritoryName");
            this.Property(t => t.TerritoryGroup).HasColumnName("TerritoryGroup");
            this.Property(t => t.SalesQuota).HasColumnName("SalesQuota");
            this.Property(t => t.SalesYTD).HasColumnName("SalesYTD");
            this.Property(t => t.SalesLastYear).HasColumnName("SalesLastYear");
        }
    }
}