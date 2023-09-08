using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace BetterDoorAccess
{
    public class Config : IConfig
    {
        [Description("Is plugin enabled? (bool)")]
        public bool IsEnabled { get; set; } = true;

        [Description("Is Debug enabled? (bool)")]
        public bool Debug { get; set; } = false;

        [Description("List of doors for changing access (List<DoorProperties>)")]
        public List<DoorProperties> Doors { get; set; } = new List<DoorProperties>()
        {
            new DoorProperties()
            {
                type = Exiled.API.Enums.DoorType.Intercom,
                keycards = new Dictionary<ItemType, bool>()
                {
                    {
                        ItemType.KeycardGuard,
                        true
                    },
                    {
                        ItemType.KeycardMTFCaptain,
                        false
                    }
                }
            }
        };
    }
}
