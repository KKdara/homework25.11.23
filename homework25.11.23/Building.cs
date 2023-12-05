using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework25._11._23
{
    [DeveloperInfoAttribute1("Rob", "08.10.2023")]
    public class Building
    {
        private double height;
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        private int flats;
        public int Flats
        {
            get
            {
                return flats;
            }
            set
            {
                flats = value;
            }
        }
        private int floors;
        public int Floors
        {
            get
            {
                return floors;
            }
            set
            {
                floors = value;
            }
        }
        private int entrances;
        public int Entrances
        {
            get
            {
                return entrances;
            }
            set
            {
                entrances = value;
            }
        }
        private static int lastnumber = 1;

        public Building(double height, int flats, int floors, int entrances)
        {
            this.height = height;
            this.flats = flats;
            this.floors = floors;
            this.entrances = entrances;
        }
        public Building() { }

        private static int BuildingNumber()
        {
            lastnumber++;
            return lastnumber;
        }

        public double FloorHeight()
        {
            return height / floors;
        }
        public int FlatsEntr()
        {
            return flats / entrances;
        }
        public int FlatsFloor()
        {
            return flats / floors;
        }
        public void Print()
        {
            Console.WriteLine($"Number of building: {BuildingNumber()} \nHight of building: {height} \nAmount of flats: {flats} \nAmount of floors: {floors} \nAmount f entrances: {entrances}");
            Console.WriteLine("Floor height:" + FloorHeight());
            Console.WriteLine("Flats in entrance:" + FlatsEntr());
            Console.WriteLine("Flats on the floor:" + FlatsFloor());
        }
    }
}
