using DLPulse.Model;
using System.Text.Json;

namespace DLPulse.Settings;

internal class SingleDownloadPageSettings
{
    public string? URLText { get; set; }
    public VideoMetadata? LastFetchedMetadata { get; set; }

    private static string GetSettingsPath()
    {
        string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string dir = Path.Combine(appData, "DLPulse");
        if (!Directory.Exists(dir))
            Directory.CreateDirectory(dir);
        return Path.Combine(dir, "singleDownloadPageSettings.json");
    }

    public void Load()
    {
        string path = GetSettingsPath();
        if (File.Exists(path))
        {
            var json = File.ReadAllText(path);
            var loaded = JsonSerializer.Deserialize<SingleDownloadPageSettings>(json);
            if (loaded != null)
            {
                URLText = loaded.URLText;
                LastFetchedMetadata = loaded.LastFetchedMetadata;
            }
        }
    }

    public void Save()
    {
        string path = GetSettingsPath();
        var json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(path, json);
    }
}
