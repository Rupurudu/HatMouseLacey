using StardewModdingAPI;
using StardewValley;
using System;
using System.Collections.Generic;

#nullable enable

namespace ContentPatcher
{
    public interface IContentPatcherAPI
    {
        void RegisterToken(IManifest mod, string name, Func<IEnumerable<string>?> getValue);
    }
}

#nullable disable

namespace GenericModConfigMenu
{
    public interface IGenericModConfigMenuApi
    {
        void Register(IManifest mod, Action reset, Action save, bool titleScreenOnly = false);
        void AddSectionTitle(IManifest mod, Func<string> text, Func<string> tooltip = null);
        void AddBoolOption(IManifest mod, Func<bool> getValue, Action<bool> setValue, Func<string> name, Func<string> tooltip = null, string fieldId = null);
        void AddTextOption(IManifest mod, Func<string> getValue, Action<string> setValue, Func<string> name, Func<string> tooltip = null, string[] allowedValues = null, Func<string, string> formatAllowedValue = null, string fieldId = null);
    }
}

namespace FashionSense.Framework.Interfaces.API
{
    public interface IApi
    {
        public enum Type
        {
            Unknown,
            Hair,
            Accessory,
            [Obsolete("No longer maintained. Use Accessory instead.")]
            AccessorySecondary,
            [Obsolete("No longer maintained. Use Accessory instead.")]
            AccessoryTertiary,
            Hat,
            Shirt,
            Pants,
            Sleeves,
            Shoes,
            Player
        }
        KeyValuePair<bool, string> GetCurrentAppearanceId(Type appearanceType, Farmer target = null);
    }
}
