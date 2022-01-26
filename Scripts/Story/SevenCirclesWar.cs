//cs_include Scripts/CoreBots.cs
//cs_include Scripts/CoreFarms.cs
//cs_include Scripts/CoreDailys.cs

using RBot;

public class SevenCirclesWar
{
    public ScriptInterface Bot => ScriptInterface.Instance;

    public CoreBots Core => CoreBots.Instance;
    public CoreFarms Farm = new CoreFarms();
    public CoreDailys Dailys = new CoreDailys();

    new string[] War = { "Essence of Treachery", "Essence of Violence", "Souls of Heresy", "Essence of Wrath" };

    public void ScriptMain(ScriptInterface bot)
    {
        Core.SetOptions();

        StoryLine();

        Core.SetOptions(false);
    }

    public void StoryLine()
    {
        Core.AddDrop(War);
        //Guards of Wrath
        Core.KillQuest(7979, "sevencircleswar", "Wrath Guard");
        //War Medals
        Core.KillQuest(7980, "sevencircleswar", "Wrath Guard");
        //Mega War Medals
        Core.KillQuest(7981, "sevencircleswar", "Wrath Guard");
        //Wrath Against the Machine
        Core.KillQuest(7982, "sevencircleswar", "Wrath");
        //Blasphemy? Blasphe-you!
        Core.KillQuest(7983, "sevencircleswar", "Heresy Guard");
        //Violence's Gatekeeper
        Core.KillQuest(7984, "sevencircleswar", "Violence's Gatekeeper");
        //Meaningless Violence
        Core.KillQuest(7985, "sevencircleswar", "Violence Guard");
        //Geryon, Not Gary On!
        Core.KillQuest(7986, "sevencircleswar", "Geryon");
        //Violence
        Core.KillQuest(7987, "sevencircleswar", "Violence");
        //Where the Trea-sun Don't Shine
        Core.KillQuest(7988, "sevencircleswar", "Treachery Guard");
        //Hanged for Treason
        Core.KillQuest(7989, "sevencircleswar", "Treachery");
        //The Beast
        Core.KillQuest(7990, "sevencircleswar", "The Beast");

    }
}