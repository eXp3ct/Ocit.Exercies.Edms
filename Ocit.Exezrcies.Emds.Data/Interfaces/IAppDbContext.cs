using Microsoft.EntityFrameworkCore;
using Ocit.Exercies.Emds.Domain;

namespace Ocit.Exezrcies.Emds.Data.Interfaces
{
    public interface IAppDbContext
    {
        public DbSet<BasicDocument> BasicDocuments { get; }
        public DbSet<IncomingDocument> IncomingDocuments { get; }
        public DbSet<Addresse> Addresses { get; }
        public DbSet<CounterParty> CounterParties { get; }
        public DbSet<CameFrom> CameFroms { get; }
        public DbSet<DeliveryMethod> DeliveryMethods { get; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
