using System;
using System.Collections.Generic;

namespace flower
{
    class Program
    {
        static void Main(string[] args)
        {
            var flowerNumber =  InpputFlowerAmount();

            int rose_Num = flowerNumber.Item1;
            int sf_Num = flowerNumber.Item2;

            List<Rose> roseList = new List<Rose>();
            List<Sunflower> sunflowerList = new List<Sunflower>();

            RoseInfo(roseList , rose_Num);
            SunFlowerInfo(sunflowerList, sf_Num);

            Console.WriteLine("Rose Information");
            Console.WriteLine("_________________");

            for (int x = 0; x < rose_Num; x++)
            {
                Console.WriteLine("Rose name : {0}", roseList[x].Plant_name);

            }

            Console.WriteLine("Sunflower Information");
            Console.WriteLine("_________________");

            for (int x = 0; x < sf_Num; x++)
            {
                Console.WriteLine("Rose name : {0}", sunflowerList[x].Plant_name);

            }
            
            Console.ReadLine();

        }

        public static Tuple<int,int>  InpputFlowerAmount()
        {
            Console.Write("Input total Rose : ");

            int Rose_Num = int.Parse(Console.ReadLine());

            Console.Write("Input total Sunflower : ");

            int SF_Num = int.Parse(Console.ReadLine());

            return new Tuple<int,int>(Rose_Num , SF_Num);
        }

        public static void RoseInfo(List<Rose> rose , int Rose_Num)
        {

            for (int x = 0; x < Rose_Num; x++)
            {
                rose.Add(new Rose(0, "0", "0", 0, "0", "0"));

                Console.WriteLine("Input Rose");
                Console.WriteLine("___________");
                Console.WriteLine(" ");

                rose[x].GetInfo();
            }
        }

        public static void SunFlowerInfo(List<Sunflower> sunflower , int Sunflower_Num)
        {
            for (int x = 0; x < Sunflower_Num; x++)
            {
                sunflower.Add(new Sunflower(0, "0", "0", 0, "0", "0"));

                Console.WriteLine("Input Sunflower");
                Console.WriteLine("___________");
                Console.WriteLine(" ");

                sunflower[x].GetInfo();
            }
        }

    }

    class Flower
    {
        public int ID;

        public string Plant_name;

        public string Description;

        public int Amount;

        public string Height;

        public string Circumstance;

        public Flower(int id, string plant_name, string description, int amount,
        string height, string circumstance)
        {
            this.ID = id;
            this.Plant_name = plant_name;
            this.Description = description;
            this.Amount = amount;
            this.Height = height;
            this.Circumstance = circumstance;
        }

        public void GetInfo()
        {

            Console.Write("ID : ");
            this.ID = int.Parse(Console.ReadLine());
            Console.Write("Plant name : ");
            this.Plant_name = Console.ReadLine();
            Console.Write("Plant Description : ");
            this.Description = Console.ReadLine();
            Console.Write("Amount : ");
            this.Amount = int.Parse(Console.ReadLine());
            Console.Write("Height : ");
            this.Height = Console.ReadLine();
            Console.Write("Circumference : ");
            this.Circumstance = Console.ReadLine();

            Console.WriteLine("");

        }


    }

    class Rose : Flower
    {
        public Rose(int id, string plant_name, string description, int amount, string height,
        string circumstance)
        : base(id, plant_name, description, amount, height, circumstance)
        {
            this.ID = id;
            this.Plant_name = plant_name;
            this.Description = description;
            this.Amount = amount;
            this.Height = height;
            this.Circumstance = circumstance;
        }
    }

    class Sunflower : Flower
    {
        public Sunflower(int id, string plant_name, string description, int amount, 
        string height, string circumstance)
        : base(id, plant_name, description, amount, height, circumstance)
        {
            this.ID = id;
            this.Plant_name = plant_name;
            this.Description = description;
            this.Amount = amount;
            this.Height = height;
            this.Circumstance = circumstance;
        }
    }
}
