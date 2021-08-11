using Base_Mod;
using JetBrains.Annotations;

namespace Endless_Energy {
    [UsedImplicitly]
    public class Plugin : BaseGameMod {
        protected override string ModName => "Endless-Energy";

        public override void OnGameLoaded() {
            foreach (var powerPlant in GameResources.Instance.Items.WithComponent<PowerPlant>()) {
                if (powerPlant.name == "SegmentFront") powerPlant.EnergyPerSecond = 9999;
            }

            base.OnGameLoaded();
        }
    }
}