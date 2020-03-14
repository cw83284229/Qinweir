using Microsoft.EntityFrameworkCore.Migrations;

namespace Qinweir.Migrations
{
    public partial class CreateMaterialNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AlterColumn<byte>(
            //    name: "Priority",
            //    table: "AbpBackgroundJobs",
            //    nullable: false,
            //    defaultValue: (byte)15,
            //    oldClrType: typeof(byte),
            //    oldType: "INTEGER",
            //    oldDefaultValue: (byte)15)
            //    .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.CreateTable(
                name: "AppMaterialNames",
                columns: table => new
                {
                    Id = table.Column<int>(maxLength: 128, nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MaterialsType = table.Column<string>(nullable: true),
                    MaterialsName = table.Column<string>(nullable: true),
                    units = table.Column<string>(nullable: true),
                    UnitPrice = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppMaterialNames", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppMaterialNames");

            //migrationBuilder.AlterColumn<byte>(
            //    name: "Priority",
            //    table: "AbpBackgroundJobs",
            //    type: "INTEGER",
            //    nullable: false,
            //    defaultValue: (byte)15,
            //    oldClrType: typeof(byte),
            //    oldDefaultValue: (byte)15)
            //    .Annotation("Sqlite:Autoincrement", true);
        }
    }
}
