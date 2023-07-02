using InfrastructureService.AppEnvironment;
using InfrastructureService.Entities.CompanyEntities;
using InfrastructureService.Entities.DeliveryEntities;
using InfrastructureService.Entities.ShipmentEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DatabaseService.Context;

/// <summary>
/// Контекст базы данных
/// </summary>
public class ApplicationContext : DbContext
{
    /// <summary>
    /// Таблица агентов
    /// </summary>
    public DbSet<Agent> Agents { get; set; } = null!;

    /// <summary>
    /// Таблица брокеров
    /// </summary>
    public DbSet<Broker> Brokers { get; set; } = null!;

    /// <summary>
    /// Таблица клиентов
    /// </summary>
    public DbSet<Client> Clients { get; set; } = null!;

    /// <summary>
    /// Таблица экспедиторов
    /// </summary>
    public DbSet<Expediter> Expediters { get; set; } = null!;

    /// <summary>
    /// Таблица получателей
    /// </summary>
    public DbSet<Recipient> Recipients { get; set; } = null!;

    /// <summary>
    /// Таблица поставщиков
    /// </summary>
    public DbSet<Supplier> Suppliers { get; set; } = null!;

    /// <summary>
    /// Таблица точек прибытия
    /// </summary>
    public DbSet<ArrivalPoint> ArrivalPoints { get; set; } = null!;

    /// <summary>
    /// Таблица стран
    /// </summary>
    public DbSet<Country> Countries { get; set; } = null!;

    /// <summary>
    /// Таблица таможенных постов
    /// </summary>
    public DbSet<CustomHouse> CustomHouses { get; set; } = null!;

    /// <summary>
    /// Таблица местоположений
    /// </summary>
    public DbSet<Location> Locations { get; set; } = null!;

    /// <summary>
    /// Таблица хранилищ
    /// </summary>
    public DbSet<Storage> Storages { get; set; } = null!;

    /// <summary>
    /// Таблица контейнеров
    /// </summary>
    public DbSet<Container> Containers { get; set; } = null!;

    /// <summary>
    /// Таблица заказов
    /// </summary>
    public DbSet<Order> Orders { get; set; } = null!;

    /// <summary>
    /// Таблица продуктов
    /// </summary>
    public DbSet<Product> Products { get; set; } = null!;

    /// <summary>
    /// Таблица грузоперевозок
    /// </summary>
    public DbSet<Shipment> Shipments { get; set; } = null!;

    /// <summary>
    /// Таблица деталей грузоперевозок
    /// </summary>
    public DbSet<ShipmentDetail> ShipmentDetails { get; set; } = null!;

    /// <summary>
    /// Таблица документов грузоперевозок
    /// </summary>
    public DbSet<ShipmentDocument> ShipmentDocuments { get; set; } = null!;

    /// <summary>
    /// Настройки приложения
    /// </summary>
    private readonly AppSettings _appSettings;

    public ApplicationContext(IOptions<AppSettings> appSettingsOptions)
    {
        // Например для проекта web api, через application.json и инъекцию зависимостей можно
        // задать строку подключения
        _appSettings = appSettingsOptions.Value;
        Database.Migrate();
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_appSettings.DefaultConnectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        CompanyModelBuilder(modelBuilder);
        DeliveryModelBuilder(modelBuilder);
        ShipmentModelBuilder(modelBuilder);

        base.OnModelCreating(modelBuilder);
    }

