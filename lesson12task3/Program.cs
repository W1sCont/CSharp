using lesson12task3;

namespace Program_12_3
{
    class MainClass
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            try
            {
                Academy_Group MyGroup = new Academy_Group();
                MyGroup.Add(new Student("Ivan", "Ivanov", 20, "0991234567", 95, 101));
                MyGroup.Add(new Student("Roman", "Romanov", 25, "0991334567", 90, 101));
                MyGroup.Print();
                Student st = new Student();
                st.Name = "Yura";
                st.SurName = "Galushko";
                st.Age = 32;
                st.Phone = "0992547561";
                st.GroupNumber = 102;
                st.GPA = 89;
                MyGroup.Add(st);
                MyGroup.Print();
                Console.WriteLine($"Search Galushko: {MyGroup.Search("Galushko")}");
                MyGroup.Remove("Ivanov");
                Console.WriteLine("Remove Ivanov");
                MyGroup.Print();
                MyGroup.Save("test.txt");
                Console.WriteLine("Load from test.txt");
                Academy_Group testGroup = new Academy_Group();
                testGroup.Load("test.txt");
                Console.WriteLine("Add John");
                testGroup.Add(new Student("John", "Snow", 24, "0991334777", 90, 101));
                testGroup.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}