using InfrastructureService.Entities.BaseEntities;
using InfrastructureService.Entities.DeliveryEntities;

namespace InfrastructureService.Entities.ShipmentEntities;

/// <summary>
/// Контейнер
/// </summary>
public class Container : BaseEntity
{
    /// <summary>
    /// Номер контейнера
    /// </summary>
    public string ContainerNumber { get; set; } = null!;
    
    /// <summary>
    /// Тип контейнера
    /// </summary>
    public string ContainerType { get; set; } = null!;
    
    /// <summary>
    /// Линия
    /// </summary>
    public string CurrentLine { get; set; } = null!;

    /// <summary>
    /// Склад хранения
    /// </summary>
    public Storage StorageInfo { get; set; } = null!;
    
    /// <summary>
    /// Место отправки
    /// </summary>
    public Location DepartureLocation { get; set; } = null!;
    
    /// <summary>
    /// Страна отправки
    /// </summary>
    public Country DepartureCountry { get; set; } = null!;
    
    /// <summary>
    /// Место доставки
    /// </summary>
    public Location DestinationLocation { get; set; } = null!;
    
    /// <summary>
    /// Страна доставки
    /// </summary>
    public Country DestinationCountry { get; set; } = null!;

    /// <summary>
    /// Список продуктов/товаров
    /// </summary>
    public List<Product> Products { get; set; } = null!;
}