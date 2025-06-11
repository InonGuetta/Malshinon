using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Malshinon.DAL;
using Malshinon.service;

namespace Malshinon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuSERVICE menu = new MenuSERVICE();
            menu.Menu();
        }
    }
}
