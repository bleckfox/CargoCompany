namespace InfrastructureService.Entities.BaseEntities;

/// <summary>
/// Базовый класс сущности отправки/доставки
/// </summary>
public class BaseDeliveryEntity : BaseEntity
{
    /// <summary>
    /// Наименование
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Код в международной системе
    /// </summary>
    public string Code { get; set; } = null!;
}