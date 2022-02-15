//cs_include Scripts/CoreBots.cs
//cs_include Scripts/Good/BLoD/CoreBLOD.cs
//cs_include Scripts/CoreDailys.cs
//cs_include Scripts/Story/Doomwood/DoomwoodPart3.cs
using RBot;

public class PinkBladeOfDestruciton
{
    public ScriptInterface Bot => ScriptInterface.Instance;
    public CoreBots Core => CoreBots.Instance;
    public CoreBLOD BLoD = new CoreBLOD();
    public DoomwoodPart3 P3 = new DoomwoodPart3();

    public void ScriptMain(ScriptInterface bot)
    {
        Core.SetOptions();

        GetPBoD();

        Core.SetOptions(false);
    }

    public void GetPBoD()
    {
        P3.Part3();

        Core.AddDrop("Pink Blade of Destruction", "Fuchsia Dye", "Zealous Badge");
        // Forging a Friendship - 7650
        Core.EnsureAccept(7650);
        //reqs:
        // Fuchsia Dye x50
        // Spirit Orb (Misc) x500
        // Zealous Badge x5
        // Unicorn Essence x5
        // Gem Power x5

        while (!Core.CheckInventory("Fuchsia Dye", 50))
        {
            Core.EnsureAccept(1487);
            Core.HuntMonster("natatorium", "Anglerfish", "Pink Coral", 3);
            Core.HuntMonster("bloodtuskwar", "Chaotic Vulture", "Amaranth Flower", 5);
            Core.EnsureComplete(1487);
        }

        BLoD.SpiritOrb(500);

        while (!Core.CheckInventory("Zealous Badge", 5))
        {
            Core.EnsureAccept(7616);
            Core.HuntMonster("techdungeon", "Kalron the Cryptborg", "Immutable Dedication", 7);
            Core.HuntMonster("techdungeon", "DoomBorg Guard", "Paladin Armor Scraps", 30);
            Core.EnsureComplete(7616);
        }

        Core.HuntMonster("undergroundlabb", "Ultra Brutalcorn", "Unicorn Essence, 5");

        Core.HuntMonster("undergroundlabb", "Ultra Battle Gem", "Gem Power", 5);

        Core.EnsureComplete(7650, 55884);
    }

}