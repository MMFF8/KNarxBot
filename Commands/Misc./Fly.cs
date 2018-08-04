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
    public class Fly : ModuleBase<SocketCommandContext>
    {
        [Command("Fly me to the moon")]
        public async Task Fmttm()
        {
            string accmode = File.ReadLines("Mode.txt").First();
            EmbedBuilder Embed = new EmbedBuilder();

            if (accmode == "Normal")
            {
                Embed.WithAuthor("Yuri Gagarin");
                Embed.WithDescription("In my fully refurbished Vostok 1?\nSure thing comrade!");
                Embed.WithColor(new Color(255, 0, 0));
                Embed.WithImageUrl("https://www.howitworksdaily.com/wp-content/uploads/2016/04/pb-110412-yuri-jm-10-1024x563.jpg");
            }
            if (accmode == "Tsundere")
            {
                Embed.WithAuthor("À̷̛͖͖͙̱͕̎̇̈̕͟ͅỹ̸̬͍̲͚̓̓̒͗̀̿͟a̛̦̭̱̺̳̝̳̞̎̽͊́͝n̶̡̼̫̦̱͈̮̬̞̊̓̄͠͠à̹̼̭̳̙͚̠̱͗͂̀̑̐͌͂̓͜ͅm͚̰̰̗̼̙̹͒̾̎͡͡ĭ̸̢̱͇͎͔̙̬̜̹͆̑͋̔̾͆͋̍͢͝ R̡̨̛̩̯̤͕̝͚̾͂̌̎̈̏̆͟ḛ̶͓̥̲͓̌͋͗͆̍̌̀͘͠i̬̲̳͈̜̇͑̑͑̄͊̚");
                Embed.WithDescription("ạ̸̦̫̤̖̬̘̿̅̃̑̋̒̚n̢̘̜͖̦͖͌͂̄̂͜͠͞d̴̨̨̠̥̪͔̯͗͂̈̇͒̀̍̃͛͆ ḻ̛̤̪͉͍̹̳̩͓̯̃͋͆̌͂̾͐̔͘ḛ̡͙̗͇̻͗́̈́̀̈́͌͛̒͌͝t̸̢͇̬͙͓̫̭͛̃̎̀͒͒͜͝ m̦̖̦̜̬͂̒͋̾͊̃̀̕͠e̥̮͚̘͕̼̞̙̓̉̀̔̓͒̂͠ p̺͖̺̰͔̗̻͔͋̈͊̆̅̕͘l̬̘̗͇͇͖̤̏̒͌͐̎̽̐̍͘͢͞ą̴̹̙̼͎̗̱̻̹̊͐͆̆̉̾̓͞͝y̷̨̠̩͙̻̯̤̤̓̈́̑̇̕͢͜͠ a̸̡͚͖͖̰̼̱̿̉̏̀̒͛̐m̸̢̘̬̬͎͕̰͒͂͊͂̽̊̿͜ó̶̫̰͔̙͉͖̇̑̇̕͞͝ͅn̷͚̬͙̲͇̎̓̑͑̓̒̅g̵̢̮̬̤̝̜͔̦̮̼͋̐̍̊̆͒̈́̽ t̡̗̝̤͉̝͚̜̺͈̋̔̓̉̌̍̓͗̏̄h̺̜͍̫͖̺̾̈́͐̒̓́̿̚͘͜ȩ̪͍͎͈̄͋̔͆͟͠ s̢͔̮̭̹͍̣̰͂̄̆͘͘t͓͎͍̠̫̮͍̻͇̑̋͌̂̾͂̋͆̔̍͟a̸͎̗̝͉̣̒͂͋̃̔͛̆̉ř̸̫̱̱̬͓̩̀̓̏̄͛͞ͅs͓͉̦̝̝̹̻͕͆̊̇̍̎̈̈͞...");
                Embed.WithColor(new Color(255, 115, 2));
                Embed.WithImageUrl("https://i.ytimg.com/vi/3TGrbeK5Fvk/maxresdefault.jpg");
            }
            if (accmode == "Yoda")
            {
                Embed.WithAuthor("Jedi Master Yoda");
                Embed.WithDescription("To the moon, this X-wing shall take you.");
                Embed.WithColor(new Color(0, 255, 0));
                Embed.WithImageUrl("https://vignette.wikia.nocookie.net/starwars/images/8/80/X-wing_Fathead.png/revision/latest?cb=20161004003846");
            }
            await Context.Channel.SendMessageAsync("", false, Embed.Build());
        }
    }
}