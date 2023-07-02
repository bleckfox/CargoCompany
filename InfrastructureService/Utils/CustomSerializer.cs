using System.Text.Json;

namespace InfrastructureService.Utils;

/// <summary>
/// Кастомный де/сериализатор json
/// </summary>
public class CustomSerializer
{
    private static JsonSerializerOptions Options => 
        new JsonSerializerOptions()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

    public static string Serialize<T>(T obj) where T : class
    {
        return JsonSerializer.Serialize(obj, Options);
    }

    public static T? Deserialize<T>(string json) where T : class
    {
        return JsonSerializer.Deserialize<T>(json);
    }
}