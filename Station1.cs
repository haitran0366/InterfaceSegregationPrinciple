using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_ex_
{
    class Station1 : IService_A, IService_B, IService_C
    {
        public void Fun1_Service()
        {
            Console.WriteLine("Do fun1 service."); 
        }

        public void Fun2_Service()
        {
            Console.WriteLine("Do fun2 service."); ;
        }

        public void Fun3_Service()
        {
            Console.WriteLine("Do fun3 service."); ;
        }

        public void Fun4_Service()
        {
            Console.WriteLine("Do fun4 service."); ;
        }
    }
}
