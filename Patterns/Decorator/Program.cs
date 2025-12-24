namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Отправляем сообщение через базовый декоратор");
            ISendable msg = new Message();
            msg.Send("kjf");

            Console.WriteLine("\nОтправляем сообщение через Телеграм");
            ISendable telegramMessage = new TelegramSender(msg);
            telegramMessage.Send("Вставьте текст");

            Console.WriteLine("\nОтправляем сообщение через Ватсап");
            ISendable whatsappMessage = new WhatsappSender(msg);
            whatsappMessage.Send("Удалите текст");

            Console.WriteLine("\nПрограмма завершила работу. Поток заснул на 100 секунд");
            Thread.Sleep(100000);
        }
    }
}
