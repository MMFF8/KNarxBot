using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord;

namespace Karl_Narx_V2.Modules
{
    public class Useless : ModuleBase<SocketCommandContext>
    {
        [Command("help-useless")]
        public async Task ulp()
        {
            EmbedBuilder Embed1 = new EmbedBuilder();
            Embed1.WithTitle("Useless Commands");
            Embed1.WithDescription
                ("Karl, I'm hungry\n" +
                "   *-Sends random socialist picture*\n\n" +
                "Karl, What is the specter that haunts Europe?\n   " +
                "   *-Reveals the secret behind the ghost*\n\n" +
                "Karl, Run democracy.exe\n" +
                "   *-Don't do it. (Chance to kick from server)*   " +
                "Karl, What time is it?\n" +
                "   *-Not to be confused for when is now*\n\n" +
                "Karl, Namae wa?\n" +
                "   *-Karl's secret weeb name*\n\n" +
                "Karl, Fly me to the moon\n" +
                "   *-Russian Rocket Power!*");
            Embed1.WithColor(new Color(255, 0, 0));

            await Context.Channel.SendMessageAsync("", false, Embed1.Build());
            await Context.Message.DeleteAsync();
        }
    }
}
