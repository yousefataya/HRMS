using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreArchitecture.Database.Migrations
{
    public partial class InitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                schema: "User",
                table: "ItemInventory",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CatogryId",
                schema: "User",
                table: "ItemInventory",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CatogryItems",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "FoodCatogry",
                columns: table => new
                {
                    CatogryId = table.Column<Guid>(nullable: false),
                    CatogryKey = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCatogry", x => x.CatogryId);
                });

            migrationBuilder.CreateTable(
                name: "FoodOrderStatus",
                columns: table => new
                {
                    OrderStatusId = table.Column<Guid>(nullable: false),
                    status = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodOrderStatus", x => x.OrderStatusId);
                });

            migrationBuilder.CreateTable(
                name: "HallReservation",
                columns: table => new
                {
                    HallId = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    HallName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HallReservation", x => x.HallId);
                });

            migrationBuilder.CreateTable(
                name: "ItemTypeCatogryTables",
                columns: table => new
                {
                    ItemTypeCatogryId = table.Column<Guid>(nullable: false),
                    CatogryKey = table.Column<string>(nullable: false),
                    CatogryDescription = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTypeCatogryTables", x => x.ItemTypeCatogryId);
                });

            migrationBuilder.CreateTable(
                name: "ItemTypeEntityTables",
                columns: table => new
                {
                    ItemTypeId = table.Column<Guid>(nullable: false),
                    ItemKey = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTypeEntityTables", x => x.ItemTypeId);
                });

            migrationBuilder.CreateTable(
                name: "FoodBrand",
                columns: table => new
                {
                    FoodId = table.Column<Guid>(nullable: false),
                    FoodName = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    FoodCatogryEntityCatogryId = table.Column<Guid>(nullable: true),
                    UserEntityUserId = table.Column<long>(nullable: true),
                    CatogryId = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    OwnerName = table.Column<string>(nullable: false),
                    OwnerPlace = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodBrand", x => x.FoodId);
                    table.ForeignKey(
                        name: "FK_FoodBrand_FoodCatogry_FoodCatogryEntityCatogryId",
                        column: x => x.FoodCatogryEntityCatogryId,
                        principalTable: "FoodCatogry",
                        principalColumn: "CatogryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FoodBrand_Users_UserEntityUserId",
                        column: x => x.UserEntityUserId,
                        principalSchema: "User",
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HallReservationDateSchedule",
                columns: table => new
                {
                    ReservationId = table.Column<Guid>(nullable: false),
                    startdate = table.Column<DateTime>(nullable: false),
                    enddate = table.Column<DateTime>(nullable: false),
                    Notes = table.Column<string>(nullable: false),
                    HallId = table.Column<string>(nullable: false),
                    HallEntitiesHallId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HallReservationDateSchedule", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_HallReservationDateSchedule_HallReservation_HallEntitiesHallId",
                        column: x => x.HallEntitiesHallId,
                        principalTable: "HallReservation",
                        principalColumn: "HallId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FoodBrandItems",
                columns: table => new
                {
                    ItemId = table.Column<Guid>(nullable: false),
                    ItemName = table.Column<string>(nullable: true),
                    ItemType = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ItemTypeEntityItemTypeId = table.Column<Guid>(nullable: true),
                    ItemTypeId = table.Column<string>(nullable: false),
                    ItemTypeCatogryId1 = table.Column<Guid>(nullable: true),
                    ItemTypeCatogryId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodBrandItems", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_FoodBrandItems_ItemTypeCatogryTables_ItemTypeCatogryId1",
                        column: x => x.ItemTypeCatogryId1,
                        principalTable: "ItemTypeCatogryTables",
                        principalColumn: "ItemTypeCatogryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FoodBrandItems_ItemTypeEntityTables_ItemTypeEntityItemTypeId",
                        column: x => x.ItemTypeEntityItemTypeId,
                        principalTable: "ItemTypeEntityTables",
                        principalColumn: "ItemTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FoodBrandOrder",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(nullable: false),
                    OrderName = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    FoodBrandsFoodId = table.Column<Guid>(nullable: true),
                    FoodId = table.Column<string>(nullable: false),
                    UserEntityUserId = table.Column<long>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    FoodOrderStatusOrderStatusId = table.Column<Guid>(nullable: true),
                    OrderStatusId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodBrandOrder", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_FoodBrandOrder_FoodBrand_FoodBrandsFoodId",
                        column: x => x.FoodBrandsFoodId,
                        principalTable: "FoodBrand",
                        principalColumn: "FoodId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FoodBrandOrder_FoodOrderStatus_FoodOrderStatusOrderStatusId",
                        column: x => x.FoodOrderStatusOrderStatusId,
                        principalTable: "FoodOrderStatus",
                        principalColumn: "OrderStatusId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FoodBrandOrder_Users_UserEntityUserId",
                        column: x => x.UserEntityUserId,
                        principalSchema: "User",
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ElasticLoggly",
                columns: table => new
                {
                    LogglyId = table.Column<Guid>(nullable: false),
                    LogText = table.Column<string>(nullable: false),
                    MethodName = table.Column<string>(nullable: false),
                    ClazzName = table.Column<string>(nullable: false),
                    FoodEntityLogText = table.Column<bool>(nullable: false),
                    FoodOrderEntityLog = table.Column<bool>(nullable: false),
                    FoodBrandsFoodId = table.Column<Guid>(nullable: true),
                    FoodBrandOrderOrderId = table.Column<Guid>(nullable: true),
                    FoodId = table.Column<string>(nullable: true),
                    OrderId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElasticLoggly", x => x.LogglyId);
                    table.ForeignKey(
                        name: "FK_ElasticLoggly_FoodBrandOrder_FoodBrandOrderOrderId",
                        column: x => x.FoodBrandOrderOrderId,
                        principalTable: "FoodBrandOrder",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ElasticLoggly_FoodBrand_FoodBrandsFoodId",
                        column: x => x.FoodBrandsFoodId,
                        principalTable: "FoodBrand",
                        principalColumn: "FoodId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FoodOrderHistory",
                columns: table => new
                {
                    OrderHistoryId = table.Column<Guid>(nullable: false),
                    FoodBrandsOrderId = table.Column<Guid>(nullable: true),
                    OrderId = table.Column<string>(nullable: false),
                    status = table.Column<bool>(nullable: false),
                    ExpiredDate = table.Column<DateTime>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodOrderHistory", x => x.OrderHistoryId);
                    table.ForeignKey(
                        name: "FK_FoodOrderHistory_FoodBrandOrder_FoodBrandsOrderId",
                        column: x => x.FoodBrandsOrderId,
                        principalTable: "FoodBrandOrder",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ElasticLoggly_FoodBrandOrderOrderId",
                table: "ElasticLoggly",
                column: "FoodBrandOrderOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ElasticLoggly_FoodBrandsFoodId",
                table: "ElasticLoggly",
                column: "FoodBrandsFoodId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodBrand_FoodCatogryEntityCatogryId",
                table: "FoodBrand",
                column: "FoodCatogryEntityCatogryId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodBrand_UserEntityUserId",
                table: "FoodBrand",
                column: "UserEntityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodBrandItems_ItemTypeCatogryId1",
                table: "FoodBrandItems",
                column: "ItemTypeCatogryId1");

            migrationBuilder.CreateIndex(
                name: "IX_FoodBrandItems_ItemTypeEntityItemTypeId",
                table: "FoodBrandItems",
                column: "ItemTypeEntityItemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodBrandOrder_FoodBrandsFoodId",
                table: "FoodBrandOrder",
                column: "FoodBrandsFoodId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodBrandOrder_FoodOrderStatusOrderStatusId",
                table: "FoodBrandOrder",
                column: "FoodOrderStatusOrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodBrandOrder_UserEntityUserId",
                table: "FoodBrandOrder",
                column: "UserEntityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodOrderHistory_FoodBrandsOrderId",
                table: "FoodOrderHistory",
                column: "FoodBrandsOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_HallReservationDateSchedule_HallEntitiesHallId",
                table: "HallReservationDateSchedule",
                column: "HallEntitiesHallId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ElasticLoggly");

            migrationBuilder.DropTable(
                name: "FoodBrandItems");

            migrationBuilder.DropTable(
                name: "FoodOrderHistory");

            migrationBuilder.DropTable(
                name: "HallReservationDateSchedule");

            migrationBuilder.DropTable(
                name: "ItemTypeCatogryTables");

            migrationBuilder.DropTable(
                name: "ItemTypeEntityTables");

            migrationBuilder.DropTable(
                name: "FoodBrandOrder");

            migrationBuilder.DropTable(
                name: "HallReservation");

            migrationBuilder.DropTable(
                name: "FoodBrand");

            migrationBuilder.DropTable(
                name: "FoodOrderStatus");

            migrationBuilder.DropTable(
                name: "FoodCatogry");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                schema: "User",
                table: "ItemInventory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CatogryId",
                schema: "User",
                table: "ItemInventory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CatogryItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
