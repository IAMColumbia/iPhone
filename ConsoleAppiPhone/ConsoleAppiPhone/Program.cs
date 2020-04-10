using System;

namespace ConsoleAppiPhone
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone Emipre = new Phone();
            POTSPhone JacksPhone = new POTSPhone() { PhoneNumber = "4809777" };
            JacksPhone.PlugPhoneIn();

            PayPhone RoseveltStationPhone = new PayPhone() { PhoneNumber = "111111" };
            RoseveltStationPhone.PlugPhoneIn();
            RoseveltStationPhone.AddBalance(5);

            CellPhone jeff = new CellPhone(true, 0) { PhoneNumber = "3122173003" };


            Console.WriteLine(jeff.Dial(Emipre));
        }
    }
}
