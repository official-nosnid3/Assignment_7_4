using System.Numerics;

namespace Assignment_7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Assignment 7.4
             * 
             * Design a parking system for a parking lot. The parking lot has three kinds of 
             * parking spaces: big, medium, and small, with a fixed number of slots for each size.
             * 
             * Implement the ParkingSystem class: ParkingSystem(int big, int medium, int small) 
             * Initializes object of the ParkingSystem class. The number of slots for each parking 
             * space are given as part of the constructor.
             * 
             * bool addCar(int carType) Checks whether there is a parking space of carType for the 
             * car that wants to get into the parking lot. carType can be of three kinds: big, medium, 
             * or small, which are represented by 1, 2, and 3 respectively. A car can only park in a 
             * parking space of its carType. If there is no space available, return false, 
             * else park the car in that size space and return true.
             */

            ParkingSystem parkingLot = new(3, 3, 2);
            int carType = 1;


            while (true)
            {
                Console.Clear();

                Console.WriteLine($"Parking lot spaces: big {parkingLot.BigSpaces}/{parkingLot.BigSpacesCapacity} med {parkingLot.MedSpaces}/{parkingLot.MedSpacesCapacity} small {parkingLot.SmallSpaces}/{parkingLot.SmallSpacesCapacity}");
                
                switch(carType)
                {
                    case 1: // big car
                        Console.WriteLine("\n\nA big car drives in looking for a parking space");
                        if (parkingLot.AddCar(carType))
                        {
                            parkingLot.BigSpaces--;
                            Console.WriteLine("You directed the car to park in a big parking space");
                        }
                        else Console.WriteLine("There are no more big parking spaces available");
                        break;
                    case 2: // med car
                        Console.WriteLine("\n\nA medium car drives in looking for a parking space");
                        if (parkingLot.AddCar(carType))
                        {
                            parkingLot.MedSpaces--;
                            Console.WriteLine("You directed the car to park in a medium parking space");
                        }
                        else Console.WriteLine("There are no more medium parking spaces available");
                        break;
                    case 3: // small car
                        Console.WriteLine("\n\nA small car drives in looking for a parking space");
                        if (parkingLot.AddCar(carType))
                        {
                            parkingLot.SmallSpaces--;
                            Console.WriteLine("You directed the car to park in a small parking space");
                        }
                        else Console.WriteLine("There are no more small parking spaces available");
                        break;
                }

                Console.ReadLine();
            }
        }
    }

    public class ParkingSystem
    {
        // Fields
        private int _bigSpaces;
        private int _medSpaces;
        private int _smallSpaces;
        private int _bigSpaceCapacity;
        private int _medSpaceCapacity;
        private int _smallSpaceCapacity;
        
        // Properties
        public int BigSpaces 
        { 
            get { return _bigSpaces; }
            set { if (value <= _bigSpaceCapacity) { _bigSpaces = value;} }
        }
        public int MedSpaces
        {
            get { return _medSpaces; }
            set { if (value <= _medSpaceCapacity) { _medSpaces = value; } }
        }
        public int SmallSpaces
        {
            get { return _smallSpaces; }
            set { if (value <= _smallSpaceCapacity) { _smallSpaces = value; }
            }
        }
        public int BigSpacesCapacity { get { return _bigSpaceCapacity; } }
        public int MedSpacesCapacity { get { return _medSpaceCapacity; } }
        public int SmallSpacesCapacity { get { return _smallSpaceCapacity; } }


        public ParkingSystem(int big, int medium, int small)
        {
            _bigSpaces = big;
            _medSpaces = medium;
            _smallSpaces = small;
            _bigSpaceCapacity = big;
            _medSpaceCapacity = medium;
            _smallSpaceCapacity = small;
        }

        public bool AddCar(int carType)
        {
            switch (carType)
            {
                case 1: // big car
                    if (BigSpaces > 0) return true;
                    break;
                case 2: // med car
                    if (MedSpaces > 0) return true;
                    break;
                case 3: // small car
                    if (SmallSpaces > 0) return true;
                    break;
            }
            
            return false;
        }
    }
}
