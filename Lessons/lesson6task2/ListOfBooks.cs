using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lesson6task2
{
    internal class ListOfBooks
    {
        private Book?[] listOfBooks;
        private int count = 0;
        public ListOfBooks() { this.listOfBooks = new Book[10]; }
        public ListOfBooks(int capacity) { this.listOfBooks = new Book[capacity]; }

        public int Count => count;
        public void Add(Book obj)
        {
            if (count == listOfBooks.Length) { Resize(); }
            listOfBooks[count] = obj;
            ++count;
        }
        private void Resize()
        {
            int newCapacity = listOfBooks.Length + 10;
            Book[] temp = new Book[newCapacity];
            Array.Copy(listOfBooks, temp, listOfBooks.Length);
            listOfBooks = temp;
        }
        public void DellForIdx(int idx)
        {
            if (idx < 0 || idx >= count)
            {
                throw new IndexOutOfRangeException("index error");
            }
            for (int i = idx; i < listOfBooks.Length - 1; ++i)
            {
                listOfBooks[i] = listOfBooks[i + 1];
            }
            listOfBooks[count - 1] = null;
            --count;
        }
        public void Print() { for (int i = 0; i < count; ++i) { listOfBooks[i]?.Info(); } }
        //
        public Book this[int idx]
        {
            get
            {
                if (idx < 0 || idx >= count) throw new IndexOutOfRangeException("index error");
                return listOfBooks[idx]!;
            }

            set
            {
                if (idx < 0 || idx >= count) throw new IndexOutOfRangeException("index error");
                listOfBooks[idx] = value;
            }
        }
        //

        public static ListOfBooks operator +(ListOfBooks ls, Book book)
        {
            ls.Add(book);
            return ls;
        }
        public static ListOfBooks operator -(ListOfBooks ls, Book book)
        {
            int idx = -1;
            for (int i = 0; i < ls.Count; ++i)
            {
                if (ls[i] == book)
                {
                    idx = i;
                    break;
                }
            }

            if (idx != -1) ls.DellForIdx(idx);
            return ls;
        }
    }
}

