using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord;

namespace Karl_Narx_V2.Modules
{
    public class Hemmertime : ModuleBase<SocketCommandContext>
    {
        [Command("What time is it?")]
        public async Task shwoosh()
        {
            EmbedBuilder Embed = new EmbedBuilder();
            Embed.WithAuthor("Karl Marx");
            Embed.WithTitle("IT'S HAMMER TIME COMRADE!");
            Embed.WithColor(new Color(255, 0, 0));
            Embed.WithImageUrl("https://i.kym-cdn.com/photos/images/original/000/960/056/27b.gif");

            await Context.Channel.SendMessageAsync("", false, Embed.Build());
        }
    }
}