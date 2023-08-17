using Ocit.Exercies.Emds.Domain.Intercaces;

namespace Ocit.Exercies.Emds.Domain.ViewModels
{
    public class BasicDocumentViewModel : IViewModel
    {
        public int Id { get; set; }
        public Guid Discriminator { get; set; }
        public string Name { get; set; }
        public string? Subject { get; set; }
        public DateTime CreatedDate { get; set; }
        public string DocumentNumber { get; set; }
        public string DocumentKind { get; set; }
    }
}
