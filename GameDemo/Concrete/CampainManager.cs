using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class CampainManager : ICampainService
    {
        public void Add()
        {
            Console.WriteLine("Yeni Kampanya Eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Kampanya Silindi");
        }

        public void Update()
        {
            Console.WriteLine("Kampanya Guncellendi");
        }
    }
}
