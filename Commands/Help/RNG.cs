using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord;

namespace Karl_Narx_V2.Modules
{
    public class RNG : ModuleBase<SocketCommandContext>
    {
        [Command("help-rng")]
        public async Task relp()
        {
            EmbedBuilder Embed3 = new EmbedBuilder();
            Embed3.WithTitle("RNG Based Commands");
            Embed3.WithDescription
                ("Karl, !Roll [int Limit]\n" +
                "   *-Generates an integer within a set limit*\n\n" +
                "Karl, Load the revolver\n" +
                "   *-Shuffles 1 bullet and 5 blanks for firing*\n\n" +
                "Karl, Load the revolver with: [string]!,[string]!,[st...\n" +
                "   *-Shuffles any number of strings and loads them for firing*   \n\n" +
                "Karl, Fire\n" +
                "   *-Fires a single shot from the revolver*");
            Embed3.WithColor(new Color(255, 0, 0));
            
            await Context.Channel.SendMessageAsync("", false, Embed3.Build());
            await Context.Message.DeleteAsync();
        }
    }
}
