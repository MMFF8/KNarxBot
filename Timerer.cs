using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;
using System.Globalization;
using Discord.Commands;
using Discord.WebSocket;
using Discord;

namespace Karl_Narx_V2
{
    internal static class Timerer
    {
        private static SocketTextChannel channel;

        internal static Task StartTimer()
        {
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 5000;
            aTimer.Enabled = true;
            Task.Delay(5000);
            string Chanid = File.ReadLines("AlarmChanid.txt").First();
            string Guiid = File.ReadLines("AlarmGuiid.txt").First();
            ulong Gid = (ulong)Convert.ToInt64(Guiid);
            ulong Cha = (ulong)Convert.ToInt64(Chanid);
            channel = Global.Client.GetGuild(Gid).GetTextChannel(Cha);
            return Task.CompletedTask;
        }
        private static async void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            string waitingfor = File.ReadLines("Alarm.txt").First();
            string whomst = File.ReadLines("AlarmSetter.txt").First();
            string Datenow = DateTime.Now.ToString("dd-MM-yyyy");
            string Timenow = DateTime.Now.ToString("hh:mm" + " " + "tt", CultureInfo.InvariantCulture);
            string DTnow = Datenow + " | " + Timenow;
            Console.WriteLine(DTnow);
            if (DTnow == waitingfor)
            {
                await channel.SendMessageAsync("<@" + whomst + ">, it's now: "+DTnow);

                using (StreamWriter newTask = new StreamWriter("Alarm.txt", false))
                {
                    newTask.WriteLine("");
                }
                using (StreamWriter newTask = new StreamWriter("AlarmSetter.txt", false))
                {
                    newTask.WriteLine("");
                }
            }
        }
    }
}
