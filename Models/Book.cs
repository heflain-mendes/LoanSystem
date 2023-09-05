using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanSystem.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public bool IsAvaliable { get; set; }

    public ICollection<LoanBook> LoanBooks { get; set; } = new List<LoanBook>();
}
