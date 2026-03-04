using System.Text.Json.Serialization;

namespace DLPulse.Model;

public class VideoMetadata
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    [JsonPropertyName("title")]
    public required string Title { get; set; }
    [JsonPropertyName("formats")]
    public required List<Format> Formats { get; set; }
    [JsonPropertyName("channel_id")]
    public required string ChannelId { get; set; }

    public override string ToString()
    {
        var formatsString = Formats != null && Formats.Count > 0
            ? string.Join("\n", Formats.Select(f => $"  - {f}"))
            : "  (none)";
        return $"Id: {Id}\nTitle: {Title}\nChannelId: {ChannelId}\nFormats ({Formats?.Count ?? 0}):\n{formatsString}";
    }
}
