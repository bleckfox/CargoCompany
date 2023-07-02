using InfrastructureService.Entities.BaseEntities;

namespace InfrastructureService.Entities.DeliveryEntities;

/// <summary>
/// Склад
/// </summary>
public class Storage : BaseEntity
{
    /// <summary>
    /// Наименование
    /// </summary>
    public string Name { get; set; } = null!;
    
    /// <summary>
    /// Почтовый индекс
    /// </summary>
    public string PostCode { get; set; } = null!;
}