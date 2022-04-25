using GameDemo.Entitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface ISalesService
    {
        void Buy(Game game);
        void BuyAtDiscount(Game game, GameCustomer gameCustomer);
    }
}
