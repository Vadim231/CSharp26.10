using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp25._10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
            new User
            {
               Name = "Vadim",
               Age = 17
               },

            new User
            {
               Name = "Vadim2",
               Age = 18
               }
            };

            List<Computer> computers = new List<Computer>
            {
            new Computer
            {
               Row = 1,
               Number = 17
               },

            new Computer
            {
               Row = 2,
               Number = 18
               }
            };

            List<Сabinet> cabinets = new List<Сabinet>
            {
            new Сabinet
            {
               Floor = 2,
               Number = 206
               },

            new Сabinet
            {
               Floor = 3,
               Number = 305
               }
            };
        }
    }
}
