using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pagination.Models
{
    public static class DbInitializer
    {
        public static void Initialize(ContactContext context)
        {
            context.Database.EnsureCreated();

            if (context.Contacts.Any())
            {
                return;
            }

            var contacts = new Contact[]
            {
                new Contact { Id = 1, FirstName = "John", LastName = "Doe", Email = "john@example.com" },
                new Contact { Id = 2, FirstName = "Peter", LastName = "Jones", Email = "peter@example.com" },
                new Contact { Id = 3, FirstName = "Mary", LastName = "Smith", Email = "mary@example.com" },
                new Contact { Id = 4, FirstName = "Ian", LastName = "Green", Email = "ian@example.com" },
                new Contact { Id = 5, FirstName = "Nancy", LastName = "Brownwood", Email = "nancy@example.com" },
                new Contact { Id = 6, FirstName = "Tommy", LastName = "High", Email = "tommy@example.com" },
                new Contact { Id = 7, FirstName = "Gabriel", LastName = "Santos", Email = "gabriel@example.com" },
                new Contact { Id = 8, FirstName = "Ryan", LastName = "James", Email = "ryan@example.com" },
                new Contact { Id = 9, FirstName = "Marc", LastName = "James", Email = "marc@example.com" },
                new Contact { Id = 10, FirstName = "James", LastName = "Dallas", Email = "james@example.com" },
                new Contact { Id = 11, FirstName = "Ron", LastName = "Steer", Email = "ron@example.com" },
                new Contact { Id = 12, FirstName = "Liam", LastName = "Schwarz", Email = "liam@example.com" },

                new Contact { Id = 13, FirstName = "Jim", LastName = "Doel", Email = "john@example.com" },
                new Contact { Id = 14, FirstName = "Pet", LastName = "Jon", Email = "peter@example.com" },
                new Contact { Id = 15, FirstName = "Marian", LastName = "Smithes", Email = "mary@example.com" },
                new Contact { Id = 16, FirstName = "Ianis", LastName = "Gree", Email = "ian@example.com" },
                new Contact { Id = 17, FirstName = "Nan", LastName = "Brown", Email = "nancy@example.com" },
                new Contact { Id = 18, FirstName = "Tom", LastName = "Higher", Email = "tommy@example.com" },
                new Contact { Id = 19, FirstName = "Gab", LastName = "Sant", Email = "gabriel@example.com" },
                new Contact { Id = 20, FirstName = "Rya", LastName = "Jameson", Email = "ryan@example.com" },
                new Contact { Id = 21, FirstName = "Marcon", LastName = "Jam", Email = "marc@example.com" },
                new Contact { Id = 22, FirstName = "Jameson", LastName = "Dal", Email = "james@example.com" },
                new Contact { Id = 23, FirstName = "Ronin", LastName = "Steerson", Email = "ron@example.com" },
                new Contact { Id = 24, FirstName = "Lia", LastName = "Schwarzer", Email = "liam@example.com" },

                new Contact { Id = 25, FirstName = "Llazar", LastName = "Gjermeni", Email = "john@example.com" },
                new Contact { Id = 26, FirstName = "Bledar", LastName = "Mahmuti", Email = "peter@example.com" },
                new Contact { Id = 27, FirstName = "Luan", LastName = "Luani", Email = "mary@example.com" },
                new Contact { Id = 28, FirstName = "dan", LastName = "Mos", Email = "ian@example.com" },
                new Contact { Id = 280, FirstName = "fat", LastName = "gol", Email = "nancy@example.com" },
                new Contact { Id = 29, FirstName = "edi", LastName = "rama", Email = "tommy@example.com" },
                new Contact { Id = 30, FirstName = "emer", LastName = "kot", Email = "gabriel@example.com" },
                new Contact { Id = 31, FirstName = "filan", LastName = "fisteku", Email = "ryan@example.com" },
                new Contact { Id = 32, FirstName = "ashtu", LastName = "po", Email = "marc@example.com" },
                new Contact { Id = 33, FirstName = "mos", LastName = "deti", Email = "james@example.com" },
                new Contact { Id = 34, FirstName = "rob", LastName = "zoti", Email = "ron@example.com" },
                new Contact { Id = 35, FirstName = "Liam", LastName = "Neeson", Email = "liam@example.com" }
            };

            foreach (Contact c in contacts)
            {
                context.Contacts.Add(c);
            }

            context.SaveChanges();
        }
    }
}
