using LoanSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanSystem.Configuration;

public class LoanBookConfiguration : IEntityTypeConfiguration<LoanBook>
{
    public void Configure(EntityTypeBuilder<LoanBook> builder)
    {
        builder.HasKey(x => new { x.LoanId, x.BookId });
        builder.HasOne(x => x.Book).WithMany(x => x.LoanBooks).HasForeignKey(x => x.BookId);
        builder.HasOne(x => x.Loan).WithMany(x => x.LoanBooks).HasForeignKey(x => x.LoanId);

        builder.HasIndex(x => x.LoanId);
        builder.HasIndex(x => x.BookId);
    }
}
