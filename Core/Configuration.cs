using System.Data.Entity.Migrations;
using BooksAPI.Models;

namespace BooksAPI.Core
{
    public class Configuration : DbMigrationsConfiguration<BooksContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(BooksContext context)
        {
            context.Reviews.AddOrUpdate(new Review {BookId = 1, Id = 1, Rating = 4, Description = "Enjoyed book a lot!"});
            context.Reviews.AddOrUpdate(new Review {BookId = 1, Id = 2, Rating = 4, Description = "Great book, bit short."});
            context.Reviews.AddOrUpdate(new Review {BookId = 1, Id = 3, Rating = 3, Description = "Good book, wouldn't read twice."});

            context.Reviews.AddOrUpdate(new Review {BookId = 2, Id = 4, Rating = 5, Description = "Stunning!"});
            context.Reviews.AddOrUpdate(new Review {BookId = 2, Id = 5, Rating = 5, Description = "Best book ever?"});
            context.Reviews.AddOrUpdate(new Review {BookId = 2, Id = 6, Rating = 5, Description = "My favourite book of all time."});

            context.Reviews.AddOrUpdate(new Review {BookId = 3, Id = 7, Rating = 4, Description = "Fun read."});
            context.Reviews.AddOrUpdate(new Review {BookId = 3, Id = 8, Rating = 4, Description = "Good casual read."});
            context.Reviews.AddOrUpdate(new Review {BookId = 3, Id = 9, Rating = 5, Description = "Good but not a serious self help book."});

            context.Books.AddOrUpdate(new Book
            {
                Id = 1,
                Title = "The Millionnaire Fastlane",
                Description = "Is the financial plan of mediocrity -- a dream-stealing, soul-sucking dogma known as \"The Slowlane\" your plan for creating wealth? You know how it goes; it sounds a little something like this: \"Go to school, get a good job, save 10 % of your paycheck, buy a used car, cancel the movie channels, quit drinking expensive Starbucks lattes, save and penny - pinch your life away, trust your life - savings to the stock market, and one day, when you are oh, say, 65 years old, you can retire rich.\"",
                Price = 14.51m,
                ImageUrl = "http://ecx.images-amazon.com/images/I/514kBeGrXDL._SX331_BO1,204,203,200_.jpg"
            });

            context.Books.AddOrUpdate(new Book
            {
                Id = 2,
                Title = "The Martian",
                Description = "I’m stranded on Mars.  I have no way to communicate with Earth.  I’m in a Habitat designed to last 31 days.",
                Price = 4m,
                ImageUrl = "http://ecx.images-amazon.com/images/I/51xjFVB0AkL._SX312_BO1,204,203,200_.jpg"
            });

            context.Books.AddOrUpdate(new Book
            {
                Id = 3,
                Title = "The Richest Man in Babylon",
                Description = "This timeless book holds that the key to success lies in the secrets of the ancients. Based on the famous \"Babylonian principles,\" it's been hailed as the greatest of all inspirational works on the subject of thrift and financial planning.",
                Price = 0.99m,
                ImageUrl = "http://ecx.images-amazon.com/images/I/41JGlyCt5NL._SX326_BO1,204,203,200_.jpg"
            });
        }
    }
}