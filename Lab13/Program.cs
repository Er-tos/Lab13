using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите адрес здания: ");
            string address = Console.ReadLine();
            Console.Write("Введите длину здания: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ширину здания: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите высоту здания: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Building build = new Building(address, length, width, height);
            build.Print();
            Console.WriteLine("Введите этажность здания: ");
            int numOfFloors = Convert.ToInt32(Console.ReadLine());
            MultiBuilding multiBuilding = new MultiBuilding(address, length, width, height, numOfFloors);
            multiBuilding.Print();
            Console.ReadKey();
        }
    }
    class Building
    {
        int buildingLength;
        int buildingWidth;
        int buildingHeight;
        public string Address { set; get; }
        public int Length
        {
            set
            {
                if (value > 0)
                {
                    buildingLength = value;
                }
                else
                {
                    Console.WriteLine("Длина здания не может быть равной нулю!");
                    Console.ReadKey();
                    Environment.Exit(1);
                }
            }
            get
            {
                return buildingLength;
            }
        }
        public int Width
        {
            set
            {
                if (value > 0)
                {
                    buildingWidth = value;
                }
                else
                {
                    Console.WriteLine("Ширина здания не может быть равной нулю!");
                    Console.ReadKey();
                    Environment.Exit(1);
                }
            }
            get
            {
                return buildingWidth;
            }
        }
        public int Height
        {
            set
            {
                if (value > 0)
                {
                    buildingHeight = value;
                }
                else
                {
                    Console.WriteLine("Высота здания не может быть равной нулю!");
                    Console.ReadKey();
                    Environment.Exit(1);
                }
            }
            get
            {
                return buildingHeight;
            }
        }
        public Building(string address, int length, int width, int height)
        {
            Address = address;
            Length = length;
            Width = width;
            Height = height;
        }
        public void Print()
        {
            Console.WriteLine("Данное здания расположено по адресу: {0}, имеет длину {1} м, ширину {2} м и высоту {3} м.", Address, buildingLength, buildingWidth, buildingHeight);
        }
    }
    sealed class MultiBuilding : Building
    {
        int numberOfFloors;
        public int NumberOfFloors
        {
            set
            {
                if (value > 0)
                {
                    numberOfFloors = value;
                }
                else
                {
                    Console.WriteLine("Число этажей здания не может быть равным нулю!");
                    Console.ReadKey();
                    Environment.Exit(1);
                }
            }
            get
            {
                return numberOfFloors;
            }
        }
        public MultiBuilding(string address, int length, int width, int height, int floors)
            : base(address, length, width, height)
        {
            NumberOfFloors = floors;
        }
        public void Print()
        {
            MultiBuilding multi = new MultiBuilding(Address, Length, Width, Height, NumberOfFloors);
            Building build = multi;
            build.Print();
            Console.WriteLine("Этажность здания равна: {0}", NumberOfFloors);
        }
    }
}
