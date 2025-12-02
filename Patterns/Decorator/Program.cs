namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISendable msg = new Message();
            msg.Send("kjf");

            ISendable telegramMessage = new TelegramSender(msg);
            telegramMessage.Send("Вставьте текст");

            ISendable whatsappMessage = new WhatsappSender(msg);
            whatsappMessage.Send("Удалите текст");
        }
    }
}
