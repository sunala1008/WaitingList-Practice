namespace WaitingList.Data
{
    class DB
    {
        static DB()
        {
            Customer = new CustomerData();
        }

        public static CustomerData Customer { get; }
    }
}
