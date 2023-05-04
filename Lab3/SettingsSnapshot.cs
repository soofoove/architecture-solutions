namespace Lab3;

public class SettingsSnapshot
{
    public string Settings { get; }

    protected SettingsSnapshot(string settings)
    {
        Settings = settings;
    }
}
