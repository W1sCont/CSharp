using lesson13task2;
using System;

namespace MyNamespace
{
    class MyClass
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            try
            {
                Course c1 = new Course("C#", 5);
                OnlineCourse oc1 = new OnlineCourse();
                oc1.Name = "C++";
                oc1.Duration = 5;
                oc1.Type = "Microcontrollers";
                
                Console.WriteLine($"Course c1: {c1}");
                Console.WriteLine($"Online course oc1: {oc1}");

            }
            catch (Exception ex){ Console.WriteLine(ex.Message);}
        }
    }
    
}

