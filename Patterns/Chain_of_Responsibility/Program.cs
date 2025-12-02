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

            balanceChecker.SetNextHandler(orderClaimer);
            havingInWareHouseChecker.SetNextHandler(balanceChecker);

            havingInWareHouseChecker.HandleRequest(commonUser);


            havingInWareHouseChecker.SetNextHandler(orderClaimer);
            havingInWareHouseChecker.HandleRequest(commonUser);

        }
    }
}
