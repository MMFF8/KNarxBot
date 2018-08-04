using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace Karl_Narx_V2
{
    class Commandler
    {
        private DiscordSocketClient _client;
        private CommandService _service;

        public Commandler(DiscordSocketClient client)
        {
            _client = client;
            _service = new CommandService();
            _service.AddModulesAsync(Assembly.GetEntryAssembly());
            _client.MessageReceived += CommandleAsync;
        }
        public async Task CommandleAsync(SocketMessage arg)
        {
            var msg = arg as SocketUserMessage;
            if (msg == null) return;
            var context = new SocketCommandContext(_client, msg);
            int argPos = 0;
            string accmode = File.ReadLines("Mode.txt").First();
            if (msg.HasStringPrefix("Karl, ", ref argPos))
            {
                if (accmode == "Normal")
                {
                    var result = await _service.ExecuteAsync(context, argPos);
                    if (!result.IsSuccess && result.ErrorReason != "The input text has too few parameters." && result.ErrorReason != "Index was outside the bounds of the array.")
                    {
                        await context.Channel.SendMessageAsync(result.ErrorReason + "... \"F\"");
                    }
                    if (!result.IsSuccess && result.ErrorReason == "The input text has too few parameters.")
                    {
                        await context.Channel.SendMessageAsync("Comrade... parameters please...");
                    }
                }
                if (accmode == "Tsundere")
                {
                    var result = await _service.ExecuteAsync(context, argPos);
                    if (!result.IsSuccess && result.ErrorReason != "The input text has too few parameters." && result.ErrorReason != "Index was outside the bounds of the array.")
                    {
                        await context.Channel.SendMessageAsync(result.ErrorReason + " Kono baka!");
                    }
                    if (!result.IsSuccess && result.ErrorReason == "The input text has too few parameters.")
                    {
                        await context.Channel.SendMessageAsync("Y-you try working with nothing! B-baka!");
                    }
                }
                if (accmode == "Yoda")
                {
                    var result = await _service.ExecuteAsync(context, argPos);
                    if (!result.IsSuccess && result.ErrorReason == "Unknown command.")
                    {
                        await context.Channel.SendMessageAsync("Unfamiliar with that command, I am.");
                    }
                    if (!result.IsSuccess && result.ErrorReason == "The input text has too few parameters.")
                    {
                        await context.Channel.SendMessageAsync("Not enough parameters, there are.");
                    }

                }
            }
        }
    }
}
