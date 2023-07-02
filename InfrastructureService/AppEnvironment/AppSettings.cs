namespace InfrastructureService.AppEnvironment;

/// <summary>
/// Модель настроек приложения
/// </summary>
public class AppSettings
{
    /// <summary>
    /// Строка подключения к блогу
    /// </summary>
    public string DefaultConnectionString { get; set; } = null!;
}
