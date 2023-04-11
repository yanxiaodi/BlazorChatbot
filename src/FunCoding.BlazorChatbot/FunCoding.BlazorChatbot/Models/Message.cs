using Azure.AI.OpenAI;
using Markdig;

namespace FunCoding.BlazorChatbot.Models;

public class Message : ChatMessage
{
    public DateTime DateTime { get; set; }
    public Guid Id { get; set; }

    public string HtmlContent => Markdown.ToHtml(Content);
    public Message(ChatRole role, string content, DateTime dateTime, Guid id) : base(role, content)
    {
        DateTime = dateTime;
        Id = id;
    }
}
