using QuizBot.BLL.Interfaces;
using Telegram.Bot;

namespace QuizBot.BLL.Services
{
    public class MessangerService : IMessangerService
    {
        private readonly IQuestionService _questionService;
        private readonly TelegramBotClient _botClient;

        public MessangerService(
            IQuestionService questionService,
            TelegramBotClient telegramBotClient)
        {
            _questionService = questionService;
            _botClient = telegramBotClient;
        }

        public async Task ListenForMessagesAsync() 
        {
        
        }
    }
}
