namespace BooksAPI.Core
{
    using System.Data.Entity;

    public class Initializer : MigrateDatabaseToLatestVersion<BooksContext, Configuration>
    {
    }
}