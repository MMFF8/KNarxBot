using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord;
using System.Globalization;
using System.IO;

namespace Karl_Narx_V2.Modules
{
    public class DTNow : ModuleBase<SocketCommandContext>
    {
        [Command("When is now?")]
        public async Task DaTiNow()
        {

            string Datenow = DateTime.Now.ToString("dd-MM-yyyy");
            string Timenow = DateTime.Now.ToString("hh:mm"+" "+"tt", CultureInfo.InvariantCulture);

            string accmode = File.ReadLines("Mode.txt").First();

            EmbedBuilder Embed = new EmbedBuilder();

            if (accmode == "Normal")
            {
                Embed.WithTitle("Comrade, now is:");
                Embed.WithDescription(Datenow + " | " + Timenow);
                Embed.WithColor(new Color(255, 225, 0));
            }
            if (accmode == "Tsundere")
            {
                Embed.WithTitle("Huh? You can't even do that by yourself?! It's obviously: ");
                Embed.WithDescription(Datenow + " | " + Timenow);
                Embed.WithColor(new Color(254, 127, 156));
            }
            if (accmode == "Yoda")
            {
                Embed.WithTitle("What now, the present is?");
                Embed.WithDescription(Datenow + " | " + Timenow);
                Embed.WithColor(new Color(0, 255, 0));
            }

            await Context.Channel.SendMessageAsync("", false, Embed.Build());
        }
    }
}