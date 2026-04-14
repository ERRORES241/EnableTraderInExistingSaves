// EnableTraderMod.cs
using MelonLoader;

namespace EnableTrader
{
    public class EnableTraderMod : MelonMod
    {
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("EnableTraderInExistingSaves initialized.");
        }
    }
}
