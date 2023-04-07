using Azure;
using Azure.AI.OpenAI;
using FunCoding.BlazorChatbot;
using FunCoding.BlazorChatbot.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton(new OpenAIClient(new Uri("Your endpoint"), new AzureKeyCredential("Your key")));
builder.Services.AddSingleton<IChatService, ChatService>();
await builder.Build().RunAsync();
