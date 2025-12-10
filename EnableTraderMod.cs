// EnableTraderMod.cs
using MelonLoader;

[assembly: MelonInfo(typeof(EnableTrader.EnableTraderMod), "EnableTraderInExistingSaves", "1.0.0", "YourName")]
[assembly: MelonGame("Hinterland", "TheLongDark")]

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
