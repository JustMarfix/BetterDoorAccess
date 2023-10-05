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
        public void OnInteractingElevator(InteractingElevatorEventArgs ev)
        {
            foreach (ElevatorProperties props in BetterDoorAccess.Instance.Config.Elevators)
            {
                if (ev.Elevator.AssignedGroup == props.type)
                {
                    if (ev.Player.CurrentItem == null)
                    {
                        ev.IsAllowed = false;
                        if (props.method == ElevatorProperties.output.Broadcast)
                        {
                            ev.Player.Broadcast(5, props.message, shouldClearPrevious: true);
                        }
                        else
                        {
                            ev.Player.ShowHint(props.message, 5);
                        }
                        return;
                    }
                    if (props.keycards.Contains(ev.Player.CurrentItem.Type))
                    {
                        ev.IsAllowed = true;
                    }
                    else
                    {
                        ev.IsAllowed = false;
                        if (props.method == ElevatorProperties.output.Broadcast)
                        {
                            ev.Player.Broadcast(5, props.message, shouldClearPrevious: true);
                        }
                        else
                        {
                            ev.Player.ShowHint(props.message, 5);
                        }
                    }
                }
            }
        }
    }
}
