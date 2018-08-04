using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karl_Narx_V2
{ 
    public class Program
    {
        static void Main(string[] args)
        => new Program().StartAsync().GetAwaiter().GetResult();
        private DiscordSocketClient _client;
        public async Task StartAsync()
        {  
            _client = new DiscordSocketClient(new DiscordSocketConfig { });
            Global.Client = _client;
            new Commandler(_client);
            await _client.LoginAsync(Discord.TokenType.Bot, "NDYyNjQwNTg2MDQyNjM4MzY3.Dh5Ylw.GvT2DRceHapPVy1b5CGkd9B9WVk");
            await _client.StartAsync();
            _client.Ready += Timerer.StartTimer;
            await Task.Delay(-1);
        }
    }
}
