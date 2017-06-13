using FluentMigrator;
namespace FluentMigratorDemo.Migrations
{
    [Migration(2)]
    public class AddCountryColumn : Migration
    {
        public override void Up()
        {
            Alter.Table("Member")
                .AddColumn("Country").AsString();
        }
        public override void Down()
        {
            Delete.Column("Country").FromTable("Member");
        }
    }
}