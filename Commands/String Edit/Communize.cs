using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord;

namespace Karl_Narx_V2.Modules
{
    public class Communize : ModuleBase<SocketCommandContext>
    {
        [Command("commspeak:")]
        public async Task filter([Remainder]string message)
        {
            string input = message;
            string[] result = input.Split(new string[] { " " }, StringSplitOptions.None);
            string translate;
            int count = result.Length;
            for (int x = 0; x < count; x++)
            {
                if ((string)result[x] == "I" && x == 0)
                {
                    result[x] = "We";
                }
                if ((string)result[x] == "I." && x == 0)
                {
                    result[x] = "We.";
                }
                    if ((string)result[x] == "I" && x >= 1)
                {
                    result[x] = "we";
                }
                if ((string)result[x] == "I." && x >= 1)
                {
                    result[x] = "we.";
                }


                if ((string)result[x] == "I've" && x == 0)
                {
                    result[x] = "We've";
                }
                if ((string)result[x] == "I've" && x >= 0)
                {
                    result[x] = "we've";
                }
                if ((string)result[x] == "I'm" && x == 0)
                {
                    result[x] = "We're";
                }
                if ((string)result[x] == "I'm" && x >= 0)
                {
                    result[x] = "we're";
                }


                if ((string)result[x] == "mine")
                {
                    result[x] = "ours";
                }
                if ((string)result[x] == "my")
                {
                    result[x] = "our";
                }
                if ((string)result[x] == "me")
                {
                    result[x] = "us";
                }


                if ((string)result[x] == "Mine")
                {
                    result[x] = "Ours";
                }
                if ((string)result[x] == "My")
                {
                    result[x] = "Our";
                }
                if ((string)result[x] == "Me")
                {
                    result[x] = "Us";
                }


                if ((string)result[x] == "mine.")
                {
                    result[x] = "ours.";
                }
                if ((string)result[x] == "my.")
                {
                    result[x] = "our.";
                }
                if ((string)result[x] == "me.")
                {
                    result[x] = "us.";
                }
            }

            translate = string.Join(" ", result);

            EmbedBuilder Embed = new EmbedBuilder();
            Embed.WithAuthor(Context.User.Username, Context.User.GetAvatarUrl());
            Embed.WithDescription(translate);
            Embed.WithColor(new Color(255, 0, 0));
            

            await Context.Channel.SendMessageAsync("", false, Embed.Build());
            await Context.Message.DeleteAsync();
        }
    }
}