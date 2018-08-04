using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord;
using System.IO;
using System.Collections;

namespace Karl_Narx_V2.Modules
{
    public class RFire : ModuleBase<SocketCommandContext>
    {

        [Command("Fire")]
        public async Task bang()
        {
            string[] ord = File.ReadAllLines("RChamber.txt");
            for (var i = 0; i < ord.Length; i += 1)
            {
                var line = ord[i];
            }

            string numstr = File.ReadLines("Shotnum.txt").First();
            int num = Int32.Parse(numstr);
            string order = string.Join("", ord);
            string[] result = order.Split(new string[] { "!" }, StringSplitOptions.None);
            string bout = result[num];

            if (num < result.Length-1)
            {
                num = num + 1;
                using (StreamWriter newTask = new StreamWriter("Shotnum.txt", false))
                {
                    newTask.WriteLine(num.ToString());
                }

                EmbedBuilder Embed = new EmbedBuilder();
                Embed.WithAuthor(Context.Message.Author.Username, Context.Message.Author.GetAvatarUrl());
                Embed.WithTitle("Shot: "+num);
                Embed.WithDescription(bout);
                Embed.WithColor(new Color(255, 255, 0));
                await Context.Channel.SendMessageAsync("", false, Embed.Build());
                await Context.Message.DeleteAsync();
            }
            else
            {
                EmbedBuilder Embed = new EmbedBuilder();
                Embed.WithAuthor("Karl", "https://cdn.discordapp.com/app-icons/462640586042638367/acef2f15ed1c33f043b5f62470250fed.png");
                Embed.WithDescription("Comerade, that's all "+(result.Length-1));
                Embed.WithColor(new Color(255, 0, 0));

                await Context.Channel.SendMessageAsync("", false, Embed.Build());
                await Context.Message.DeleteAsync();
            }
        }
        
    }
}
