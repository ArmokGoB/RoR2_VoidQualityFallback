using BepInEx;
using R2API;
using RoR2;
using UnityEngine;
using UnityEngine.AddressableAssets;
using VoidQualityFallback.Utils;

namespace VoidQualityFallback
{
    [BepInDependency(ItemAPI.PluginGUID)]
    [BepInDependency(LanguageAPI.PluginGUID)]
    [BepInDependency("com.Goorakh.ItemQualities")]
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    public sealed class PluginMain : BaseUnityPlugin
    {
        public const string PluginGUID = PluginAuthor + "." + PluginName;
        public const string PluginAuthor = "ArmokGoB";
        public const string PluginName = "VoidQualityFallback";
        public const string PluginVersion = "0.8.0";
    }
}
