using InfrastructureService.Entities.BaseEntities;

namespace InfrastructureService.Entities.DeliveryEntities;

/// <summary>
/// Таможенный пост
/// </summary>
public class CustomHouse : BaseDeliveryEntity
{
    /// <summary>
    /// Дата подачи декларации
    /// </summary>
    public DateTime FilingDeclarationDate { get; set; }
    
    /// <summary>
    /// Дата выпуска декларации
    /// </summary>
    public DateTime ReleaseDeclarationDate { get; set; }
    
    /// <summary>
    /// Номер декларации
    /// </summary>
    public string DeclarationNumber { get; set; } = null!;
    
    /// <summary>
    /// Место расположения
    /// </summary>
    public Location Location { get; set; } = null!;
}