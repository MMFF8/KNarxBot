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
    public class Yoda : ModuleBase<SocketCommandContext>
    {
        [Command("Yoda mode")]
        public async Task adoY()
        {
            string cmode = File.ReadLines("Mode.txt").First();
            if (cmode != "Yoda")
            {
                using (StreamWriter newTask = new StreamWriter("Mode.txt", false))
                {
                    newTask.WriteLine("Yoda");
                }
                await Context.Channel.SendMessageAsync("Talk backwards now, I will");
            }
            else
            {
                await Context.Channel.SendMessageAsync("What do you mean? Normal, my speaking is.");
            }
        }
    }
}
