using System;

namespace Tamrin
{
       public  class Teacher
    {
        public static void Main()
        {
           Teacher th= new teacher("123","Ali",16,60000);
            long Pay = th.Payment();
            Console.WriteLine(Pay);
        }
    }
}
