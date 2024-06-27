using BepInEx.IL2CPP.Utils;
using HarmonyLib;
using UnityEngine;

// declarations like these avoid the use for these obfuscated values
// and make code easier to read!
using EffectManager = MonoBehaviourPublicGataInefObInUnique;
using LobbyManager = MonoBehaviourPublicCSDi2UIInstObUIloDiUnique;

// credits to lammas123, and o7moon
// original file at https://github.com/lammas321/CrabGameFloatingPlayerPatch/blob/main/FloatingPlayerPatch/Patches.cs
namespace CrabGameMod
{
    internal class Patches
    {
        // Anti Bepinex detection (thanks o7Moon https://github.com/o7Moon/CrabGame.AntiAntiBepinex)

        // Ensures effectSeed is never set to 4200069 (if it is, modding has been detected)
        [HarmonyPatch(typeof(EffectManager), nameof(EffectManager.Method_Private_Void_GameObject_Boolean_Vector3_Quaternion_0))]

        // Ensures connectedToSteam stays false (true means modding has been detected)
        [HarmonyPatch(typeof(LobbyManager), nameof(LobbyManager.Method_Private_Void_0))]

        // Would ensure snowSpeed is never set to Vector3.zero, but it is immediately set back to Vector3.one due to an accident on Dani's part lol
        //[HarmonyPatch(typeof(SnowSpeedModdingDetector), nameof(SnowSpeedModdingDetector.Method_Private_Void_0))] 
        
        [HarmonyPrefix]
        public static bool PreBepinexDetection() => false;

        // And your extra code here
        // If you use more files, make sure they are in the Plugin.cs file as Harmony.CreateAndPatchAll(typeof(FileName)); alongside the other ones
    }
}