using BepInEx;
using BepInEx.Configuration;
using BepInEx.IL2CPP;
using BepInEx.Logging;
using HarmonyLib;
using System;

namespace VohleJumpHullDamageReduce
{
    [BepInPlugin("Desperationfighter.IXIONMods.VohleJumpHullDamageReduce", "Vohle Jump Hull Damage Reduce", "1.0.0")]
    public class Plugin : BasePlugin
    {
        public static ConfigEntry<int> ReduceDamageperJump;
        public static ManualLogSource logger;

        public override void Load()
        {
            ReduceDamageperJump = Config.Bind("General", "ReduceDamageperJump", 2, "Value how much Damage will be applied on each Jump");
            
            var harmony = new Harmony("Desperationfighter.IXIONMods.VohleJumpHullDamageReduce");
            harmony.PatchAll();
        }
    }
}
