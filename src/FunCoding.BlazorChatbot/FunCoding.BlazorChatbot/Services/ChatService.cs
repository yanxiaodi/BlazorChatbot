using Azure;
using Azure.AI.OpenAI;

namespace FunCoding.BlazorChatbot.Services;

public class ChatService : IChatService
{
    private readonly OpenAIClient _openAIClient;

    public ChatService(OpenAIClient openAiClient)
    {
        _openAIClient = openAiClient;
    }

    public Task<Response<StreamingChatCompletions>> GetChatCompletionsStreamingAsync(string deploymentOrModelName, ChatCompletionsOptions chatCompletionsOptions)
    {
        return _openAIClient.GetChatCompletionsStreamingAsync(deploymentOrModelName, chatCompletionsOptions);
    }

    public Task<Response<ChatCompletions>> GetChatCompletionsAsync(string deploymentOrModelName, ChatCompletionsOptions chatCompletionsOptions)
    {
        return _openAIClient.GetChatCompletionsAsync(deploymentOrModelName, chatCompletionsOptions);
    }

    public Task<Response<StreamingChatCompletions>> GetChatCompletionsStreamingAsync(string deploymentOrModelName, string message, List<ChatMessage> historyMessages)
    {
        var options = GetChatCompletionsOptions(message, historyMessages);
        return _openAIClient.GetChatCompletionsStreamingAsync(deploymentOrModelName, options);
    }

    private static ChatCompletionsOptions GetChatCompletionsOptions(string message, List<ChatMessage> historyMessages)
    {
        var messages = new List<ChatMessage> { new(ChatRole.User, message) };
        messages.AddRange(historyMessages);
        var options = new ChatCompletionsOptions()
        {
            Temperature = 0,
            MaxTokens = 350,
            NucleusSamplingFactor = (float)0.95,
            FrequencyPenalty = 0,
            PresencePenalty = 0,
        };
        foreach (var chatMessage in messages)
        {
            options.Messages.Add(chatMessage);
        }

        return options;
    }

    public Task<Response<ChatCompletions>> GetChatCompletionsAsync(string deploymentOrModelName, string message, List<ChatMessage> historyMessages)
    {
        var options = GetChatCompletionsOptions(message, historyMessages);
        return _openAIClient.GetChatCompletionsAsync(deploymentOrModelName, options);
    }
}
