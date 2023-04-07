using Azure;
using Azure.AI.OpenAI;

namespace FunCoding.BlazorChatbot.Services;

public interface IChatService
{
    Task<Response<StreamingChatCompletions>> GetChatCompletionsStreamingAsync(string deploymentOrModelName, ChatCompletionsOptions chatCompletionsOptions);
    Task<Response<ChatCompletions>> GetChatCompletionsAsync(string deploymentOrModelName, ChatCompletionsOptions chatCompletionsOptions);

    Task<Response<StreamingChatCompletions>> GetChatCompletionsStreamingAsync(string deploymentOrModelName, string message, List<ChatMessage> historyMessages);
    Task<Response<ChatCompletions>> GetChatCompletionsAsync(string deploymentOrModelName, string message, List<ChatMessage> historyMessages);
}
