namespace Lab3;

public class UserProfile
{
    public string Settings { get; set; }

    public SettingsSnapshot Save()
    {
        return new SettingsSnapshotInstance(Settings);
    }

    public void Restore(SettingsSnapshot snapshot)
    {
        Settings = snapshot.Settings;
    }

    // Only UserProfile should be able to create settings snapshot. This service class used to access settings snapshot constructor.
    private class SettingsSnapshotInstance : SettingsSnapshot
    {
        public SettingsSnapshotInstance(string settings)
            : base(settings)
        {
        }
    }

    public void PrintCurrentSettings()
    {
        Console.WriteLine($"Current settings: {Settings}");
    }
}
