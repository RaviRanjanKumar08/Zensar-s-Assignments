using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_book
{
    struct book
    {
        private int book_id;
        public void GetBookDetails(int id)
        {
            book_id = id;
            Console.WriteLine("Book Id: {0}", book_id);
        }
    };
    internal class program
    {
         static void Main(string[] args)
         {
            int id;
            Console.WriteLine("Enter the book id: ");
            id = Convert.ToInt32(Console.ReadLine());
            book b = new book();
            b.GetBookDetails(id);
         }
    }
}
