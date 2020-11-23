using System;


namespace SarsoBizDal
{
    public class SarsoBizsDal : SarsoDal
    {
        /// <summary>
        /// dl is object ref of ISsDal
        /// </summary>
        private static SarsoDal _dl;

        /// <summary>
        /// <c>dlLock is deablock object of SsDal</c>
        /// </summary>
        private static readonly Object Dllock = new Object();

        /// <summary>
        /// _connservice is object of Connection Service
        /// </summary>
        private static IConnService _connservice;
        private static IStocksModule _stocksservice;
        private static IAdminModule _adminservice;
        private static IMemberModule _memberservice;
        private static IShoppingModule _shoppingservice;

        private SarsoBizsDal()
        {
            _connservice = new ConnService();
            _stocksservice = new StocksModule();
            _adminservice = new AdminModule();
            _memberservice = new MemberModule();
            _shoppingservice = new ShoppingModule();
        }

        public static SarsoDal Instance
        {
            get
            {
                if (_dl == null)
                {
                    lock (Dllock)
                    {
                        if (_dl == null)
                        {
                            _dl = new SarsoBizsDal();
                        }
                    }
                }
                return _dl;
            }
        }
        public IConnService ConnService
        {
            get
            {
                return _connservice;
            }
        }
        public IStocksModule StocksModule
        {
            get
            {
                return _stocksservice;
            }
        }
        public IAdminModule AdminModule
        {
            get
            {
                return _adminservice;
            }
        }
        public IMemberModule MemberModule
        {
            get
            {
                return _memberservice;
            }
        }
        public IShoppingModule ShoppingModule
        {
            get
            {
                return _shoppingservice;
            }
        }
    }
}
