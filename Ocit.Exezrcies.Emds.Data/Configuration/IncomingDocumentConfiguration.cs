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
    public class IncomingDocumentConfiguration : IEntityTypeConfiguration<IncomingDocument>
    {
        public void Configure(EntityTypeBuilder<IncomingDocument> builder)
        {

        }
    }
}
