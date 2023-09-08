using Exiled.Events.EventArgs.Player;
using System.Collections.Generic;

namespace BetterDoorAccess.Handlers
{
    public class PlayerHandler
    {
        public void OnInteractingDoor(InteractingDoorEventArgs ev)
        {
            if (ev.Player.CurrentItem == null)
            {
                return;
            }
            if (ev.Door.IsLocked || ev.Door.IsMoving)
            {
                return;
            }
            foreach (DoorProperties props in BetterDoorAccess.Instance.Config.Doors)
            {
                if (ev.Door.Type == props.type)
                {
                    foreach (KeyValuePair<ItemType, bool> pair in props.keycards)
                    {
                        if (ev.Player.CurrentItem.Type == pair.Key)
                        {
                            ev.IsAllowed = pair.Value;
                        }
                    }
                }
            }
        }
    }
}
