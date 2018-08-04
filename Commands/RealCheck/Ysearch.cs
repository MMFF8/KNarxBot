using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeSearch;

namespace Karl_Narx_V2.Modules
{
    public class Ysearch : ModuleBase<SocketCommandContext>
    {
        [Command("play:")]
        public async Task Yearch([Remainder]string message)
        {
            var items = new VideoSearch();
            string fvid = "Something went wrong";
            foreach (var item in items.SearchQuery(message, 1))
            {
                fvid = Convert.ToString(item.Url);
                break;
            }
            await Context.Channel.SendMessageAsync(fvid);
        }
    }
}
