using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many elements you want to calculate thier volume");
            int n = int.Parse(Console.ReadLine());
            double totalVolume = 0;
            for (int i = 1; i <= n; i++)
            {


                Console.WriteLine("Enter Three dimensions for the element");
                Console.WriteLine("Width= ");
                double w = double.Parse(Console.ReadLine());
                Console.WriteLine("Length= ");
                double l = double.Parse(Console.ReadLine());
                Console.WriteLine("Height= ");
                double h = double.Parse(Console.ReadLine());
                double volume = w * l * h;
                Console.WriteLine($"for element No.{i} volume ={volume}");
                totalVolume += volume;
                Console.WriteLine("-------------------------");
                Console.WriteLine();

            }
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            Console.WriteLine($"your total volume ={totalVolume} m3");


            //Task 02


            //Console.WriteLine("Enter Number of rooms in your department");
            //int roomNums = int.Parse(Console.ReadLine());
            //while (roomNums < 1) {
            //    Console.WriteLine("please enter a valid number");



            //}
            //Console.WriteLine("Classify rooms based on their function");
            //Console.WriteLine("1=bedroom");
            //Console.WriteLine("2=Living Room");
            //Console.WriteLine("3= Kitchen");
            //Console.WriteLine("4=Bathroom");
            //Console.WriteLine("5=Office");
            //Console.WriteLine("6=Others");
            //int bedroomNum = 0;
            //int livingRoomNum = 0;
            //int KitchenNum = 0;
            //int bathRoomNum = 0;
            //int officeNum = 0;
            //int othersNum = 0;
            //int input = 0;


            //for (int i = 0; i <= roomNums; i++)
            //{
            //    input = int.Parse(Console.ReadLine());
            //    switch (input)
            //    {
            //        case 1:
            //            bedroomNum++;

            //            break;
            //        case 2:
            //            livingRoomNum++;
            //            break;
            //        case 3:
            //            KitchenNum++;
            //            break;
            //        case 4:
            //            bathRoomNum++;
            //            break;
            //        case 5:
            //            officeNum++;
            //            break;
            //        default:
            //            othersNum++;
            //            break;


            //    }

            //Console.WriteLine($"Number of bedroom = {bedroomNum}");
            //Console.WriteLine($"Number of bedroom = {livingRoomNum}");
            //Console.WriteLine($"Number of bedroom = {KitchenNum}");
            //Console.WriteLine($"Number of bedroom = {bathRoomNum}");
            //Console.WriteLine($"Number of bedroom = {officeNum}");
            //Console.WriteLine($"Number of bedroom = {othersNum}");

        }





















    }
    
}
