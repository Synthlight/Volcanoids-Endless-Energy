using Base_Mod;
using JetBrains.Annotations;

namespace Endless_Energy;

[UsedImplicitly]
public class Plugin : BaseGameMod {
    protected override bool UseHarmony => true;

    public override void OnInitData() {
        foreach (var core in RuntimeAssetDatabase.Get<TrainCoreItemDefinition>()) {
            core.MaxEnergy             = 9999;
            core.BoilerEnergyPerSecond = 9999;
        }
    }
}