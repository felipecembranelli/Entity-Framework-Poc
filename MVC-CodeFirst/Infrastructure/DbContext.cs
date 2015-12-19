using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CodeFirst.Infrastructure
{
    using Models;
    using Models.Mapping;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class SampleContext : DbContext
    {
        public SampleContext(string connectionString)
            : base(connectionString)
        {
        }

        /// <summary>
        /// Map the EF context
        /// </summary>
        /// <param name="modelBuilder">Object to map EF model</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder..RegisterBaseEntityProperties();
            this.AddAdditionalConfigurations(modelBuilder);
        }

        /// <summary>
        /// Map the EF context
        /// </summary>
        /// <param name="modelBuilder">Object to map EF model</param>
        protected void AddAdditionalConfigurations(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AddressMap());
            modelBuilder.Configurations.Add(new AWBuildVersionMap());
            modelBuilder.Configurations.Add(new DatabaseLogMap());
            modelBuilder.Configurations.Add(new ErrorLogMap());
            modelBuilder.Configurations.Add(new DepartmentMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new EmployeeDepartmentHistoryMap());
            modelBuilder.Configurations.Add(new EmployeePayHistoryMap());
            modelBuilder.Configurations.Add(new JobCandidateMap());
            modelBuilder.Configurations.Add(new ShiftMap());
            modelBuilder.Configurations.Add(new AddressTypeMap());
            modelBuilder.Configurations.Add(new BillOfMaterialMap());
            modelBuilder.Configurations.Add(new BusinessEntityMap());
            modelBuilder.Configurations.Add(new BusinessEntityAddressMap());
            modelBuilder.Configurations.Add(new BusinessEntityContactMap());
            modelBuilder.Configurations.Add(new ContactTypeMap());
            modelBuilder.Configurations.Add(new CountryRegionMap());
            modelBuilder.Configurations.Add(new EmailAddressMap());
            modelBuilder.Configurations.Add(new PasswordMap());
            modelBuilder.Configurations.Add(new PersonMap());
            modelBuilder.Configurations.Add(new PersonPhoneMap());
            modelBuilder.Configurations.Add(new PhoneNumberTypeMap());
            modelBuilder.Configurations.Add(new StateProvinceMap());
            modelBuilder.Configurations.Add(new CultureMap());
            modelBuilder.Configurations.Add(new IllustrationMap());
            modelBuilder.Configurations.Add(new LocationMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new ProductCategoryMap());
            modelBuilder.Configurations.Add(new ProductCostHistoryMap());
            modelBuilder.Configurations.Add(new ProductDescriptionMap());
            modelBuilder.Configurations.Add(new ProductInventoryMap());
            modelBuilder.Configurations.Add(new ProductListPriceHistoryMap());
            modelBuilder.Configurations.Add(new ProductModelMap());
            modelBuilder.Configurations.Add(new ProductModelIllustrationMap());
            modelBuilder.Configurations.Add(new ProductModelProductDescriptionCultureMap());
            modelBuilder.Configurations.Add(new ProductPhotoMap());
            modelBuilder.Configurations.Add(new ProductProductPhotoMap());
            modelBuilder.Configurations.Add(new ProductReviewMap());
            modelBuilder.Configurations.Add(new ProductSubcategoryMap());
            modelBuilder.Configurations.Add(new ScrapReasonMap());
            modelBuilder.Configurations.Add(new TransactionHistoryMap());
            modelBuilder.Configurations.Add(new TransactionHistoryArchiveMap());
            modelBuilder.Configurations.Add(new UnitMeasureMap());
            modelBuilder.Configurations.Add(new WorkOrderMap());
            modelBuilder.Configurations.Add(new WorkOrderRoutingMap());
            modelBuilder.Configurations.Add(new ProductVendorMap());
            modelBuilder.Configurations.Add(new PurchaseOrderDetailMap());
            modelBuilder.Configurations.Add(new PurchaseOrderHeaderMap());
            modelBuilder.Configurations.Add(new ShipMethodMap());
            modelBuilder.Configurations.Add(new VendorMap());
            modelBuilder.Configurations.Add(new CountryRegionCurrencyMap());
            modelBuilder.Configurations.Add(new CreditCardMap());
            modelBuilder.Configurations.Add(new CurrencyMap());
            modelBuilder.Configurations.Add(new CurrencyRateMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new PersonCreditCardMap());
            modelBuilder.Configurations.Add(new SalesOrderDetailMap());
            modelBuilder.Configurations.Add(new SalesOrderHeaderMap());
            modelBuilder.Configurations.Add(new SalesOrderHeaderSalesReasonMap());
            modelBuilder.Configurations.Add(new SalesPersonMap());
            modelBuilder.Configurations.Add(new SalesPersonQuotaHistoryMap());
            modelBuilder.Configurations.Add(new SalesReasonMap());
            modelBuilder.Configurations.Add(new SalesTaxRateMap());
            modelBuilder.Configurations.Add(new SalesTerritoryMap());
            modelBuilder.Configurations.Add(new SalesTerritoryHistoryMap());
            modelBuilder.Configurations.Add(new ShoppingCartItemMap());
            modelBuilder.Configurations.Add(new SpecialOfferMap());
            modelBuilder.Configurations.Add(new SpecialOfferProductMap());
            modelBuilder.Configurations.Add(new StoreMap());

        }


        public virtual DbSet<AWBuildVersion> AWBuildVersion { get; set; }
        public virtual DbSet<DatabaseLog> DatabaseLog { get; set; }
        public virtual DbSet<ErrorLog> ErrorLog { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; }
        public virtual DbSet<EmployeePayHistory> EmployeePayHistory { get; set; }
        public virtual DbSet<JobCandidate> JobCandidate { get; set; }
        public virtual DbSet<Shift> Shift { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AddressType> AddressType { get; set; }
        public virtual DbSet<BusinessEntity> BusinessEntity { get; set; }
        public virtual DbSet<BusinessEntityAddress> BusinessEntityAddress { get; set; }
        public virtual DbSet<BusinessEntityContact> BusinessEntityContact { get; set; }
        public virtual DbSet<ContactType> ContactType { get; set; }
        public virtual DbSet<CountryRegion> CountryRegion { get; set; }
        public virtual DbSet<EmailAddress> EmailAddress { get; set; }
        public virtual DbSet<Password> Password { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<PersonPhone> PersonPhone { get; set; }
        public virtual DbSet<PhoneNumberType> PhoneNumberType { get; set; }
        public virtual DbSet<StateProvince> StateProvince { get; set; }
        public virtual DbSet<Culture> Culture { get; set; }
        public virtual DbSet<Illustration> Illustration { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductCategory> ProductCategory { get; set; }
        public virtual DbSet<ProductCostHistory> ProductCostHistory { get; set; }
        public virtual DbSet<ProductDescription> ProductDescription { get; set; }
        public virtual DbSet<ProductInventory> ProductInventory { get; set; }
        public virtual DbSet<ProductListPriceHistory> ProductListPriceHistory { get; set; }
        public virtual DbSet<ProductModel> ProductModel { get; set; }
        public virtual DbSet<ProductModelIllustration> ProductModelIllustration { get; set; }
        public virtual DbSet<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCulture { get; set; }
        public virtual DbSet<ProductPhoto> ProductPhoto { get; set; }
        public virtual DbSet<ProductProductPhoto> ProductProductPhoto { get; set; }
        public virtual DbSet<ProductReview> ProductReview { get; set; }
        public virtual DbSet<ProductSubcategory> ProductSubcategory { get; set; }
        public virtual DbSet<ScrapReason> ScrapReason { get; set; }
        public virtual DbSet<TransactionHistory> TransactionHistory { get; set; }
        public virtual DbSet<TransactionHistoryArchive> TransactionHistoryArchive { get; set; }
        public virtual DbSet<UnitMeasure> UnitMeasure { get; set; }
        public virtual DbSet<WorkOrder> WorkOrder { get; set; }
        public virtual DbSet<WorkOrderRouting> WorkOrderRouting { get; set; }
        public virtual DbSet<ProductVendor> ProductVendor { get; set; }
        public virtual DbSet<PurchaseOrderDetail> PurchaseOrderDetail { get; set; }
        public virtual DbSet<PurchaseOrderHeader> PurchaseOrderHeader { get; set; }
        public virtual DbSet<ShipMethod> ShipMethod { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }
        public virtual DbSet<CountryRegionCurrency> CountryRegionCurrency { get; set; }
        public virtual DbSet<CreditCard> CreditCard { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<CurrencyRate> CurrencyRate { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<PersonCreditCard> PersonCreditCard { get; set; }
        public virtual DbSet<SalesOrderDetail> SalesOrderDetail { get; set; }
        public virtual DbSet<SalesOrderHeader> SalesOrderHeader { get; set; }
        public virtual DbSet<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReason { get; set; }
        public virtual DbSet<SalesPerson> SalesPerson { get; set; }
        public virtual DbSet<SalesPersonQuotaHistory> SalesPersonQuotaHistory { get; set; }
        public virtual DbSet<SalesReason> SalesReason { get; set; }
        public virtual DbSet<SalesTaxRate> SalesTaxRate { get; set; }
        public virtual DbSet<SalesTerritory> SalesTerritory { get; set; }
        public virtual DbSet<SalesTerritoryHistory> SalesTerritoryHistory { get; set; }
        public virtual DbSet<ShoppingCartItem> ShoppingCartItem { get; set; }
        public virtual DbSet<SpecialOffer> SpecialOffer { get; set; }
        public virtual DbSet<SpecialOfferProduct> SpecialOfferProduct { get; set; }
        public virtual DbSet<Store> Store { get; set; }
    }
}
