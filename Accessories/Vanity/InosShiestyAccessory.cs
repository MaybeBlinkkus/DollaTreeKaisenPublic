using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Accessories.Vanity
{
    [AutoloadEquip(EquipType.Front)]
    public class InosShiestyAccessory : ModItem, ILocalizedModType 
    {
        public new string LocalizationCategory => "Content.Items.Accessories.Vanity";
        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 26;
            Item.rare = ItemRarityID.Blue;
            Item.value = 0;
            Item.vanity = true;
            Item.accessory = true;
        }

        public override void AddRecipes() => CreateRecipe().AddTile(TileID.Loom).Register();
    }
}
