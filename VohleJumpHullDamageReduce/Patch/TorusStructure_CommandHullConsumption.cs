using HarmonyLib;
using BulwarkStudios.Stanford.Torus.Structure;
using BulwarkStudios.Stanford.Core.GameStates;
using BepInEx.Logging;

namespace VohleJumpHullDamageReduce.Patch
{
    [HarmonyPatch(typeof(CommandHullConsumption))]
    [HarmonyPatch(nameof(CommandHullConsumption.HandleVohleJump))]
    internal static class TorusStructure_CommandHullConsumption
    {
        [HarmonyPrefix]
        static bool Prefix(CommandHullConsumption __instace)
        {
            Game.Torus.torus.State.hullIntegrity -= 50f;
            Plugin.logger.LogInfo("Set custom hull damange on Jump hopefully");
            return false;
        }
    }
}
