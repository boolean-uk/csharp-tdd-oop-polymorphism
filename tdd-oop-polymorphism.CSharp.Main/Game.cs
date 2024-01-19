using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Game : IObject
    {
        public int price { get; set; }
        public string name { get; set; }
    }
}
