using System;
namespace DefaultNamespace
{
    public class Train
    {
        private string[] Destination; 
        private string[] DepartureTime;
        private int[] NumbersOfTrains;
        public Train()
        {
            this.Destination = new string[] { "Томск", "Новосибирск", "Кемерово", "Омск" };
            this.DepartureTime = new string[] {"6:45", "7:20", "9:00", "9:45" };
            this.NumersOfTrains = new int[] { 123, 621, 321, 442 };
        }
        public void Info(int a)
        {
            Console.WriteLine($"Пункт назначения: {this.Destination[a]}, Время отправления: {this.DepartureTime[a]}");
        }
    }
}