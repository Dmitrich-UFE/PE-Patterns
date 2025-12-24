namespace Chain_of_Responsibility
{
    internal class Program
    {
        //Обработка заказа в маркетплейсе
        static void Main(string[] args)
        {
            Good banana = new Good("Банан", 310);
            Good banana2 = new Good("Банан", 140);

            Warehouse warehouse = new Warehouse(banana2);

            User commonUser = new User(150, banana2);


            Handler orderClaimer = new OrderClaimer();
            Handler balanceChecker = new BalanceChecker();
            Handler havingInWareHouseChecker = new HavingInWareHouseChecker(warehouse);

            Console.WriteLine("Баланс пользователя: 150. Проверяемый товар: банан с ценой 140\n");

            Console.WriteLine("Обработка заказа: проверка наличия товара на складе и баланса пользователя");
            balanceChecker.SetNextHandler(orderClaimer);
            havingInWareHouseChecker.SetNextHandler(balanceChecker);

            havingInWareHouseChecker.HandleRequest(commonUser);

            Console.WriteLine("\nПроверка только наличия товара на складе");
            havingInWareHouseChecker.SetNextHandler(orderClaimer);
            havingInWareHouseChecker.HandleRequest(commonUser);

            Console.WriteLine("\nПрограмма завершила работу. Поток заснул на 100 секунд");
            Thread.Sleep(100000);
        }
    }
}
