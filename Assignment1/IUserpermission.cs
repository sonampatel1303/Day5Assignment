using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public interface IUserpermission
    {
      
            void BorrowBook(int bookId);
            void ReserveBook(int bookId);
            void AddBook(int bookId, string bookTitle);
            void RemoveBook(int bookId);
        

    }
}
