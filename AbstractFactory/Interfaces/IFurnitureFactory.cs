using AbstractFactory.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Interfaces
{
    public interface IFurnitureFactory
    {
        Chair CreateChair();
        Sofa CreateSofa();
        Bed CreateBed();
    }
}
