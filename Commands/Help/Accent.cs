using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord;

namespace Karl_Narx_V2.Modules
{
    public class Accent : ModuleBase<SocketCommandContext>
    {
        [Command("help-accent")]
        public async Task accelp()
        {
            EmbedBuilder Embed5 = new EmbedBuilder();
            Embed5.WithTitle("Bot Accent Commands");
            Embed5.WithDescription
                ("Karl, Normal mode\n" +
                "   *-Talks like the Cold-war socialist he is*\n\n" +
                "Karl, Tsundere mode\n" +
                "   *-Talks like one but can't even blush, no redemption*   \n\n" +
                "Karl, Yoda mode\n" +
                "   *-Backwards indeed, he talks*   \n\n");
            Embed5.WithColor(new Color(255, 0, 0));

            await Context.Channel.SendMessageAsync("", false, Embed5.Build());
            await Context.Message.DeleteAsync();
        }
    }
}
