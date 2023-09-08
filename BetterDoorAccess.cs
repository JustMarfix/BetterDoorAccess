using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;

namespace BetterDoorAccess
{
    public class BetterDoorAccess : Plugin<Config>
    {
        public static BetterDoorAccess Instance { get; set;} = new BetterDoorAccess();
        public BetterDoorAccess() { }

        public override string Author => "JustMarfix";
        public override string Name => "BetterDoorAccess";

        Handlers.PlayerHandler playerHandler;
        public override void OnEnabled()
        {
            playerHandler = new Handlers.PlayerHandler();
            Player.InteractingDoor += playerHandler.OnInteractingDoor;
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Player.InteractingDoor -= playerHandler.OnInteractingDoor;
            playerHandler = null;
            base.OnDisabled();
        }
    }
}
