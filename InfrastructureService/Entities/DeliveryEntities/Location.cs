using InfrastructureService.Entities.BaseEntities;

namespace InfrastructureService.Entities.DeliveryEntities;

/// <summary>
/// Место (город) отправки / доставки
/// </summary>
public class Location : BaseDeliveryEntity
{
    /// <summary>
    /// Почтовый индекс
    /// </summary>
    public string PostCode { get; set; } = null!;
}