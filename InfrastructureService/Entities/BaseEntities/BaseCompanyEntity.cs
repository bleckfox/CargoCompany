namespace InfrastructureService.Entities.BaseEntities;

/// <summary>
/// Базовый класс сущности компаний
/// </summary>
public class BaseCompanyEntity : BaseEntity
{
    /// <summary>
    /// Название компании
    /// </summary>
    public string Name { get; set; } = null!;
    
    /// <summary>
    /// Контактное лицо
    /// </summary>
    public string ContactPerson { get; set; } = null!;
    
    /// <summary>
    /// Адрес
    /// </summary>
    public string Address { get; set; } = null!;
    
    /// <summary>
    /// Телефон
    /// </summary>
    public string Phone { get; set; } = null!;
    
    /// <summary>
    /// Электронная почта
    /// </summary>
    public string Email { get; set; } = null!;
}