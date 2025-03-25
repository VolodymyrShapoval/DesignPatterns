using AbstractFactory.Interfaces;
using AbstractFactory.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Models.OakStyleModels
{
    public class OakSofa : Sofa
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("This is an oak sofa");
        }
    }
}
