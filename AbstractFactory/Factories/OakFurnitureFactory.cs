using AbstractFactory.Interfaces;
using AbstractFactory.Models.Abstracts;
using AbstractFactory.Models.OakStyleModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class OakFurnitureFactory : IFurnitureFactory
    {
        public Bed CreateBed()
        {
            return new OakBed();
        }

        public Chair CreateChair()
        {
            return new OakChair();
        }

        public Sofa CreateSofa()
        {
            return new OakSofa();
        }
    }
}
