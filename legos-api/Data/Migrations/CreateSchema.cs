using FluentMigrator;

namespace legos_api.Data.Migrations
{
    [Migration(20022025)]
    public class CreateSchema : Migration
    {
        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            Create.Table("lego")
                .WithColumn("id").AsInt32().PrimaryKey().Identity()
                .WithColumn("model").AsString(120).NotNullable()
                .WithColumn("piece").AsInt32().NotNullable()
                .WithColumn("price").AsInt32().NotNullable();
        }
    }

}
