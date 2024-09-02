using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Accessories.Vanity
{
    [AutoloadEquip(EquipType.Back, EquipType.Front)]
    public class YutasKatanaBag : ModItem, ILocalizedModType
    {
        public new string LocalizationCategory => "Content.Items.Accessories.Vanity";
        public override void SetDefaults()
        {
            Item.width = Item.height = 34;
            Item.rare = ItemRarityID.Blue;
            Item.value = 0;
            Item.vanity = true;
            Item.accessory = true;
        }

        public override void AddRecipes() => CreateRecipe().AddTile(TileID.Loom).Register();
    }
}
