using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ocit.Exercies.Emds.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocit.Exezrcies.Emds.Data.Configuration
{
    public class BasicDocumentConfiguration : IEntityTypeConfiguration<BasicDocument>
    {
        public void Configure(EntityTypeBuilder<BasicDocument> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.DocumentNumber).IsRequired();
        }
    }
}
