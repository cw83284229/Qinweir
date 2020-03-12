using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Qinweir.Migrations
{
    public partial class CreateCommonMaterials : Migration
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
                name: "AppCommonMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(maxLength: 128, nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    OrderStore = table.Column<string>(nullable: true),
                    OrderTime = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCommonMaterials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppBillMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(maxLength: 128, nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    MaterialsType = table.Column<string>(nullable: true),
                    MaterialsName = table.Column<string>(nullable: true),
                    units = table.Column<string>(nullable: true),
                    MateriralsCount = table.Column<long>(nullable: false),
                    MateriralsPrice = table.Column<decimal>(nullable: false),
                    Remark = table.Column<string>(nullable: true),
                    CommonMaterialId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppBillMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppBillMaterials_AppCommonMaterials_CommonMaterialId",
                        column: x => x.CommonMaterialId,
                        principalTable: "AppCommonMaterials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppBillMaterials_CommonMaterialId",
                table: "AppBillMaterials",
                column: "CommonMaterialId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppBillMaterials");

            migrationBuilder.DropTable(
                name: "AppCommonMaterials");

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
