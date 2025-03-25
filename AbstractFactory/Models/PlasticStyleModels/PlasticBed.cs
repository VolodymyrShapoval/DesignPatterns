using AbstractFactory.Interfaces;
using AbstractFactory.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Models.PlasticStyleModels
{
    public class PlasticBed : Bed
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("This is a plastic bed");
        }
    }
}
