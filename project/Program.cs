using System;
using algorithm;
using ReadAndWriteData;
namespace project
{
    class Program
    {
        static void Main(string[] args)

        {
            algorithmClass a = new algorithmClass();
            a.algorithmFunc();
            ReadAndWriteDataClass r = new ReadAndWriteDataClass();
            r.ReadAndWriteDataFunc();
            Console.ReadKey();

        }
    }
}
