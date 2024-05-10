using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;

internal class UpdateHandler : IUpdateHandler
{
    public Task HandleUpdateAsync(
        ITelegramBotClient botClient,
        Update update,
        CancellationToken cancellationToken
    )
    {
        Console.WriteLine(update.Type);
        if (update != null && update.Message != null)
        {
            string value = $"Received update: {update?.Id} ({update?.Message?.Text})";
            Console.WriteLine(value);

            botClient.SendTextMessageAsync(
                update.Message.Chat,
                value,
                cancellationToken: cancellationToken
            );
        }
        return Task.CompletedTask;
    }

    public Task HandlePollingErrorAsync(
        ITelegramBotClient botClient,
        Exception exception,
        CancellationToken cancellationToken
    )
    {
        Console.WriteLine(exception);
        return Task.CompletedTask;
    }
}
