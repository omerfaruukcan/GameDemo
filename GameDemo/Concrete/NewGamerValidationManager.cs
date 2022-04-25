using GameDemo.Abstract;
using GameDemo.Entitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class NewGamerValidationManager : IUserValidationService
    {
        NewGamer _newGamer;
        OldGamer _oldGamer;

        public NewGamerValidationManager(OldGamer oldGamer)
        {
            _oldGamer = oldGamer;
        }

        public NewGamerValidationManager(NewGamer newGamer)
        {
            _newGamer = newGamer;
        }

        public bool Validate(GameCustomer gameCustomer)
        {
            if (gameCustomer == _newGamer)
            {
                if (_newGamer.DateOfBirth == 1998 && _newGamer.FirstName == "Omer Faruk")
                {
                    Console.WriteLine("Kaydiniz olusturulmustur.");
                    return true;
                }
                else
                {
                    Console.WriteLine("Bilgileriniz dogrulanamadi");
                    return false;
                }
            }
            else if (gameCustomer == _oldGamer)
            {
                Console.WriteLine("Böyle bir uyelik zaten bulunmaktadir.");
                return false;
            }
            else
            {
                Console.WriteLine("Hatali islem yaptiniz");
                return false;
            }
        }
    }
}
