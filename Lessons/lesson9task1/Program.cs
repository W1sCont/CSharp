using lesson9task1;
namespace CSharpApplication.DataTypes
{
    class MainClass
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            try
            {
                Console.WriteLine("My warehouse");
                Warehouse MyWarehouse = new();
                Item banan = new("Banan", 1, 5, ItemCategory.Food);

                MyWarehouse.Add(banan);
                MyWarehouse.PrintInfo();
                var item1 = MyWarehouse["Banan"];

                MyWarehouse.Add(banan);
                MyWarehouse.PrintInfo();

                Item tablet = new("Tablet", 2, 250, ItemCategory.Electronic);
                MyWarehouse.Add(tablet);
                MyWarehouse.Remove(banan);
                MyWarehouse.PrintInfo();

                MyWarehouse.Remove(banan);
                MyWarehouse.PrintInfo();
                
                MyWarehouse += item1;
                MyWarehouse.PrintInfo();

                MyWarehouse -= tablet;
                MyWarehouse.PrintInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

