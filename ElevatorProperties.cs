using System.Collections.Generic;
using System.ComponentModel;
using Interactables.Interobjects;

namespace BetterDoorAccess
{
    [Description("Elevator type (ElevatorManager.ElevatorGroup)")]
    public class ElevatorProperties
    {
        public ElevatorManager.ElevatorGroup type { get; set; }

        [Description("List of keycards that need to be given access (like whitelist mode) (List<ItemType>)")]
        public List<ItemType> keycards { get; set; }

        [Description("Message for user without a keycard from whitelist")]
        public string message { get; set; }
        
        public enum output
        {
            Broadcast,
            Hint
        }

        [Description("Method for displaying a message to the user")]
        public output method { get; set; }
    }
}