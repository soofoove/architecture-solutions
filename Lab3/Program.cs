namespace Lab3;

public static class Program
{
    public static void Main(string[] args)
    {
        UserProfile userProfile = new UserProfile();
        SettingsHistory settingsHistory = new SettingsHistory(userProfile);

        userProfile.Settings = "someSettings";
        userProfile.PrintCurrentSettings();
        settingsHistory.Save();

        userProfile.Settings = "someNewSettings";
        userProfile.PrintCurrentSettings();
        settingsHistory.Undo();

        userProfile.PrintCurrentSettings();

        settingsHistory.Undo();
    }
}
