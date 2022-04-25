using GameDemo.Entitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface IUserValidationService
    {
        bool Validate(GameCustomer gameCustomer);
    }
}
