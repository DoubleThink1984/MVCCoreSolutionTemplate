using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sandbox.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sandbox.DataLayer.Configuration
{
    class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.HasMany(c => c.Answers).WithOne(x => x.Question);
        }
    }
}
