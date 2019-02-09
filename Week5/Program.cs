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
                SecondFloor =new Node();
                ThirdFloor =new Node();
                FourthFloor =new Node();


                FirstFloor.FloorNumber = "First Floor";
                FirstFloor.elevatorUp = SecondFloor;
                SecondFloor.FloorNumber = "Second Floor";
                SecondFloor.elevatorUp = SecondFloor;
                ThirdFloor.FloorNumber = "Third Floor";
                ThirdFloor.elevatorUp = ThirdFloor;
                FourthFloor.FloorNumber = "Fourth Floor";
                FourthFloor.elevatorUp = FourthFloor;

            }
        }
    }
}