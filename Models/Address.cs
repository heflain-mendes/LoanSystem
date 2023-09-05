using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanSystem.Models;

public class Address
{
    public int Id { get; set; }
    public string FullAddress { get; set; } = string.Empty;
    public AddressType type { get; set; }
    public int CustomerId { get; set; }
    public Customer? Customer { get; set; }
}
