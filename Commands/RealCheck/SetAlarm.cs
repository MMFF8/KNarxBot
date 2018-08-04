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
    public class SetAlarm : ModuleBase<SocketCommandContext>
    {
        [Command("Set alarm for:")]
        public async Task Salarm([Remainder]string message)
        {
            string Alrmset = message;

            using (StreamWriter newTask = new StreamWriter("Alarm.txt", false))
            {
                newTask.WriteLine(Alrmset.ToString());
            }
            var id = Context.Message.Author.Id;
            using (StreamWriter newTask = new StreamWriter("AlarmSetter.txt", false))
            {
                newTask.WriteLine(id);
            }
            using (StreamWriter newTask = new StreamWriter("AlarmChanid.txt", false))
            {
                newTask.WriteLine(Context.Message.Channel.Id);
            }
            using (StreamWriter newTask = new StreamWriter("AlarmGuiid.txt", false))
            {
                newTask.WriteLine(Context.Guild.Id);
            }
            EmbedBuilder Embed = new EmbedBuilder();
            Embed.WithTitle("Comerade, it is set!");
            Embed.WithDescription("Alarm set for: "+Alrmset);
            Embed.WithColor(new Color(255, 0, 0));

            await Context.Channel.SendMessageAsync("", false, Embed.Build());
        }
    }
}