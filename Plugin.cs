using Base_Mod;
using JetBrains.Annotations;
using UnityEngine.SceneManagement;

namespace Endless_Energy {
    [UsedImplicitly]
    public class Plugin : BaseGameMod {
        protected override bool UseHarmony => true;

        public override void OnGameLoaded(Scene scene) {
            foreach (var powerPlant in RuntimeAssetDatabase.Get<ItemDefinition>().WithComponent<PowerPlant>()) {
                if (powerPlant.name == "SegmentFront") powerPlant.EnergyPerSecond = 9999;
            }
            foreach (var core in RuntimeAssetDatabase.Get<TrainCoreItemDefinition>()) {
                core.MaxEnergy = 9999;
            }

            base.OnGameLoaded(scene);
        }
    }
}