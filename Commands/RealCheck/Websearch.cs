using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord;
using System.Xml;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace Karl_Narx_V2.Modules
{
    public class Websearch : ModuleBase<SocketCommandContext>
    {
        [Command("Control F:")]
        public async Task ctrlf([Remainder]string message)
        {
            string[] result = message.Split(new string[] { " from " }, StringSplitOptions.None);
            string URL = result[1];
            string Kword = result[0];

            using (WebClient client = new WebClient())
            {

                using (StreamWriter newTask = new StreamWriter("Webf.txt", false))
                {
                    newTask.WriteLine(client.DownloadString("http://www." + URL).ToString());
                }

                string[] txt = File.ReadAllLines("Webf.txt");
                int vtxt = 0;
                int count = txt.Length;
                for (int x = 0; x < count; x++)
                {
                    if (txt[x].Contains(Kword) == true)
                    {
                        vtxt = vtxt+1;
                    }
                }
                string numinst = vtxt.ToString();
                EmbedBuilder Embed = new EmbedBuilder();
                string accmode = File.ReadLines("Mode.txt").First();

                if (accmode == "Normal")
                {
                    Embed.WithTitle("Number of instances of \"" + Kword + "\" from \"" + URL + "\":");
                    Embed.WithDescription(numinst);
                    Embed.WithColor(new Color(255, 255, 0));
                }
                if (accmode == "Tsundere")
                {
                    Embed.WithTitle("Hmph! Find all the \"" + Kword + "\"'s from \"" + URL + "\" yourself next time!");
                    Embed.WithDescription(numinst);
                    Embed.WithColor(new Color(254, 127, 156));
                }
                if (accmode == "Yoda")
                {
                    Embed.WithTitle("From \"" + URL + "\", the number of \"" + Kword + "\"'s this is:");
                    Embed.WithDescription(numinst);
                    Embed.WithColor(new Color(255, 255, 0));
                }

                await Context.Channel.SendMessageAsync("", false, Embed.Build());
                await Context.Message.DeleteAsync();
            }
        }
    }
}