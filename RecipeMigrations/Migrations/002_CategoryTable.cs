using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;

namespace RecipeMigrations.Migrations;
[Migration(2)]
public class _002_CategoryTable : AutoReversingMigration
{
    public override void Up()
    {
        Create.Table("Category")
       .WithColumn("name").AsString()
       .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(true);

        Create.ForeignKey()
       .FromTable("Ingredient").ForeignColumn("name")
       .ToTable("Category");
    }
}