    private void CompanyModelBuilder(ModelBuilder builder)
    {
        builder.Entity<Agent>(entity =>
        {
            entity.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.ContactPerson)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.Address)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.Phone)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(255);
        });
        
        builder.Entity<Broker>(entity =>
        {
            entity.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.ContactPerson)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.Address)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.Phone)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(255);
        });
        
        builder.Entity<Client>(entity =>
        {
            entity.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.ContactPerson)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.Address)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.Phone)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(255);
        });
        
        builder.Entity<Expediter>(entity =>
        {
            entity.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.ContactPerson)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.Address)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.Phone)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(255);
        });
        
        builder.Entity<Recipient>(entity =>
        {
            entity.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.ContactPerson)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.Address)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.Phone)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(255);
        });
        
        builder.Entity<Supplier>(entity =>
        {
            entity.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.ContactPerson)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.Address)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.Phone)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(255);
        });
    }
    
    
    private void DeliveryModelBuilder(ModelBuilder builder)
    {
        builder.Entity<ArrivalPoint>(entity =>
        {
            entity.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.Code)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.PointType)
                .IsRequired()
                .HasMaxLength(255);
        });
        
        builder.Entity<Country>(entity => {
            entity.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.Code)
                .IsRequired()
                .HasMaxLength(255);
        });
        
        builder.Entity<Country>()
            .HasMany(c => c.Locations)
            .WithOne()
            .HasForeignKey(l => l.Id);

        builder.Entity<Country>()
            .HasMany(c => c.CustomHouses)
            .WithOne()
            .HasForeignKey(c => c.Id);
            
        
        builder.Entity<CustomHouse>(entity => {
            entity.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.Code)
                .IsRequired()
                .HasMaxLength(255);

            entity.Property(p => p.DeclarationNumber)
                .IsRequired()
                .HasMaxLength(255);
        });
        
        builder.Entity<Location>(entity => {
            entity.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.Code)
                .IsRequired()
                .HasMaxLength(255);

            entity.Property(p => p.PostCode)
                .IsRequired()
                .HasMaxLength(255);
        });

        builder.Entity<Location>()
            .HasMany(l => l.ArrivalPoints)
            .WithOne()
            .HasForeignKey(a => a.Id);

        builder.Entity<Location>()
            .HasMany(l => l.Storages)
            .WithOne()
            .HasForeignKey(s => s.Id);
        
        
        builder.Entity<Storage>(entity => {
            entity.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.PostCode)
                .IsRequired()
                .HasMaxLength(255);
        });
        
        builder.Entity<Storage>()
            .HasMany(s => s.Containers)
            .WithOne()
            .HasForeignKey(c => c.Id);
    }
    
    private void ShipmentModelBuilder(ModelBuilder builder)
    {
        builder.Entity<Container>(entity => {
            entity.Property(p => p.ContainerNumber)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.ContainerType)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.CurrentLine)
                .IsRequired()
                .HasMaxLength(255);
        });
        builder.Entity<Container>()
            .HasMany(c => c.Products)
            .WithOne()
            .HasForeignKey(p => p.Id);
        
        
        builder.Entity<Order>(entity => {
            entity.Property(p => p.OrderNumber)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.InvoiceNumber)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.DeliveryCondition)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.SpecialLoadingConditions)
                .IsRequired()
                .HasMaxLength(255);

            entity.Property(p => p.Volume)
                .IsRequired();

            entity.Property(p => p.Cost)
                .IsRequired();
        });
        builder.Entity<Order>()
            .HasMany(o => o.Containers)
            .WithOne()
            .HasForeignKey(c => c.Id);
        
        
        builder.Entity<Product>(entity =>
        {
            entity.Property(p => p.ProductName)
                .IsRequired()
                .HasMaxLength(255);

            entity.Property(p => p.ProductNumber)
                .IsRequired();
            
            entity.Property(p => p.GrossWeight)
                .IsRequired();
            
            entity.Property(p => p.Cost)
                .IsRequired();
        });
        
        builder.Entity<Shipment>()
            .HasOne(s => s.Agent)
            .WithOne()
            .HasForeignKey<Agent>(a => a.Id);
        
        builder.Entity<Shipment>()
            .HasOne(s => s.Broker)
            .WithOne()
            .HasForeignKey<Broker>(a => a.Id);
        
        builder.Entity<Shipment>()
            .HasOne(s => s.Client)
            .WithOne()
            .HasForeignKey<Client>(a => a.Id);
        
        builder.Entity<Shipment>()
            .HasOne(s => s.Expediter)
            .WithOne()
            .HasForeignKey<Expediter>(a => a.Id);
        
        builder.Entity<Shipment>()
            .HasOne(s => s.Recipient)
            .WithOne()
            .HasForeignKey<Recipient>(a => a.Id);
        
        builder.Entity<Shipment>()
            .HasOne(s => s.Supplier)
            .WithOne()
            .HasForeignKey<Supplier>(a => a.Id);
        
        builder.Entity<Shipment>()
            .HasOne(s => s.Order)
            .WithOne()
            .HasForeignKey<Order>(a => a.Id);
        
        builder.Entity<Shipment>()
            .HasOne(s => s.ShipmentDetail)
            .WithOne()
            .HasForeignKey<ShipmentDetail>(a => a.Id);
        
        builder.Entity<Shipment>()
            .HasOne(s => s.ShipmentDocument)
            .WithOne()
            .HasForeignKey<ShipmentDocument>(a => a.Id);
        
        
        builder.Entity<ShipmentDetail>(entity => {
            entity.Property(p => p.Note)
                .IsRequired();
        });
        
        builder.Entity<ShipmentDetail>()
            .HasOne(s => s.Shipment)
            .WithOne(s => s.ShipmentDetail)
            .HasForeignKey<Shipment>(s => s.Id);
        
        builder.Entity<ShipmentDetail>()
            .HasMany(s => s.ArrivalPoints)
            .WithOne()
            .HasForeignKey(a => a.Id);
        
        
        builder.Entity<ShipmentDocument>(entity => {
            entity.Property(p => p.BillOfLading)
                .IsRequired()
                .HasMaxLength(255);
            
            entity.Property(p => p.CommercialDocumentPreparation)
                .IsRequired()
                .HasMaxLength(255);
        });
        
        builder.Entity<ShipmentDocument>()
            .HasOne(s => s.Shipment)
            .WithOne(s => s.ShipmentDocument)
            .HasForeignKey<Shipment>(s => s.Id);
    }
}