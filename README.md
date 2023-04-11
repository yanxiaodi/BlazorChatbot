# BlazorChatbot

A chatbot using Azure OpenAI and Blazor. This is a demo project with minimal functionality. It is just for your personal use. No UI framework is used. Feel free to apply your own UI framework.

## How to use

1. Create an Azure OpenAI account and get your API key.
2. Update the `Program.cs` file with your API key and endpoint.
3. Update the model name in the `Index.razor` file.
4. Update the model configuration in the `ChatService.cs` file.
5. Run the project.

![BlazorChatbot](/chat.png)

Note: the messages are not stored in the database. If you restart the project, the messages will be lost.

## Future work

- [ ] Add a database to store the messages.
- [x] Add a UI framework.
- [ ] Support multiple models.
- [ ] Support model configuration.
- [ ] Message management.
- [ ] Add some example prompts.
- [ ] Support markdown in the messages.

Thanks.
