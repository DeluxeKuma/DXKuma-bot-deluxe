using System.Text.Json.Serialization;

namespace DXKumaBot.Response.Lxns;

public class LxnsAlias
{
    [JsonPropertyName("song_id")] public int SongId { get; set; }

    [JsonPropertyName("aliases")] public string[]? Aliases { get; set; }
}