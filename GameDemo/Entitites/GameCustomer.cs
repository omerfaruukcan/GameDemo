using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entitites
{
    public class GameCustomer
    {
        public int Id { get; set; }
        public long NationalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateOfBirth { get; set; }
    }
}
