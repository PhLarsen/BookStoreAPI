namespace BooksAPI.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;
    using Models;

    public class BooksController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            var result = new List<Book>
            {
                new Book
                {
                    Title = "The Millionnaire Fastlane",
                    Description = "Is the financial plan of mediocrity -- a dream-stealing, soul-sucking dogma known as \"The Slowlane\" your plan for creating wealth? You know how it goes; it sounds a little something like this: \"Go to school, get a good job, save 10 % of your paycheck, buy a used car, cancel the movie channels, quit drinking expensive Starbucks lattes, save and penny - pinch your life away, trust your life - savings to the stock market, and one day, when you are oh, say, 65 years old, you can retire rich.\"",
                    Price = 14.51m,
                    ImageUrl = "http://ecx.images-amazon.com/images/I/514kBeGrXDL._SX331_BO1,204,203,200_.jpg",
                    Reviews = new List<Review> { new Review { Rating = 5}, new Review { Rating = 4} }
                },
                new Book
                {
                    Title = "The Martian",
                    Description = "I’m stranded on Mars.  I have no way to communicate with Earth.  I’m in a Habitat designed to last 31 days.",
                    Price = 4m,
                    ImageUrl = "http://ecx.images-amazon.com/images/I/51xjFVB0AkL._SX312_BO1,204,203,200_.jpg",
                    Reviews = new List<Review> { new Review { Rating = 3}}
                },
                new Book
                {
                    Title = "The Richest Man in Babylon",
                    Description = "This timeless book holds that the key to success lies in the secrets of the ancients. Based on the famous \"Babylonian principles,\" it's been hailed as the greatest of all inspirational works on the subject of thrift and financial planning.",
                    Price = 0.99m,
                    ImageUrl = "http://ecx.images-amazon.com/images/I/41JGlyCt5NL._SX326_BO1,204,203,200_.jpg",
                    Reviews = new List<Review> { new Review { Rating = 3}, new Review { Rating = 4}, new Review { Rating = 5 } }
                }
            };

            return Ok(result);
        }
    }
}