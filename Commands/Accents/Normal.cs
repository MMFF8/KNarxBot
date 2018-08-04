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
    public class Normal : ModuleBase<SocketCommandContext>
    {
        [Command("Normal mode")]
        public async Task norm()
        {
            string cmode = File.ReadLines("Mode.txt").First();
            if (cmode != "Normal")
            {
                using (StreamWriter newTask = new StreamWriter("Mode.txt", false))
                {
                    newTask.WriteLine("Normal");
                }
                await Context.Channel.SendMessageAsync("Feels good to be me again comrade.");
            }
            else
            {
                await Context.Channel.SendMessageAsync("I am already myself comrade.");
            }
        }
    }
}
