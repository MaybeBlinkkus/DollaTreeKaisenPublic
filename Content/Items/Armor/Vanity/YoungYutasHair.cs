using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity
{
    [AutoloadEquip(EquipType.Head)]
    public class YoungYutasHair : ModItem, ILocalizedModType
    {
        public new string LocalizationCategory => "Content.Items.Armor.Vanity";
        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 34;
            Item.rare = ItemRarityID.Blue;
            Item.value = 0;
            Item.vanity = true;
        }

        public override void AddRecipes() => CreateRecipe().AddTile(TileID.Loom).Register();
    }
}
