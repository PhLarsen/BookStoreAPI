namespace BooksAPI.Core
{
    using System.Data.Entity.Migrations;

    public class Configuration : DbMigrationsConfiguration<BooksContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;
        }
    }
}