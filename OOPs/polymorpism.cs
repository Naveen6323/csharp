using System;

namespace OOPs
{
    internal class Vehicle
    {
        private int speed;

        public Vehicle(int speed)
        {
            this.speed = speed;
        }

        public int GetSpeed()
        {
            return speed;
        }

        public void SpeedUp()
        {
            Console.WriteLine("spedd is : " + GetSpeed());
        }

    }

    class Car : Vehicle
    {
        private int newSpeed;

        public Car(int speed, int speedup) : base(speed)
        {
            newSpeed = speedup + speed;
        }

        public void SpeedUp()
        {
            Console.WriteLine("Car    is : " + (GetSpeed() + newSpeed));
        }
    }
}