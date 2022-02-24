using System;

namespace VehicleInterfaceAss13
{

    //interface declaration
 
    interface Vehicle
    {
        //all are the abstract methods.
       
        void changegear (int a);

        void sppedup (int a);
        void applayBrakes (int a);

    }
    //class implements interface
    class Bicycle 
    {
        int speed;
        int gear;

        public void changegear(int newgear)
        {
            gear = newgear;
        }

        public void speedup(int increment)
        {
            speed = speed + increment;
        }

        public void applyBrakes(int decrement)
        {
            speed = speed - decrement;

        }
        public void printstates()
        {
            Console.WriteLine("speed: " + speed + " gear: " + gear);
        }
    }

    class Car
    {
        int speed;
        int gear;

        public void changegear(int newgear)
        {
            gear = newgear;
        }

        public void speedup(int increment)
        {
            speed = speed + increment;
        }

        public void applyBrakes(int decrement)
        {
            speed = speed + decrement;
        }

        public void printstates()
        {
            Console.WriteLine("speed : " + speed + " gear: " + gear);
        }
    }

    class Bike
    {
        int speed;
        int gear;
         
        public void changegear(int newgear)
        {
            gear = newgear;
        }

        public void speedup(int increment)
        {
            speed = speed + increment;
        }

        public void applyBrakes(int decrement)
        {
            speed = speed + decrement;
        }

        public void  printstates()
        {
            Console.WriteLine("speed : " + speed + " gear: " + gear);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bicycle bicycle = new Bicycle();
            bicycle.changegear(2);
            bicycle.speedup(30);
            bicycle.applyBrakes(1);

            Console.WriteLine("Bicycle presnt state : ");
            bicycle.printstates();

            Car car = new Car();
            car.changegear(2);
            car.speedup(80);
            car.applyBrakes(2);

            Console.WriteLine("Car present state : ");
            car.printstates();

            Bike bike = new Bike();
            bike.changegear(3);
            bike.speedup(50);
            bike.applyBrakes(3);

            Console.WriteLine("Bike present state : ");
            bike.printstates();
        }
    }
}
