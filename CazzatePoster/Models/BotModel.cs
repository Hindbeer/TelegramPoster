using System.Windows;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace CazzatePoster.Models
{
    class BotModel
    { 
        public async void SendMessage(string text, string token, string chatId)
        {
            TelegramBotClient _botClient = new TelegramBotClient(token);

            try
            {
                await _botClient.SendTextMessageAsync(
                    chatId: chatId,
                    text: text,
                    parseMode: ParseMode.MarkdownV2);
            }
            catch
            {
                MessageBox.Show("An error has occurred! \nCheck your settings", "Error");
            }

        }
    }
}
