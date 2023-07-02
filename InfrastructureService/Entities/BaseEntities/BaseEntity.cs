using System.ComponentModel.DataAnnotations;

namespace InfrastructureService.Entities.BaseEntities;

/// <summary>
/// Базовый класс сущности с Id - первичным ключом
/// </summary>
public class BaseEntity
{
    /// <summary>
    /// Идентификатор (Guid)
    /// </summary>
    [Key]
    public int Id { get; set; }
}
