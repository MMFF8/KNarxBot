using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord;

namespace Karl_Narx_V2.Modules
{
    public class Say : ModuleBase<SocketCommandContext>
    {
        Random rng;
        string[] pfp;
        [Command("say:")]
        public async Task forward([Remainder]string message)
        {
            rng = new Random();
            pfp = new string[]{
                "https://res-2.cloudinary.com/crunchbase-production/image/upload/c_thumb,h_120,w_120,f_auto,g_faces,z_0.7,b_white,q_auto:eco/v1506011067/nebrqlxufjmuayojxcll.jpg",
                "https://pbs.twimg.com/profile_images/624831365733748737/p4sgy0OP_400x400.jpg",
                "https://img.fireden.net/v/image/1445/79/1445791005003.png",
                "https://pbs.twimg.com/profile_images/633358750846332929/X32WqqfH_400x400.jpg",
                "https://pbs.twimg.com/profile_images/701642871514988544/nMvG4HY8_400x400.jpg",
                "https://pbs.twimg.com/profile_images/378800000105967514/efbc1a383c96933893ebc5290172588c.jpeg",
                "https://i.kym-cdn.com/entries/icons/square/000/001/308/ade.gif",
                "https://pbs.twimg.com/profile_images/591271389312716802/jtGhadzQ_400x400.jpg"

            };
            int prng = rng.Next(pfp.Length);
            string pfptp = pfp[prng];

            EmbedBuilder Embed = new EmbedBuilder();
            Embed.WithThumbnailUrl(pfptp);
            Embed.WithAuthor("The Voice of Reason");
            Embed.WithDescription("*"+message+"*    ");
            Embed.WithColor(new Color(255, 0, 0));
            

            await Context.Channel.SendMessageAsync("", false, Embed.Build());
            await Context.Message.DeleteAsync();
        }
    }
}
