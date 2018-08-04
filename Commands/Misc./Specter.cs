using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord;

namespace Karl_Narx_V2.Modules
{
    public class Specter : ModuleBase<SocketCommandContext>
    {
        [Command("What is the specter that haunts Europe?")]
        public async Task Spec()
        {
            EmbedBuilder Embed = new EmbedBuilder();
            Embed.WithAuthor("Karl Marx");
            Embed.WithDescription("A specter is haunting Europe—the specter of Communism. All the powers of old Europe have entered into a holy alliance to exorcise this specter; Pope and Czar, Metternich and Guizot, French radicals and German police spies. Where is the party in opposition that has not been decried as Communistic by its opponents in power ? Where the opposition that has not hurled back the branding reproach of Communism, against the more advanced opposition parties, as well as against its reactionary adversaries? Two things result from this fact. Communism is already acknowledged by all European powers to be in itself a power, and it is high time that Communists should openly, in the face of the whole world, publish their views, their aims, their tendencies, and meet this nursery tale of the Specter of Communism with a Manifesto of the party itself");
            Embed.WithColor(new Color(255, 255, 0));
            Embed.WithImageUrl("https://i.redd.it/fbkod16bm6hx.jpg");

            await Context.Channel.SendMessageAsync("", false, Embed.Build());
        }
    }
}
