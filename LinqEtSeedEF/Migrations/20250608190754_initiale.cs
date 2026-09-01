using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinqEtSeedEF.Migrations
{
    /// <inheritdoc />
    public partial class initiale : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Restaurant",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurant", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValeurA = table.Column<int>(type: "int", nullable: false),
                    ValeurB = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Commande",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commande", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Commande_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Commande_Restaurant_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Plat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prix = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    Vegetarien = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plat_Restaurant_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommandePlat",
                columns: table => new
                {
                    PlatId = table.Column<int>(type: "int", nullable: false),
                    CommandeId = table.Column<int>(type: "int", nullable: false),
                    Quantite = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommandePlat", x => new { x.PlatId, x.CommandeId });
                    table.ForeignKey(
                        name: "FK_CommandePlat_Commande_CommandeId",
                        column: x => x.CommandeId,
                        principalTable: "Commande",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CommandePlat_Plat_PlatId",
                        column: x => x.PlatId,
                        principalTable: "Plat",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "Adresse", "Nom", "Telephone" },
                values: new object[,]
                {
                    { 1, "123 rue Principale, Montréal", "Marie-Josée Tremblay", "(514) 555-1234" },
                    { 2, "456 boulevard Saint-Laurent, Québec", "Patrick Gagné", "(418) 555-5678" },
                    { 3, "789 avenue des Érables, Trois-Rivières", "Sophie Dubois", "(819) 555-9012" },
                    { 4, "1010 rue Saint-Denis, Montréal", "Jean-François Lavoie", "(514) 555-3456" },
                    { 5, "111 rue des Pionniers, Québec", "Geneviève Parent", "(418) 555-7890" }
                });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "Id", "Adresse", "Nom", "Telephone" },
                values: new object[,]
                {
                    { 1, "456 rue Sainte-Catherine, Montréal", "La graine du père George", "(514) 555-2345" },
                    { 2, "789 rue Principale, Québec", "Le Bistro", "(418) 555-6789" },
                    { 3, "1010 boulevard René-Lévesque, Trois-Rivières", "La Belle Province", "(819) 555-2345" },
                    { 4, "1111 rue de la Montagne, Montréal", "La Piazzetta", "(514) 555-6789" },
                    { 5, "2222 rue Saint-Jean, Québec", "Le Petit Coin", "(418) 555-2345" }
                });

            migrationBuilder.InsertData(
                table: "TestData",
                columns: new[] { "Id", "ValeurA", "ValeurB" },
                values: new object[,]
                {
                    { 1, 1, 379 },
                    { 2, 85, 65000 }
                });

            migrationBuilder.InsertData(
                table: "Commande",
                columns: new[] { "Id", "ClientId", "Date", "RestaurantId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 2, new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, 3, new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, 2, new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "Plat",
                columns: new[] { "Id", "Description", "Nom", "Prix", "RestaurantId", "Vegetarien" },
                values: new object[,]
                {
                    { 1, "Un mélange de légumes frais sautés à la poêle", "Sauté de légumes", 8.99m, 1, true },
                    { 2, "Du riz blanc servi avec des carottes fraîches", "Riz aux carottes", 6.99m, 1, true },
                    { 3, "Un délicieux plat de poulet avec du gingembre frais", "Poulet au gingembre", 12.99m, 2, false },
                    { 4, "Un délicieux plat de tofu avec du gingembre frais", "Tofu au gingembre", 11.99m, 2, true },
                    { 5, "Patate, sauce, fromage skwich skwich", "Poutine", 7.99m, 3, false },
                    { 6, "Pepperonni fromage", "Pizza", 9.99m, 4, false }
                });

            migrationBuilder.InsertData(
                table: "CommandePlat",
                columns: new[] { "CommandeId", "PlatId", "Quantite" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 1, 2, 2 },
                    { 2, 3, 2 },
                    { 2, 4, 1 },
                    { 3, 5, 4 },
                    { 4, 6, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commande_ClientId",
                table: "Commande",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Commande_RestaurantId",
                table: "Commande",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_CommandePlat_CommandeId",
                table: "CommandePlat",
                column: "CommandeId");

            migrationBuilder.CreateIndex(
                name: "IX_Plat_RestaurantId",
                table: "Plat",
                column: "RestaurantId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommandePlat");

            migrationBuilder.DropTable(
                name: "TestData");

            migrationBuilder.DropTable(
                name: "Commande");

            migrationBuilder.DropTable(
                name: "Plat");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Restaurant");
        }
    }
}
