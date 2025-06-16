using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class LibraryApp
    {
        public Loan Loan
        {
            get => default;
            set
            {
            }
        }

        public void LoanBook(User user, Book book) { }
        public void ReturnBook(User user, Book book) { }
        public List<Loan> OverDueBooks() { }
        public List<Loan> Loans;
        public List<Book> Books;
        public List<Book> FindBook(string parameters) { }
        public List<User> Users;

        public BookFinder BookFinder
        {
            get => default;
            set
            {
            }
        }

        public User User
        {
            get => default;
            set
            {
            }
        }
    }
}