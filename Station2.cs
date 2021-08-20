using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_ex_
{
    class Station2 : IService_A
    {
        public void Fun1_Service()
        {
            Console.WriteLine("Do fun1 service."); ;
        }

        public void Fun2_Service()
        {
            Console.WriteLine("Do fun2 service."); ;
        }
    }
}
