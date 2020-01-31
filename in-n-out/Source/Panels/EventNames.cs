using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innout.Source.Panels
{
    internal static class EventNames
    {
        internal static class CraftPane
        {
            internal const string SwitchedInterfaceMode = "CraftInterfaceMode";
            internal const string Selected = "CraftSelected";
            internal const string Crafted = "CraftCrafted";
            // ...
        }

        internal static class ToolPane
        {
            internal const string SwitchedInterfaceMode = "ToolInterfaceMode";
            internal const string Selected = "ToolSelected";
            internal const string Crafted = "ToolUpgraded";
            // ...
        }

        internal static class ItemPane
        {
            internal const string SwitchedInterfaceMode = "ToolInterfaceMode";
            internal const string Selected = "ToolSelected";
            internal const string Crafted = "ToolUpgraded";
            // ...
        }
    }
}
