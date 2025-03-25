using AbstractFactory.Factories;
using AbstractFactory.Models.Abstracts;
using AbstractFactory.Models.OakStyleModels;
using AbstractFactory.Models.PlasticStyleModels;

namespace AbstractFactory
{
    class Program
    {
        private static ushort GetFurnitureStyle()
        {
            Console.WriteLine("1. Oak");
            Console.WriteLine("2. Plastic");
            Console.Write("Choose style for furniture: ");
            return ushort.Parse(Console.ReadLine());
        }

        private static ushort GetFurnitureType()
        {
            Console.WriteLine("1. Chair");
            Console.WriteLine("2. Sofa");
            Console.WriteLine("3. Bed");
            Console.Write("Choose type of furniture: ");
            return ushort.Parse(Console.ReadLine());
        }

        public static void Main(string[] args)
        {
            ushort styleNum = GetFurnitureStyle();
            ushort typeNum = GetFurnitureType();

            switch (styleNum)
            {
                case 1:
                    OakFurnitureFactory oakFactory = new OakFurnitureFactory();
                    switch (typeNum)
                    {
                        case 1:
                            oakFactory.CreateChair().DisplayInfo();
                            break;
                        case 2:
                            oakFactory.CreateSofa().DisplayInfo(); 
                            break;
                        case 3:
                            oakFactory.CreateBed().DisplayInfo();
                            break;
                    }
                    break;
                case 2:
                    PlasticFurnitureFactory plasticFactory = new PlasticFurnitureFactory();
                    switch (typeNum)
                    {
                        case 1:
                            plasticFactory.CreateChair().DisplayInfo();
                            break;
                        case 2:
                            plasticFactory.CreateSofa().DisplayInfo();
                            break;
                        case 3:
                            plasticFactory.CreateBed().DisplayInfo();
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
