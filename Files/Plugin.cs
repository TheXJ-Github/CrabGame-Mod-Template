using BepInEx;
using BepInEx.IL2CPP;
using HarmonyLib;

// credits to lammas123, Danilo1231, JD3006, and Lualttt
// original file at https://github.com/Lualttt/crabgame_template_plugin/blob/master/Plugin.cs
namespace CrabGameMod
{
    // other templates never included this...
    // at least lammas123 used strings, but ofc it was less readable
    class PluginInfo
    {
        public const string PLUGIN_GUID = "CrabGameMod";
        public const string PLUGIN_NAME = "CrabGameMod";
        public const string PLUGIN_VERSION = "1.000";
        public const string PLUGIN_CREATOR = "ModCreator";
    }

    // Plugin information
    [BepInPlugin(PluginInfo.PLUGIN_CREATOR, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class CrabGameModPlugin : BasePlugin
    {
        public override void Load()
        {
            // make sure to call it Runtime Hooks we're trying to apply
            // so we sound like we know what we are doing
            Log.LogMessage("Attempting to apply Runtime Hooks...");
            try
            {
                Harmony.CreateAndPatchAll(typeof(Patches));

                Log.LogMessage("Applied Runtime Hooks of mod " + PluginInfo.PLUGIN_NAME + " v" + PluginInfo.PLUGIN_VERSION);
            } 
            catch
            {  
                Log.LogError("Failed to apply Runtime Hooks!");
            }
        }
    }
}