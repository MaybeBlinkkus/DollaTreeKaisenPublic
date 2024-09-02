using Terraria.Localization;

namespace NeviliscoVanity
{
    public partial class NevilUtils
    {
        /// <param name="key">The language key. This will have "Mods.NeviliscoVanity." appended behind it.</param>
        /// <returns>
        /// A <see cref="LocalizedText"/> instance found using the provided key with "Mods.NeviliscoVanity." appended behind it. 
        /// <para>NOTE: Modded translations are not loaded until after PostSetupContent.</para>Caching the result is suggested.
        /// </returns>
        public static LocalizedText GetText(string key)
        {
            return Language.GetOrRegister("Mods.NeviliscoVanity." + key);
        }

        /// <param name="key">The language key. This will have "Mods.NeviliscoVanity." appended behind it.</param>
        /// <returns>
        /// A <see cref="string"/> instance found using the provided key with "Mods.NeviliscoVanity." appended behind it.
        /// <para>NOTE: Modded translations are not loaded until after PostSetupContent.</para>Caching the result is suggested.
        /// </returns>
        public static string GetTextValue(string key)
        {
            return Language.GetTextValue("Mods.NeviliscoVanity." + key);
        }
    }
}
