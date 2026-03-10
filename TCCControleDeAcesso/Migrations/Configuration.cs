namespace TCCControleDeAcesso.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TCCControleDeAcesso.DbConnection.AcessControl>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            SetSqlGenerator("MySql.Data.MySqlClient", new MySql.Data.EntityFramework.MySqlMigrationSqlGenerator());
        }

        protected override void Seed(TCCControleDeAcesso.DbConnection.AcessControl context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
