using ItemQualities;
using RoR2;

namespace VoidQualityFallback.Compatibility
{
    internal static class QualityCompatibility
    {
        public static bool IsQualityItem(ItemIndex item)
        {
            if (GetQuality(item) == QualityTier.None)
                return false;

            return true;
        }
        public static QualityTier GetQuality(ItemIndex item)
        {
            return QualityCatalog.GetQualityTier(item);
        }
        public static ItemQualityGroup GetQualityGroup(ItemQualityGroupIndex item)
        {
            if (item == ItemQualityGroupIndex.Invalid)
                return null;

            return QualityCatalog.GetItemQualityGroup(item);
        }
        public static ItemIndex GetItem(ItemIndex item)
        {
            if (item == ItemIndex.None)
                return ItemIndex.None;

            return QualityCatalog.GetItemIndexOfQuality(item, QualityTier.None);
        }
        public static ItemIndex GetItem(ItemIndex item, QualityTier tier)
        {
            if (item == ItemIndex.None)
                return ItemIndex.None;

            return QualityCatalog.GetItemIndexOfQuality(item, tier);
        }
        public static bool HasQualityVariant(ItemIndex item)
        {
            if (GetItem(item, QualityTier.Uncommon) == ItemIndex.None)
                return false;

            return true;
        }
    }
}
