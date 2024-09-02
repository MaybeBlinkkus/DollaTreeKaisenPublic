using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity
{
    [AutoloadEquip(EquipType.Legs)]
    public class TojisPants : ModItem, ILocalizedModType
    {
        public new string LocalizationCategory => "Content.Items.Armor.Vanity";
        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 18;
            Item.value = 0;
            Item.rare = ItemRarityID.Blue;
            Item.vanity = true;
        }

        public override void AddRecipes() => CreateRecipe().AddTile(TileID.Loom).Register();
    }
}
