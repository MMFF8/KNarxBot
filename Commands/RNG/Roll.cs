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
    public class Roll : ModuleBase<SocketCommandContext>
    {
        Random rng;
        [Command("!roll")]
        public async Task GayOsu([Remainder] string message)
        {
            rng = new Random();
            int max = 0;

            int checker;
            if (int.TryParse(message, out checker))
            {
                max = Int32.Parse(message);
            }
            else
            {
                string[] broke = message.Split(' ');
                List<int> numbs = new List<int>();
                string operation = "";
                int count = broke.Length;
                for (int x = 0; x < count; x++)
                {
                    if (broke[x].Contains("+") | broke[x].Contains("-") | broke[x].Contains("/") | broke[x].Contains("*") == true)
                    {
                        operation = broke[x];
                    }
                    else
                    {
                        numbs.Add(Int32.Parse(broke[x]));
                    }
                }
                if (operation == "+") { max = numbs.First() + numbs.Last(); }
                if (operation == "-") { max = numbs.First() - numbs.Last(); }
                if (operation == "*") { max = numbs.First() * numbs.Last(); }
                if (operation == "/") { max = numbs.First() / numbs.Last(); }
            }
            

            string msgval = max.ToString();
            int osu = rng.Next(max + 1);
            string rollval = osu.ToString();
            int luck = 0;
            string verdict = "";
            if (osu >= max * 0.00) { luck = 6; }
            if (osu >= max * 0.01 && osu <= max * 0.39) { luck = 0; }
            if (osu >= max * 0.40 && osu <= max * 0.60) { luck = 1; }
            if (osu >= max * 0.61 && osu <= max * 0.80) { luck = 2; }
            if (osu >= max * 0.81 && osu <= max * 0.90) { luck = 3; }
            if (osu >= max * 0.91 && osu <= max * 0.99) { luck = 4; }
            if (osu >= max) { luck = 5; }

            string accmode = File.ReadLines("Mode.txt").First();

            if (accmode == "Normal")
            {
                if (luck == 0) { verdict = "Oof. Miss me with that weak sh*t."; }
                if (luck == 1) { verdict = "Meh."; }
                if (luck == 2) { verdict = "That was pretty average my friend."; }
                if (luck == 3) { verdict = "Well played comrade."; }
                if (luck == 4) { verdict = "Oh... Well then..."; }
                if (luck == 5) { verdict = "What... How did you do that..."; }
                if (luck == 6) { verdict = "You... you're on a whole other level..."; }
            }
            if (accmode == "Yoda")
            {
                if (luck == 0) { verdict = "A weak roll, that was..."; }
                if (luck == 1) { verdict = "Much, much more to learn, you have."; }
                if (luck == 2) { verdict = "Potential, I see in your rolls."; }
                if (luck == 3) { verdict = "Intrigued I am, in your Midicholrian count."; }
                if (luck == 4) { verdict = "Strong in the ways of the force, you are."; }
                if (luck == 5) { verdict = "A powerful Jedi, you must be!"; }
                if (luck == 6) { verdict = "Strong you are, with the dark side of the force..."; }
            }
            if (accmode == "Tsundere")
            {
                if (luck == 1 || luck == 0) { verdict = "HAHAH! YOU'RE PATHETIC " + Context.User.Username + "-KUN!"; }
                if (luck == 3 || luck == 2) { verdict = "I-I could do waaay better then that, even with my eyes closed!"; }
                if (luck == 4) { verdict = "Hmph... Th-that was a half decent roll, se-senpai..."; }
                if (luck == 5) { verdict = "KUSO! KONO BAKA! SHINE!"; }
                if (luck == 6) { verdict = "HAA! Zero, just like your IQ, baka " + Context.User.Username + "-kun!"; }
            }

            string maxroll = max.ToString();

            EmbedBuilder Embed = new EmbedBuilder();

            if (accmode == "Normal")
            {
                Embed.WithAuthor("RNJesus", "https://steamuserimages-a.akamaihd.net/ugc/863990463443752232/D856E7412B9BF2C14FD328693FEB7F24CF0DA9E0/?interpolation=lanczos-none&output-format=jpeg&output-quality=95&fit=inside%7C268%3A268&composite-to=*,*%7C268%3A268&background-color=black");
                Embed.WithDescription(Context.User.Username + " rolled " + rollval + " out of " + maxroll + ". " + verdict);
                Embed.WithColor(new Color(255, 50, 0));
            }
            if (accmode == "Tsundere")
            {
                Embed.WithAuthor("RNJesus-chan", "https://steamuserimages-a.akamaihd.net/ugc/863990463443752232/D856E7412B9BF2C14FD328693FEB7F24CF0DA9E0/?interpolation=lanczos-none&output-format=jpeg&output-quality=95&fit=inside%7C268%3A268&composite-to=*,*%7C268%3A268&background-color=black");
                Embed.WithDescription(Context.User.Username + " senpai rolled " + rollval + " out of " + maxroll + ". " + verdict);
                Embed.WithColor(new Color(254, 127, 156));
            }
            if (accmode == "Yoda")
            {
                Embed.WithAuthor("RN\"Force-Jesus\"", "https://steamuserimages-a.akamaihd.net/ugc/863990463443752232/D856E7412B9BF2C14FD328693FEB7F24CF0DA9E0/?interpolation=lanczos-none&output-format=jpeg&output-quality=95&fit=inside%7C268%3A268&composite-to=*,*%7C268%3A268&background-color=black");
                Embed.WithDescription("Rolled " + rollval + " out of " + maxroll + ", " + Context.User.Username + " has. " + verdict);
                Embed.WithColor(new Color(0, 255, 0));
            }

            await Context.Channel.SendMessageAsync("", false, Embed.Build());

        }
    }
}