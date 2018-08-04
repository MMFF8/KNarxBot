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
    public class Timer : ModuleBase<SocketCommandContext>
    {
        [Command("timer:")]
        public async Task timr ([Remainder]string message)
        {
            string[] brek = new string[] { };
            brek = message.Split('|');

            DateTime currentTime = DateTime.Now;
            DateTime Later = DateTime.Now;
            string[] valu;
            int val=0;
            int count = brek.Length;
            for (int x = 0; x < count; x++)
            {
                if (brek[x].Contains("minutes") == true)
                {
                    valu = brek[x].Split(' ');
                    val = Int32.Parse(valu[0]);
                    Later = currentTime.AddMinutes(val);
                    currentTime = Later;
                }
                if (brek[x].Contains("hours") == true)
                {
                    valu = brek[x].Split(' ');
                    val = Int32.Parse(valu[0]);
                    Later = currentTime.AddHours(val);
                    currentTime = Later;
                }
                if (brek[x].Contains("days") == true)
                {
                    valu = brek[x].Split(' ');
                    val = Int32.Parse(valu[0]);
                    Later = currentTime.AddDays(val);
                    currentTime = Later;
                }
                if (brek[x].Contains("months") == true)
                {
                    valu = brek[x].Split(' ');
                    val = Int32.Parse(valu[0]);
                    Later = currentTime.AddMonths(val);
                    currentTime = Later;
                }
                if (brek[x].Contains("years") == true)
                {
                    valu = brek[x].Split(' ');
                    val = Int32.Parse(valu[0]);
                    Later = currentTime.AddYears(val);
                    currentTime = Later;
                }
            }
            string Timelater = Later.ToString("dd-MM-yyyy" + " | " + "hh:mm" + " " + "tt", CultureInfo.InvariantCulture);
            string arlm = Timelater;

            using (StreamWriter newTask = new StreamWriter("Alarm.txt", false))
            {
                newTask.WriteLine(arlm.ToString());
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
            Embed.WithDescription("The timer will ring at: "+arlm);
            Embed.WithColor(new Color(255, 0, 0));

            await Context.Channel.SendMessageAsync("", false, Embed.Build());
        }
    }
}
