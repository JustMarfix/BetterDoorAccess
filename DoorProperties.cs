using Exiled.API.Enums;
using System.Collections.Generic;
using System.ComponentModel;

namespace BetterDoorAccess
{
    [Description("Door type (DoorType)")]
    public class DoorProperties
    {
        public DoorType type { get; set; }

        [Description("List of keycards that need to be given access / take away access (true in order to give and false in order to take away) (Dictionary<ItemType, bool>)")]
        public Dictionary<ItemType, bool> keycards { get; set; }
    }
}
