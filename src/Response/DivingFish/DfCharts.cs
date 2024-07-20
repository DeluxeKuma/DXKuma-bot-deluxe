using System.Text.Json.Serialization;

namespace DXKumaBot.Response.DivingFish;

public class DfCharts
{
    [JsonPropertyName("dx")] public DfScore[]? Dx { get; set; }

    [JsonPropertyName("sd")] public DfScore[]? Standard { get; set; }
}