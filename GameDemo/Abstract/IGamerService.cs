using GameDemo.Entitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface IGamerService
    {
        void SignUp(GameCustomer gameCustomer);
        void Update(OldGamer gamer);
        void Delete(OldGamer gamer);
    }
}
