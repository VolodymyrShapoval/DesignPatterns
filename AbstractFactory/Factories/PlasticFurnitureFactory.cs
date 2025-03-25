using AbstractFactory.Interfaces;
using AbstractFactory.Models.Abstracts;
using AbstractFactory.Models.PlasticStyleModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class PlasticFurnitureFactory : IFurnitureFactory
    {
        public Bed CreateBed()
        {
            return new PlasticBed();
        }

        public Chair CreateChair()
        {
            return new PlasticChair();
        }

        public Sofa CreateSofa()
        {
            return new PlasticSofa();
        }
    }
}
