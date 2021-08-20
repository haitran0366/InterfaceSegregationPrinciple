using System;

namespace ISP_ex_
{
    class Program
    {
        static void Main(string[] args)
        {
            IService_A station2 = new Station2();
            station2.Fun1_Service();
            station2.Fun2_Service();

            // Next: Dependency Inversion Principle
        }
    }
}
