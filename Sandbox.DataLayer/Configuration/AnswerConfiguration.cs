using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sandbox.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sandbox.DataLayer.Configuration
{
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.HasOne(c => c.Question).WithMany(x => x.Answers);
        }
    }
}
