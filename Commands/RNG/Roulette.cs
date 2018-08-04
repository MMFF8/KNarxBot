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
    public class Roulette : ModuleBase<SocketCommandContext>
    {

        [Command("Load the Revolver")]
        public async Task rld()
        {
            string[] barrel = new string[]
            {"empty!", "empty!", "empty!", "empty!", "empty!", "loaded!"};

            Random rnd = new Random();
            string[] Shotorder = barrel.OrderBy(x => rnd.Next()).ToArray();
            string ord = string.Join(" ", Shotorder);

            int num=0;

            using (StreamWriter newTask = new StreamWriter("Shotnum.txt", false))
            {
                newTask.WriteLine(num.ToString());
            }

            using (StreamWriter newTask = new StreamWriter("RChamber.txt", false))
            {
                newTask.WriteLine(ord.ToString());
            }

            EmbedBuilder Embed = new EmbedBuilder();
            Embed.WithAuthor("Karl", "https://cdn.discordapp.com/app-icons/462640586042638367/acef2f15ed1c33f043b5f62470250fed.png");
            Embed.WithDescription("Revolver's loaded comrade... I wish you best of luck");
            Embed.WithColor(new Color(255, 0, 0));
            Embed.WithThumbnailUrl("https://techcrunch.com/wp-content/uploads/2018/04/apple_ios10_emoji_waterpistol.png?w=320");
            await Context.Channel.SendMessageAsync("", false, Embed.Build());
        }
        
    }
}
