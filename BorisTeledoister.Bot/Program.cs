using Telegram.Bot;

var botClient = new TelegramBotClient("6720611870:AAHotGmCioiGjv6QBIUfTjg80GYTrWOBUIs");
var me = await botClient.GetMeAsync();
Console.WriteLine($"Hello! My name is {me.FirstName} {me.LastName} ({me.Id}).");

botClient.StartReceiving<UpdateHandler>();

Console.WriteLine("Press any key to exit");
Console.ReadKey();
