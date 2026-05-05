using BepInEx.Configuration;
using RiskOfOptions;
using RoR2;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace VoidQualityFallback
{
    public static partial class Configs
    {
        const string ModGuid = PluginMain.PluginGUID;
        const string ModName = "VoidQualityFallback";

        internal static void Init(ConfigFile configFile)
        {
            configFile.SaveOnConfigSet = false;

            General.Init(configFile);

#if DEBUG
            Debug.Init(configFile);
#endif

            configFile.SaveOnConfigSet = true;
            configFile.Save();
        }

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        internal static void InitRiskOfOptions()
        {
            ModSettingsManager.SetModDescription("Settings for Void Quality Fallback", ModGuid, ModName);

            RoR2Application.onLoad += () =>
            {
                //if (VoidQualityFallback.Sprites.ModIcon)
                //{
                //    ModSettingsManager.SetModIcon(VoidQualityFallback.Sprites.ModIcon, ModGuid, ModName);
                //}
            };

            //General.InitRiskOfOptions();

#if DEBUG
            //Debug.InitRiskOfOptions();
#endif
        }
    }
}
