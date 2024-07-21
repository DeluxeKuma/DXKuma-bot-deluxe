using System.Text.Json.Serialization;

namespace DXKumaBot.Response.Lxns;

public class LxnsCollectionGenre
{
    [JsonPropertyName("id")] public int Id { get; set; }

    [JsonPropertyName("title")] public string? Title { get; set; }

    [JsonPropertyName("genre")] public string? Genre { get; set; }
}