using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord;
using System.IO;

namespace Karl_Narx_V2.Modules
{
    public class CheckAlarm : ModuleBase<SocketCommandContext>
    {
        [Command("Check alarm")]
        public async Task Chalarm()
        {
            string alarm = File.ReadLines("Alarm.txt").First();

            EmbedBuilder Embed = new EmbedBuilder();
            Embed.WithDescription("Current alarm set for: "+alarm);
            Embed.WithColor(new Color(255, 0, 0));

            await Context.Channel.SendMessageAsync("", false, Embed.Build());
        }
    }
}