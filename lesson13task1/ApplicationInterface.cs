using System;
using lesson13Shape;
using lesson13task1;

namespace ApplicationInterface
{
    class MainClass
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            try
            {
                CollectionOfFigures cof = new CollectionOfFigures(10);
                Triangle tr1 = new Triangle(3, 5);
                cof.Add(tr1);
                Triangle tr2 = new Triangle(6, 8);
                cof.Add(tr2);
                Triangle tr3 = new Triangle(1, 4);
                cof.Add(tr3);
                Circle cr1 = new Circle(3, 4, 5);
                cof.Add(cr1);
                Circle cr2 = new Circle(4, 4, 3);
                cof.Add(cr2);
                Circle cr3 = new Circle(6, 3, 6);
                cof.Add(cr3);
                Rectangle r1 = new Rectangle(2, 3, 5, 6);
                cof.Add(r1);
                Rectangle r2 = new Rectangle(4, 3, 7, 6);
                cof.Add(r2);
                Rectangle r3 = new Rectangle(1, 4, 3, 8);
                cof.Add(r3);
                cof.Print();
                Console.WriteLine("\nSave to file cof.txt\n");
                cof.Save("cof.txt");
                
                Console.WriteLine("Print only triangle");
                cof.Print(tr2);
                Console.WriteLine("Delete tr2");
                cof.Delete(tr2);
                cof.Print(tr2);
                Console.WriteLine("Delete tr1 = index 0");
                cof.Delete(0);
                cof.Print(tr2);
                Console.WriteLine($"All area = {cof.AllArea()}");
                Console.WriteLine($"Area triangle = {cof.AllArea(tr1)}");
                cof.Print();
                Console.WriteLine("\nNew list\nLoad from cof.txt");
                CollectionOfFigures newColl = new CollectionOfFigures(10);
                newColl.Load("cof.txt");
                Console.WriteLine("Print newColl list");
                newColl.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}