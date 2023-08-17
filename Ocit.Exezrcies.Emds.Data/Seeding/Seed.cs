using Microsoft.EntityFrameworkCore;
using Ocit.Exercies.Emds.Domain;
using Ocit.Exercies.Emds.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocit.Exezrcies.Emds.Data.Seeding
{
    public static class Seed
    {
        private static Guid Discriminator1 = Guid.Parse("D27975A9-4B07-4883-B236-F4361245975B");
        private static Guid Discriminator2 = Guid.Parse("E4321C60-166C-4479-9EB7-B71768832FB3");
        public static void SeedData(this ModelBuilder builder)
        {
            var basic1 = new BasicDocument
            {
                CreatedDate = DateTime.UtcNow,
                Discriminator = Discriminator1,
                DocumentKind = new(){ DocumentKind.BasicDocument },
                DocumentNumber = "Number1",
                Name = "Name",
                Subject = "subject",
                Id = 1,
            };

            var basic2 = new BasicDocument
            {
                CreatedDate = DateTime.UtcNow,
                Discriminator = Discriminator2,
                DocumentKind = new (){ DocumentKind.BasicDocument },
                DocumentNumber = "Number2",
                Name = "Name2",
                Subject = "subject2",
                Id = 2,
            };

            var basic3 = new BasicDocument
            {
                CreatedDate = DateTime.UtcNow,
                Discriminator = Discriminator1,
                DocumentKind = new() { DocumentKind.BasicDocument },
                DocumentNumber = "Number3",
                Name = "Name3",
                Subject = "subject3",
                Id = 3,
            };

            var addresse1 = new Addresse
            {
                Id = 1,
                FullName = "FIO",
            };
            var addresse2 = new Addresse
            {
                Id = 2,
                FullName = "FIO2"
            };

            var delivertyMethod = new DeliveryMethod
            {
                Id = 1,
                Name = "EMAIL",
            };
            var delivertyMethod2 = new DeliveryMethod
            {
                Id = 2,
                Name = "EDMS"
            };
            var delivertyMethod3 = new DeliveryMethod
            {
                Id = 3,
                Name = "MAIL"
            };

            var counterParty1 = new CounterParty
            {
                Id = 1,
                Name = "party1"
            };
            var counterParty2 = new CounterParty
            {
                Id = 2,
                Name = "party2"
            }; var counterParty3 = new CounterParty
            {
                Id = 3,
                Name = "party3"
            };

            var cameFrom1 = new CameFrom
            {
                Id = 1,
                Name = "cameFrom1"
            };
            var cameFrom2 = new CameFrom
            {
                Id = 2,
                Name = "cameFrom2"
            }; var cameFrom3 = new CameFrom
            {
                Id = 3,
                Name = "cameFrom3"
            };

            var incoming1 = new IncomingDocument
            {
                Id = 4,
                Discriminator = Discriminator1,
                CreatedDate = DateTime.UtcNow,
                DocumentKind = new() { DocumentKind.IncomingDocument },
                DocumentNumber = "docNumber1",
                Name = "incomingName1",
                Subject = "incomingSubject1"
            };
            //var incomingAddresse1 = new
            //{
            //    IncomingDocumentId = incoming1.Id,
            //    AddresseId = addresse1.Id
            //};
            //var incomingCameFrom1 = new
            //{
            //    IncomingDocuemntId = incoming1.Id,
            //    CameFromId = cameFrom1.Id,
            //};
            //var incomingCounterParty = new
            //{
            //    IncomingDocumentId = incoming1.Id,
            //    CounterPartyId = counterParty1.Id
            //};
            //var incomingDelivery1 = new
            //{
            //    IncomingDocumentId = incoming1.Id,
            //    DeliveryMethodId = delivertyMethod.Id
            //};

            var incoming2 = new IncomingDocument
            {
                Id = 5,
                Discriminator = Discriminator2,
                Addresse = new() { addresse2 },
                CameFrom = new() { cameFrom2, cameFrom1 },
                CounterParty = new() { counterParty1, counterParty1 },
                CreatedDate = DateTime.UtcNow,
                DeliveryMethod = new() { delivertyMethod, delivertyMethod2 },
                DocumentKind = new() { DocumentKind.IncomingDocument },
                DocumentNumber = "docNumber2",
                Name = "incomingName2",
                Subject = "incomingSubject2"
            };
            var incoming3 = new IncomingDocument
            {
                Id = 6,
                Discriminator = Discriminator1,
                Addresse = new() { addresse2 },
                CameFrom = new() { cameFrom3, cameFrom2 },
                CounterParty = new() { counterParty1, counterParty3 },
                CreatedDate = DateTime.UtcNow,
                DeliveryMethod = new() { delivertyMethod3 },
                DocumentKind = new() { DocumentKind.IncomingDocument },
                DocumentNumber = "docNumber3",
                Name = "incomingName3",
                Subject = "incomingSubject3"
            };


            builder.Entity<BasicDocument>().HasData(basic1, basic2, basic3);
            builder.Entity<IncomingDocument>().HasData(incoming1);
            builder.Entity<Addresse>().HasData(addresse1, addresse2);
            builder.Entity<CameFrom>().HasData(cameFrom1, cameFrom2, cameFrom3);
            builder.Entity<CounterParty>().HasData(counterParty1, counterParty2, counterParty3);
            builder.Entity<DeliveryMethod>().HasData(delivertyMethod, delivertyMethod2, delivertyMethod3);
        }
    }
}
