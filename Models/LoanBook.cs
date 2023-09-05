using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanSystem.Models;

public class LoanBook
{
    public int LoanId { get; set; }
    public Loan? Loan { get; set; }
    public int BookId { get; set; }
    public Book? Book { get; set; }

}
