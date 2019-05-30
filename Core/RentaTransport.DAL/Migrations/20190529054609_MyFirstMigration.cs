using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentaTransport.DAL.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BanTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<Guid>(nullable: true),
                    ModifiedUserId = table.Column<Guid>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<byte>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BanTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<Guid>(nullable: true),
                    ModifiedUserId = table.Column<Guid>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<byte>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarAdditions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<Guid>(nullable: true),
                    ModifiedUserId = table.Column<Guid>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<byte>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarAdditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<Guid>(nullable: true),
                    ModifiedUserId = table.Column<Guid>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<byte>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<Guid>(nullable: true),
                    ModifiedUserId = table.Column<Guid>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<byte>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerPhoneNumbers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<Guid>(nullable: true),
                    ModifiedUserId = table.Column<Guid>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<byte>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerPhoneNumbers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FuelTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<Guid>(nullable: true),
                    ModifiedUserId = table.Column<Guid>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<byte>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<Guid>(nullable: true),
                    ModifiedUserId = table.Column<Guid>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<byte>(nullable: false),
                    BrandId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Models_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<Guid>(nullable: true),
                    ModifiedUserId = table.Column<Guid>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<byte>(nullable: false),
                    BrandId = table.Column<Guid>(nullable: false),
                    ModelId = table.Column<Guid>(nullable: false),
                    CityId = table.Column<Guid>(nullable: false),
                    BanTypeId = table.Column<Guid>(nullable: false),
                    ColorId = table.Column<Guid>(nullable: false),
                    FuelTypeId = table.Column<Guid>(nullable: false),
                    CarAdditionId = table.Column<Guid>(nullable: false),
                    CarImageId = table.Column<Guid>(nullable: false),
                    DrivingDistance = table.Column<decimal>(nullable: false),
                    CarEngine = table.Column<decimal>(nullable: false),
                    CarGear = table.Column<byte>(nullable: false),
                    Transmission = table.Column<byte>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_BanTypes_BanTypeId",
                        column: x => x.BanTypeId,
                        principalTable: "BanTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cars_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cars_CarAdditions_CarAdditionId",
                        column: x => x.CarAdditionId,
                        principalTable: "CarAdditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cars_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cars_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cars_FuelTypes_FuelTypeId",
                        column: x => x.FuelTypeId,
                        principalTable: "FuelTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cars_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CarImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<Guid>(nullable: true),
                    ModifiedUserId = table.Column<Guid>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<byte>(nullable: false),
                    CarId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    MimeType = table.Column<string>(nullable: true),
                    Photo = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarImages_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarImages_CarId",
                table: "CarImages",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BanTypeId",
                table: "Cars",
                column: "BanTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BrandId",
                table: "Cars",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarAdditionId",
                table: "Cars",
                column: "CarAdditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CityId",
                table: "Cars",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ColorId",
                table: "Cars",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_FuelTypeId",
                table: "Cars",
                column: "FuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ModelId",
                table: "Cars",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_BrandId",
                table: "Models",
                column: "BrandId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarImages");

            migrationBuilder.DropTable(
                name: "CustomerPhoneNumbers");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "BanTypes");

            migrationBuilder.DropTable(
                name: "CarAdditions");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "FuelTypes");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
