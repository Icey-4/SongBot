using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using TextCommandFramework.Services;

namespace TextCommandFramework
{
    // This is a minimal example of using Discord.Net's command
    // framework - by no means does it show everything the framework
    // is capable of.
    //
    // You can find samples of using the command framework:
    // - Here, under the 02_commands_framework sample
    // - https://github.com/foxbot/DiscordBotBase - a bare-bones bot template
    // - https://github.com/foxbot/patek - a more feature-filled bot, utilizing more aspects of the library
  public class Program
  {
  	public static Task Main(string[] args) => new Program().MainAsync();
  
  	public async Task MainAsync()
  	{
  	}
  }
private Task Log(LogMessage msg)
{
	Console.WriteLine(msg.ToString());
	return Task.CompletedTask;
}
}
private DiscordSocketClient _client;

public async Task MainAsync()
{
    _client = new DiscordSocketClient();

    _client.Log += Log;

    //  You can assign your bot token to a string, and pass that in to connect.
    //  This is, however, insecure, particularly if you plan to have your code hosted in a public repository.

    // Some alternative options would be to keep your token in an Environment Variable or a standalone file.
    var token = Environment.GetEnvironmentVariable("TOKEN");
    // var token = File.ReadAllText("token.txt");
    // var token = JsonConvert.DeserializeObject<AConfigurationClass>(File.ReadAllText("config.json")).Token;

    await _client.LoginAsync(TokenType.Bot, token);
    await _client.StartAsync();

    // Block this task until the program is closed.
    await Task.Delay(-1);
}
