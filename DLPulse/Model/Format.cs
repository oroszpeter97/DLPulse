namespace DLPulse.Model;

using System.Text.Json.Serialization;

public class Format
{
    [JsonPropertyName("asr")]
    public int? ASR { get; set; }
    [JsonPropertyName("format_id")]
    public required string FormatId { get; set; }
    [JsonPropertyName("ext")]
    public required string Extension { get; set; }
    [JsonPropertyName("acodec")]
    public required string ACodec { get; set; }
    [JsonPropertyName("vcodec")]
    public required string VCodec { get; set; }
    [JsonPropertyName("resolution")]
    public required string Resolution { get; set; }

    public override string ToString()
    {
        return $"FormatId: {FormatId}, Ext: {Extension}, Resolution: {Resolution}, ACodec: {ACodec}, VCodec: {VCodec}, ASR: {ASR?.ToString() ?? "N/A"}";
    }
}
