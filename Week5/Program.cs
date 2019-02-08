using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    class Program
    {
        static void Main(string[] args)

        {
            elevator e = new elevator();
            e.run();
        }
        class Node
        {
            public Node() { }
            public Node floor;
            public Node elevatorUp;
            public string FloorNumber;
        }
        class elevator
        {
            Node FirstFloor;
            Node SecondFloor;
            Node ThirdFloor;
            Node FourthFloor;

            public void run()
            {
                FirstFloor = new Node();
                FirstFloor.FloorNumber = "First Floor";
                Console.WriteLine("floor number is {0}", FirstFloor.FloorNumber);
                FirstFloor.elevatorUp = SecondFloor;
                SecondFloor.FloorNumber = "Second Floor";
                Console.WriteLine("floor number is {0}", SecondFloor.FloorNumber);
            }
        }
    }
}