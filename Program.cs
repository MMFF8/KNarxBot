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
            await _client.LoginAsync(Discord.TokenType.Bot, "Get your own token M8");
            await _client.StartAsync();
            _client.Ready += Timerer.StartTimer;
            await Task.Delay(-1);
            using (StreamWriter newTask = new StreamWriter("Mode.txt", false))
            {
                newTask.WriteLine("Normal");
            }
        }
    }
}
