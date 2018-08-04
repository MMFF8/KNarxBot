using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord;

namespace Karl_Narx_V2.Modules
{
    public class RealtimeCheck : ModuleBase<SocketCommandContext>
    {
        [Command("help-realtime")]
        public async Task realp()
        {
            EmbedBuilder Embed4 = new EmbedBuilder();
            Embed4.WithTitle("Realtime Check Commands");
            Embed4.WithDescription
                ("Karl, When is now?\n" +
                "   *-States the current date and time*\n\n" +
                "Karl, Control F: [URL] from [string]\n" +
                "   *-Searches for string from URL*\n\n" +
                "Karl, Play [string]\n" +
                "   *-Gets the first search result for string from Youtube*   \n\n" +
                "Karl, Set alarm for: [day]-[month]-[year] | [Hour]:[Minute] [AM/PM]\n" +
                "   *-That's a lot parameters... Only 1 at a time btw*\n\n"+
                "Karl, check alarm\n" +
                "   *-Gets current alarm*\n\n");
            Embed4.WithColor(new Color(255, 225, 0));
            
            await Context.Channel.SendMessageAsync("", false, Embed4.Build());
            await Context.Message.DeleteAsync();
        }
    }
}
