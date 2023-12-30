using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using BepInEx.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teleporter
{
    // Patches all changes.
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    [BepInDependency("evaisa.lethalthings")]
    public class Plugin : BaseUnityPlugin
    {
        public const string modGUID = PluginInfo.PLUGIN_GUID;
        public const string modName = PluginInfo.PLUGIN_NAME;
        public const string modVersion = PluginInfo.PLUGIN_VERSION;



        private readonly Harmony harmony = new Harmony(modGUID);
        public static Plugin instance;
        public static Plugin Instance;
        private ManualLogSource mls;
        
        void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            if (Instance == null)
            {
                Instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);
            harmony.PatchAll();
            ConfigSettings.Init();

            mls.LogInfo("Patched NicerTeleporters.");
        }


    }
}
