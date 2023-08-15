using Terraria;
using Terraria.ID;
using TerrariaApi.Server;
using TShockAPI;

namespace TTools;

[ApiVersion(2, 1)]
public class TTools : TerrariaPlugin
{
    
    public TTools(Main game) : base(game)
    {
    }

    public override string Author => "loganintech";

    public override string Description =>
        "Some tools for your Tshock Server";
    
    public override Version Version => new(0, 0, 1, 0);

    public override void Initialize()
    {
        Commands.ChatCommands.Add(new Command(Permissions.spawnboss, Luck, "luck"));
    }

    private void Luck(CommandArgs args)
    {
        args.Player.SendSuccessMessage($"Your luck is: {args.Player.TPlayer.luck}.");
    }
}