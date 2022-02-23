using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Gateway;

namespace Rector
{
    internal class Program
    {

        public static DiscordSocketClient clientd = new DiscordSocketClient();
        static void Main(string[] args)
        {
            Connect();
            Console.ReadKey();
        }

        private async static void Clientd_OnMessageReceived(DiscordSocketClient client, MessageEventArgs args)
        {
            await args.Message.AddReactionAsync("\uD83D\uDE00");
        }

        static async void Connect()
        {
            await Task.Run(() =>
            {
                clientd = new DiscordSocketClient(new DiscordSocketConfig() { RetryOnRateLimit = false });
                clientd.Login("MzkwOTYzMTYzNzAyNzU1MzI4.YhY10g.5Crz6P78FS8jujqTpCd8FqR7HQI");
            });
            Console.WriteLine("Logged");
            clientd.OnMessageReceived += Clientd_OnMessageReceived;
        }
    }
}
