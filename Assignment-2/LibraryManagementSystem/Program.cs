
using System;

namespace LibraryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book("J.K. Rowling")
            {
                Title = "Harry Potter",
                Publisher = "Bloomsbury",
                ISBN = "978-0747532743"
            };

            myBook.GetInfo();
            myBook.Read();
            myBook.Borrow();
            myBook.Return(DateTime.Now.AddDays(14));

            Magazine myMagazine = new Magazine("Various")
            {
                Title = "National Geographic",
                Publisher = "National Geographic Partners",
                ISBN = "0027-9358"
            };

            Magazine.IssueNumber = 202;
            myMagazine.GetInfo();
            myMagazine.Read();
            myMagazine.Subscribe();

            Console.ReadKey();
        }
    }
}
