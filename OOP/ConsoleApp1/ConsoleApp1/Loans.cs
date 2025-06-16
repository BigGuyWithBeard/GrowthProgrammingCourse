using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Loan
    {
        public User User { get; set; }
        public Book Book { get; set; }  
        public DateTime StartDate {  get; set; }
        public DateTime EndDate { get; set; }
        public LoanStatus   Status { get; set; }

        public LoanStatus LoanStatus
        {
            get => default;
            set
            {
            }
        }

        public User User1
        {
            get => default;
            set
            {
            }
        }

        public Book Book1
        {
            get => default;
            set
            {
            }
        }
    }
}