namespace Lab3;

public class SettingsHistory
{
    private readonly Stack<SettingsSnapshot> _settingsSnapshots = new Stack<SettingsSnapshot>();
    private readonly UserProfile _userProfile;

    public SettingsHistory(UserProfile userProfile)
    {
        _userProfile = userProfile;
    }

    public void Save()
    {
        Console.WriteLine($"Saving UserProfile settings");
        _settingsSnapshots.Push(_userProfile.Save());
    }

    public void Undo()
    {
        Console.WriteLine("Restoring settings...");
        if (!this._settingsSnapshots.Any())
        {
            Console.WriteLine("Nothing to undo");
            return;
        }

        SettingsSnapshot snapshot = _settingsSnapshots.Pop();
        _userProfile.Restore(snapshot);
    }
}
