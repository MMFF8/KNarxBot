using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord;

namespace Karl_Narx_V2.Modules
{
    public class Help : ModuleBase<SocketCommandContext>
    {
        [Command("help")]
        public async Task democracy()
        {
            EmbedBuilder Embed1 = new EmbedBuilder();
            Embed1.WithTitle("Karl, Help-useless");
            Embed1.WithDescription
                ("   *-They don't really do anything*   ");
            Embed1.WithColor(new Color(255, 0, 0));

            EmbedBuilder Embed2 = new EmbedBuilder();
            Embed2.WithTitle("Karl, help-stringedit");
            Embed2.WithDescription
                ("   *-Takes your strings, and edits them duh*   ");
            Embed2.WithColor(new Color(255, 225, 0));

            EmbedBuilder Embed3 = new EmbedBuilder();
            Embed3.WithTitle("Karl, help-rng");
            Embed3.WithDescription
                ("   *-Straight from RNJesus himself*   ");
            Embed3.WithColor(new Color(255, 0, 0));


            EmbedBuilder Embed4 = new EmbedBuilder();
            Embed4.WithTitle("Karl, help-realtime");
            Embed4.WithDescription
                ("   *-Checks something real in realtime*   ");
            Embed4.WithColor(new Color(255, 225, 0));


            EmbedBuilder Embed5 = new EmbedBuilder();
            Embed5.WithTitle("Karl, help-accents");
            Embed5.WithDescription
                ("   *-For when you're sick of hearing \"comrade\"*   ");
            Embed5.WithColor(new Color(255, 0, 0));

            await Context.Channel.SendMessageAsync("", false, Embed1.Build());
            await Context.Channel.SendMessageAsync("", false, Embed2.Build());
            await Context.Channel.SendMessageAsync("", false, Embed3.Build());
            await Context.Channel.SendMessageAsync("", false, Embed4.Build());
            await Context.Channel.SendMessageAsync("", false, Embed5.Build());
            await Context.Message.DeleteAsync();
        }
    }
}
