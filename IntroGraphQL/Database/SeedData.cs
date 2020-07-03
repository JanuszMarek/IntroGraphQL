using IntroGraphQL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IntroGraphQL.Database
{
    public static class SeedData
    {
        public static void Seed(this ApplicationDbContext dbContext)
        {
            if (!dbContext.Authors.Any())
            {
                var authors = new List<Author>();
                authors.Add(new Author()
                {
                    FirstName = "James",
                    LastName = "Patterson"
                });
                authors.Add(new Author()
                {
                    FirstName = "Stephen",
                    LastName = "King"
                });
                authors.Add(new Author()
                {
                    FirstName = "Andrzej",
                    LastName = "Sapkowski"
                });
                dbContext.Authors.AddRange(authors);
            }

            if (!dbContext.Books.Any())
            {
                var books = new List<Book>();
                books.Add(new Book()
                {
                    Title = "Along Came a Spider",
                    Description = "Alex Cross and Jezzie Flanagan are about to have a forbidden love affair-at the worst possible time for both of them. Because Gary Soneji, who wants to commit the “crime of the century,” is playing at the top of his game. Soneji has outsmarted the FBI, the Secret Service, and the police. Who will be his next victim?",
                    ReleaseDate = new DateTime(2001, 2, 15),
                    AuthorId = 1
                });
                books.Add(new Book()
                {
                    Title = "I, Alex Cross",
                    Description = "When a beloved relative is murdered, Detective Alex Cross vows to hunt down the killer . . . and discovers a secret that could rock the entire world.",
                    ReleaseDate = new DateTime(2009, 11, 19),
                    AuthorId = 1
                });
                books.Add(new Book()
                {
                    Title = "The Green Mile",
                    Description = "It tells the story of death row supervisor Paul Edgecombe's encounter with John Coffey, an unusual inmate who displays inexplicable healing and empathetic abilities.",
                    ReleaseDate = new DateTime(1996, 8, 29),
                    AuthorId = 2
                });
                books.Add(new Book()
                {
                    Title = "The Shining",
                    Description = "The Shining centers on the life of Jack Torrance, an aspiring writer and recovering alcoholic who accepts a position as the off-season caretaker of the historic Overlook Hotel in the Colorado Rockies. His family accompanies him on this job, including his young son Danny Torrance, who possesses 'the shining', an array of psychic abilities that allow Danny to see the hotel's horrific past. Soon, after a winter storm leaves them snowbound, the supernatural forces inhabiting the hotel influence Jack's sanity, leaving his wife and son in incredible danger.",
                    ReleaseDate = new DateTime(1977, 1, 28),
                    AuthorId = 2
                });
                books.Add(new Book()
                {
                    Title = "The Dark Tower: The Gunslinger",
                    Description = "The story centers upon Roland Deschain, the last gunslinger, who has been chasing his adversary, 'the man in black' for many years. The novel fuses Western fiction with fantasy, science fiction, and horror, following Roland's trek through a vast desert and beyond in search of the man in black. Roland meets several people along his journey, including a boy named Jake Chambers, who travels with him part of the way.",
                    ReleaseDate = new DateTime(1982, 6, 10),
                    AuthorId = 2
                });
                books.Add(new Book()
                {
                    Title = "The Dark Tower: The Gunslinger",
                    Description = "The story centers upon Roland Deschain, the last gunslinger, who has been chasing his adversary, 'the man in black' for many years. The novel fuses Western fiction with fantasy, science fiction, and horror, following Roland's trek through a vast desert and beyond in search of the man in black. Roland meets several people along his journey, including a boy named Jake Chambers, who travels with him part of the way.",
                    ReleaseDate = new DateTime(1982, 6, 10),
                    AuthorId = 2
                });
                books.Add(new Book()
                {
                    Title = "Blood of Elves",
                    Description = "For over a century, humans, dwarves, gnomes, and elves have lived together in relative peace. But times have changed, the uneasy peace is over, and now the races are fighting once again. The only good elf, it seems, is a dead elf. Geralt of Rivia, the cunning assassin known as The Witcher, has been waiting for the birth of a prophesied child.This child has the power to change the world - for good, or for evil.",
                    ReleaseDate = new DateTime(1994, 1, 1),
                    AuthorId = 3
                });
                books.Add(new Book()
                {
                    Title = "Time of Contempt",
                    Description = "The story in Time of Contempt begins where the previous book left off, essentially with Ciri and Yennefer having just left the Temple in Ellander, on their way to Gors Velen, and ultimately Thanedd Island. It is Yennefer's intention that Ciri be enrolled at the Aretuza school of magic and that she continue her instruction in the use and mastery of magic.",
                    ReleaseDate = new DateTime(1995, 1, 1),
                    AuthorId = 3
                });
                dbContext.Books.AddRange(books);
            }
            dbContext.SaveChanges();
        }
    }
}
