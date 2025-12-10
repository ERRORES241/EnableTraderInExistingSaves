// TraderPatches.cs
using HarmonyLib;
using Il2CppTLD.Trader;

namespace EnableTrader
{
    [HarmonyPatch(typeof(TraderManager))]
    public static class TraderManager_Deserialize_EnableTrader
    {
        // This matches: Deserialize(TraderState state)
        [HarmonyPostfix]
        [HarmonyPatch("Deserialize")]
        public static void Postfix(TraderManager __instance, TraderState state)
        {
            if (state == null)
                return;

            // This is the actual flag from your TraderState.cs
            state.m_SystemEnabled = true;
        }
    }
}
