using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord;

namespace Karl_Narx_V2.Modules
{
    public class Democ : ModuleBase<SocketCommandContext>
    {
        Random rng;
        [Command("run democracy.exe")]
        public async Task dont()
        {
            rng = new Random();
            int[] chance = new int[]
            {1,2};
            int crng = rng.Next(chance.Length);
            int verd = chance[crng];
            string verds = verd.ToString();
            await Context.Channel.SendMessageAsync("Are you retarded?");
        }
    }
}
