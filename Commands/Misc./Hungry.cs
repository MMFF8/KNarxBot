using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace Karl_Narx_V2.Modules
{
    public class Hungry : ModuleBase<SocketCommandContext>
    {
        Random rng;
        string[] food;
        [Command("I'm hungry")]
        public async Task wah()
        {
            rng = new Random();
            food = new string[]{
                "Pics/Food/Bread1.png",
                "Pics/Food/Bread2.jpg",
                "Pics/Food/Potato1.jpg",
                "Pics/Food/Potato2.jpg",
                "Pics/Food/Putin1.png",
                "Pics/Food/What1.png",
                "Pics/Food/Work1.png"
            };
            int frng = rng.Next(food.Length);
            string foodtpst = food[frng];
            await Context.Channel.SendFileAsync(foodtpst);
        }
    }
}
