using HarmonyLib;
using BulwarkStudios.Stanford.Torus.Structure;
using BulwarkStudios.Stanford.Core.GameStates;

namespace VohleJumpHullDamageReduce.Patch
{
    [HarmonyPatch(typeof(CommandHullConsumption))]
    [HarmonyPatch(nameof(CommandHullConsumption.HandleVohleJump))]
    public static class TorusStructure_CommandHullConsumption
    {
        [HarmonyPrefix]
        public static bool Prefix(CommandHullConsumption __instance)
        {
            //Game.Torus.torus.State.hullIntegrity -= 50f;
            Game.Torus.torus.State.hullIntegrity = 250f;

            Plugin.mylogger.LogInfo("Set custom hull damange on Jump hopefully");
            return true;
        }
    }
}
