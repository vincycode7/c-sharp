using System;

namespace c_sharp
{
    class Program
    {
            static void Main(string[] args)
        {
            Console.Write("Hello World! PLease type in your name: ");
            string name = Console.ReadLine();
            // Console.ReadKey();

            Console.Write("Type in salary: ");
            Console.WriteLine();
            int salary = 7800000;
            int result  =  salary*3;

            for (int i = 0; i <= 10; i++)
                {
                    if (i==7){
                        Console.WriteLine("There is a {0} here so will stop now",i);
                        break;
                    }

                    Console.WriteLine("{0} your Salary just increased to : {1} from : {2}",name, result, salary);
                }

            int[] collection_ = new int[5];
            collection_[4] = 8; collection_[3] = 6;

            int[] collection2_ = new int[] {2,1,45,2,6,8,4,2};

            string[] collection3_ = new string[] {"school","house warming","gen"};

            foreach (var item in collection_)
            {
                Console.WriteLine("{0},{1}",item,collection_.Length);
            }

            foreach (var item in collection2_)
            {
                Console.WriteLine("{0},{1}",item,collection2_.Length);
            }

            foreach (var item in collection3_)
            {
                Console.WriteLine("{0},{1}",item,collection3_.Length);
            }

            Console.WriteLine("{0} your Salary just increased to : {1} from : {2}",name, result, salary);
        }
    }
}