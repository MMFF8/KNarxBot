using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord;

namespace Karl_Narx_V2.Modules
{
    public class Stringedit : ModuleBase<SocketCommandContext>
    {
        [Command("help-stringedit")]
        public async Task strelp()
        {
            EmbedBuilder Embed2 = new EmbedBuilder();
            Embed2.WithTitle("String Edit Commands");
            Embed2.WithDescription
                ("Karl, Say: [string]\n" +
                "   *-Echo string through the Voice of Wisdom*\n\n" +
                "Karl, Commspeak [string]\n" +
                "   *-Translates string into Communist English*   \n\n");
            Embed2.WithColor(new Color(255, 225, 0));

            await Context.Channel.SendMessageAsync("", false, Embed2.Build());
            await Context.Message.DeleteAsync();
        }
    }
}
