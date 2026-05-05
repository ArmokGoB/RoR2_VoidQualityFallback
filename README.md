# Void Quality Fallback
This is a mod that adds fallback compatibility to [Goorakh's Quality mod for Risk of Rain 2](https://thunderstore.io/package/Goorakh/Quality/). This affects modded void items that do not have a quality variant, such as those from [VanillaVoid](https://thunderstore.io/package/Zenithrium/VanillaVoid/) and [Nautilus](https://thunderstore.io/package/hex3/Nautilus/).

## The Problem
As of 2026-05-04, the current functionality of Quality causes the complete loss of quality on modded void items when the original items are converted. This can lead to the player not scaling properly when they convert large amounts of their items to their void counterparts, as the Quality mod increases difficulty scaling.

## The Solution
This mod causes the game to check if the player has quality items with a void variant. If the void variant does not have quality variants added via Quality or another mod, it replaces all of the quality and non-quality items with the non-quality void variant upon pickup of a relevant void item. As compensation for the lost quality, it transfers the quality of the lost items on to random, non-quality items of the same rarity in the player's inventory in a random order.

### Quality Essence
If there aren't enough items to bestow quality on to, the player is instead given Quality Essence of equal rarity to the transformed items. Quality Essence doesn't do anything on its own and cannot be scrapped or used in 3D Printers. However, the next time the player receives a non-quality item of the same rarity as the Quality Essence out of a chest, the new item is given the quality of a random Quality Essence and that Quality Essence is removed from the player's inventory.

Quality Essence does not work when getting items from Multishops, Cauldrons, 3D Printers, or other sources where the item is visible before spending resources. This is to prevent the player from stacking specific quality-version items. Stacking quality items like this is not something that is normally possible in the Quality mod, outside of Quality 3D Printers, which require a significant amount of preparation and luck to use to such effect.

### Example
The player has one non-quality Crowbar, three uncommon Crowbars, and one legendary Crowbar. The player then picks up an Abyss-Touched Adze from a Void Cradle. The Abyss-Touched Adze converts the existing Crowbars into five additional Abyss-Touched Adzes. If the player had four or more non-quality items of common (white) rarity that have quality versions, three of them are chosen at random to become uncommon versions of those items and one is chosen at random to become a legendary version.

Other than the Abyss-Touched Adzes, this player only has two Lens-Maker's Glasses, a Ukulele, and a Bustling Fungus. One Lens-Maker's Glasses is randomly chosen to become uncommon, one Lens-Maker's Glasses is randomly chosen to become legendary, and the Bustling Fungus is randomly chosen to become uncommon. The Ukulele is an uncommon (green) rarity item, so it cannot gain quality from the converted Crowbars. The player is given a common rarity, uncommon quality Quality Essence as compensation for the lost quality on one of the Crowbars.

The player then opens a large chest containing a 57 Leaf Clover. Since this 57 Leaf Clover's rarity is different from that of the Quality Essence, the quality is not changed. The player next opens a chest containing a rare quality Energy Drink. Since this item is already quality, it does not have its quality changed by the Quality Essence. The player finally opens a chest containing a non-quality Paul's Goat Hoof. The Paul's Goat Hoof has its quality upgraded to uncommon by the uncommon Quality Essence and the Quality Essence is removed from the player's inventory.
