using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BurgerHUB.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "burgerMenus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Composition = table.Column<string>(type: "text", nullable: false),
                    IMG = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric(20,0)", nullable: false),
                    IsEco = table.Column<int>(type: "integer", nullable: false),
                    IsHit = table.Column<int>(type: "integer", nullable: false),
                    CookTime_min = table.Column<int>(type: "integer", nullable: false),
                    Weight_gram = table.Column<int>(type: "integer", nullable: false),
                    IDSupplement = table.Column<int>(type: "integer", nullable: false),
                    IdPosition = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_burgerMenus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Avatar = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Raiting = table.Column<int>(type: "integer", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<long>(type: "bigint", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    ClientAdress = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "deliveryMen",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<long>(type: "bigint", nullable: false),
                    IdOrder = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_deliveryMen", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BurgerCons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric(20,0)", nullable: false),
                    Weight_gram = table.Column<int>(type: "integer", nullable: false),
                    IDSupplement = table.Column<int>(type: "integer", nullable: false),
                    IdPosition = table.Column<int>(type: "integer", nullable: false),
                    ClientId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BurgerCons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BurgerCons_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<string>(type: "text", nullable: false),
                    Time = table.Column<string>(type: "text", nullable: false),
                    IdClient = table.Column<int>(type: "integer", nullable: false),
                    IdDeliveryMan = table.Column<int>(type: "integer", nullable: false),
                    IdPayment = table.Column<int>(type: "integer", nullable: false),
                    IdPosition = table.Column<int>(type: "integer", nullable: false),
                    IsActive = table.Column<int>(type: "integer", nullable: false),
                    ClientId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Clients_IdClient",
                        column: x => x.IdClient,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_deliveryMen_IdDeliveryMan",
                        column: x => x.IdDeliveryMan,
                        principalTable: "deliveryMen",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ingridients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<int>(type: "integer", nullable: false),
                    Weight_gram = table.Column<int>(type: "integer", nullable: false),
                    IMG_top = table.Column<string>(type: "text", nullable: false),
                    IMG_side = table.Column<string>(type: "text", nullable: false),
                    IdSupplement = table.Column<int>(type: "integer", nullable: false),
                    BurgerConsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingridients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingridients_BurgerCons_BurgerConsId",
                        column: x => x.BurgerConsId,
                        principalTable: "BurgerCons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CardNumber = table.Column<string>(type: "text", nullable: false),
                    Validity = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    IdOrder = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Orders_IdOrder",
                        column: x => x.IdOrder,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BM = table.Column<int>(type: "integer", nullable: false),
                    BC = table.Column<int>(type: "integer", nullable: false),
                    AmountBM = table.Column<int>(type: "integer", nullable: false),
                    AmountBC = table.Column<int>(type: "integer", nullable: false),
                    IdOrder = table.Column<int>(type: "integer", nullable: false),
                    IdBurgerCons = table.Column<int>(type: "integer", nullable: false),
                    IdBurgerMenu = table.Column<int>(type: "integer", nullable: false),
                    OrderId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Positions_BurgerCons_IdBurgerCons",
                        column: x => x.IdBurgerCons,
                        principalTable: "BurgerCons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Positions_burgerMenus_IdBurgerMenu",
                        column: x => x.IdBurgerMenu,
                        principalTable: "burgerMenus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Positions_Orders_IdOrder",
                        column: x => x.IdOrder,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Positions_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Supplements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    proteins = table.Column<int>(type: "integer", nullable: false),
                    fasts = table.Column<int>(type: "integer", nullable: false),
                    carbohydrates = table.Column<int>(type: "integer", nullable: false),
                    calories = table.Column<int>(type: "integer", nullable: false),
                    IdBurgerMenu = table.Column<int>(type: "integer", nullable: false),
                    IdBurgerCons = table.Column<int>(type: "integer", nullable: false),
                    IdIngridient = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Supplements_BurgerCons_IdBurgerCons",
                        column: x => x.IdBurgerCons,
                        principalTable: "BurgerCons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Supplements_burgerMenus_IdBurgerMenu",
                        column: x => x.IdBurgerMenu,
                        principalTable: "burgerMenus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Supplements_Ingridients_IdIngridient",
                        column: x => x.IdIngridient,
                        principalTable: "Ingridients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BurgerCons_ClientId",
                table: "BurgerCons",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingridients_BurgerConsId",
                table: "Ingridients",
                column: "BurgerConsId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ClientId",
                table: "Orders",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_IdClient",
                table: "Orders",
                column: "IdClient",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_IdDeliveryMan",
                table: "Orders",
                column: "IdDeliveryMan",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_IdOrder",
                table: "Payments",
                column: "IdOrder",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Positions_IdBurgerCons",
                table: "Positions",
                column: "IdBurgerCons",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Positions_IdBurgerMenu",
                table: "Positions",
                column: "IdBurgerMenu",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Positions_IdOrder",
                table: "Positions",
                column: "IdOrder",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Positions_OrderId",
                table: "Positions",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Supplements_IdBurgerCons",
                table: "Supplements",
                column: "IdBurgerCons",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Supplements_IdBurgerMenu",
                table: "Supplements",
                column: "IdBurgerMenu",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Supplements_IdIngridient",
                table: "Supplements",
                column: "IdIngridient",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Supplements");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "burgerMenus");

            migrationBuilder.DropTable(
                name: "Ingridients");

            migrationBuilder.DropTable(
                name: "deliveryMen");

            migrationBuilder.DropTable(
                name: "BurgerCons");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
