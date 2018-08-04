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
    public class Tsun : ModuleBase<SocketCommandContext>
    {
        [Command("Tsundere mode")]
        public async Task Tsunnn()
        {
            string cmode = File.ReadLines("Mode.txt").First();
            if (cmode != "Tsundere")
            {
                using (StreamWriter newTask = new StreamWriter("Mode.txt", false))
                {
                    newTask.WriteLine("Tsundere");
                }
                await Context.Channel.SendMessageAsync("I-I'm not doing this cause you told me to... B-Baka!");
            }
            else
            {
                await Context.Channel.SendMessageAsync("I-I'm not a Tsundere!!! KONO BAKA BAKA!!!");
            }
        }
    }
}
