using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanSystem.Models;

public class Loan
{
    public int Id { get; set; }
    public decimal Fee { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime ReturnDate { get; set; }
    public int CustomerId { get; set; }
    public Customer? Customer { get; set; }
    public ICollection<LoanBook> LoanBooks { get; set; } = new List<LoanBook>();
}
