namespace SarsoBizDal
{
    public interface SarsoDal
    {
        IConnService ConnService { get; }

        IStocksModule StocksModule { get; }

        IAdminModule AdminModule { get; }

        IMemberModule MemberModule { get; }

        IShoppingModule ShoppingModule { get; }
    }
}
