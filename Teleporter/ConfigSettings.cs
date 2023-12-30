using BepInEx;
using BepInEx.Configuration;
using UnityEngine;

namespace Teleporter
{
    public static class ConfigSettings
    {
        // public static ConfigEntry<bool> EnableResetTeleport;
        // public static ConfigEntry<bool> EnableInverseTeleporter;
        // public static ConfigEntry<bool> EnableTeleporter;
        
        public static ConfigEntry<float> CoolDownInverseTeleporter;
        public static ConfigEntry<float> CoolDownTeleporter;

        //public static ConfigEntry<string> InverseTeleporterItems;
        //public static ConfigEntry<string> TeleporterItems;
        

        public static void Init()
        {
            // EnableResetTeleport = Plugin.Instance.Config.Bind("Teleporter", "EnableResetTeleport", true, "Each game start resets the teleport time.");
            // EnableInverseTeleporter = Plugin.Instance.Config.Bind("Teleporter", "EnableInverseTeleporter", true, "Enable?");
            // EnableTeleporter = Plugin.Instance.Config.Bind("Teleporter", "EnableTeleporter", false, "Enable?");
            
            CoolDownInverseTeleporter = Plugin.Instance.Config.Bind("Teleporter", "CoolDownInverseTeleporter", 20.0f, "Game Defaults: 210"); 
            CoolDownTeleporter = Plugin.Instance.Config.Bind("Teleporter", "CoolDownTeleporter", 10.0f, "Game Defaults: 10");
            
          //  InverseTeleporterItems = Plugin.Instance.Config.Bind("Teleporter", "InverseTeleporterItems", "ClipboardItem,ExtensionLadderItem,FlashlightItem,JetpackItem,KeyItem,RadarBoosterItem,ShotgunItem,Shovel,SprayPaintItem,StunGrenadeItem,WalkieTalkie", "Cooldown: seconds");
        //    TeleporterItems = Plugin.Instance.Config.Bind("Teleporter", "TeleporterItems", "", "Cooldown: seconds");
            
        }
        
    }
}