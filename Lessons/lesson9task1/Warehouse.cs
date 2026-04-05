using System;
using System.Collections.Generic;
using System.Text;

namespace lesson9task1
{
    enum ItemCategory { Electronic, Food, Furniture }
    struct Item
    {
        public string? Name {  get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
        public ItemCategory Category {  get; set; }
        
        public Item() 
        {
            Name = "Banan";
            Count = 1;
            Price = 10;
            Category = ItemCategory.Food;
        }

        public Item(string name, int count, int price, ItemCategory category)
        {
            Name = name;
            Count = count;
            Price = price;
            Category = category;
        }

    }
    internal class Warehouse
    {
        Item[] arr;
        int CountOfItems = 0;

        public Warehouse()
        {
            arr = new Item[10];
        }

        public Warehouse(int num)
        {
            arr = new Item[num];
        }
        public void Add(Item value)
        {
            if (Check(value)) return;
            if (CountOfItems >= arr.Length) Resize();
            arr[CountOfItems] = value;
            CountOfItems++;
        }
        
        private bool Check(Item value)
        {
            for (int i = 0; i < CountOfItems; i++)
            {
                if (arr[i].Name == value.Name && arr[i].Price == value.Price && arr[i].Category == value.Category)
                {
                    arr[i].Count += value.Count;
                    return true;
                }
            }
            return false;
        }

        public void Remove(Item value)
        {
            if (value.Count <= 0) return;

            for (int i = 0; i < CountOfItems; i++)
            {
                if (arr[i].Name == value.Name && arr[i].Price == value.Price && arr[i].Category == value.Category)
                {
                    if (arr[i].Count > value.Count)
                    {
                        arr[i].Count -= value.Count;
                        Console.WriteLine($"Кількість {value.Name} зменшено на {value.Count}. Залишилось: {arr[i].Count}");
                    }
                    else
                    {
                        Console.WriteLine($"Товар {value.Name} повністю видалено зі складу.");
                        DellOfIndex(i);
                    }
                    return;
                }
            }
            Console.WriteLine("Такого товару на складі не знайдено.");
        }
        private void Resize()
        {
            int newCapacity = arr.Length + 10;
            Item[] temp = new Item[newCapacity];
            Array.Copy(arr, temp, arr.Length);
            arr = temp;
        }

        private void DellOfIndex(int idx)
        {
            if (CountOfItems == 0 || idx < 0 || idx >= CountOfItems) 
                throw new IndexOutOfRangeException();
            for (int i = idx;  i < CountOfItems - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[CountOfItems - 1] = default;
            CountOfItems--;
        }

        private int TotalPrice(Item value)
        {
            int result = value.Count * value.Price;
            return result;
        }
 
        public void PrintInfo()
        {
            Console.WriteLine("\nWarehause info:");
            for (int i = 0; i < CountOfItems; i++)
                Console.WriteLine($"Назва: {arr[i].Name}, К-сть: {arr[i].Count}, Ціна: {arr[i].Price}, " +
                    $"Загальна вартість: {TotalPrice(arr[i])}, Категорія: {arr[i].Category}");
        }

        public Item this[int Index]
        {
            get
            {
                if (Index < 0 || Index >= CountOfItems) throw new IndexOutOfRangeException("Товару за таким індексом не існує");
                return arr[Index];
            }

            set
            {
                if (Index < 0 || Index >= CountOfItems) throw new IndexOutOfRangeException("Неможливо змінити товар за межами списку");
                arr[Index] = value;
            }
        }
        public Item this[string name]
        {
            get
            {
                for (int i = 0; i < CountOfItems; i++)
                {
                    if (arr[i].Name == name) return arr[i];
                }
                throw new KeyNotFoundException($"Товар з назвою '{name}' не знайдено");
            }
        }

        public static Warehouse operator + (Warehouse wh, Item item)
        {
            wh.Add(item);
            return wh;
        }

        public static Warehouse operator - (Warehouse wh, Item item)
        {
            wh.Remove(item);
            return wh;
        }

    }
}
