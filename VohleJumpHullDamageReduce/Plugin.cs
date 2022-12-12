using BepInEx;
using BepInEx.Configuration;
using BepInEx.IL2CPP;
using BepInEx.Logging;
using HarmonyLib;
using System;
using System.Reflection;

namespace VohleJumpHullDamageReduce
{
    [BepInPlugin("Desperationfighter.IXIONMods.VohleJumpHullDamageReduce", "Vohle Jump Hull Damage Reduce", "1.0.0")]
    public class Plugin : BasePlugin
    {
        public static ConfigEntry<int> ReduceDamageperJump;
        public static ManualLogSource mylogger;

        public override void Load()
        {
            ReduceDamageperJump = Config.Bind("General", "ReduceDamageperJump", 50, "Value how much Damage will be applied on each Jump");
            mylogger = Log;

            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), null);
            string str = $"Plugin {Assembly.GetExecutingAssembly().GetName().Name} is loaded!";
            mylogger.LogInfo(str);
            
        }
    }
}
