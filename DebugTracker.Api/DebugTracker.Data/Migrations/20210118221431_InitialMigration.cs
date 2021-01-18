using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DebugTracker.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MacroSytems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullLabel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MacroSytems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Systems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Systems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MacroSystem_Systems",
                columns: table => new
                {
                    MacroSystemId = table.Column<int>(type: "int", nullable: false),
                    SystemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MacroSystem_Systems", x => new { x.MacroSystemId, x.SystemId });
                    table.ForeignKey(
                        name: "FK_MacroSystem_Systems_MacroSytems_MacroSystemId",
                        column: x => x.MacroSystemId,
                        principalTable: "MacroSytems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MacroSystem_Systems_Systems_SystemId",
                        column: x => x.SystemId,
                        principalTable: "Systems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Issuer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudyId = table.Column<int>(type: "int", nullable: false),
                    Nature = table.Column<int>(type: "int", nullable: false),
                    MacroSystemId = table.Column<int>(type: "int", nullable: false),
                    SystemId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    LocationDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Seriousness = table.Column<int>(type: "int", nullable: false),
                    Impact = table.Column<int>(type: "int", nullable: false),
                    ImpactComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deadline = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActionResponsibleId = table.Column<int>(type: "int", nullable: false),
                    ValidationResponsibleId = table.Column<int>(type: "int", nullable: false),
                    Source = table.Column<int>(type: "int", nullable: false),
                    Release = table.Column<int>(type: "int", nullable: true),
                    ActionComment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requests_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Requests_MacroSytems_MacroSystemId",
                        column: x => x.MacroSystemId,
                        principalTable: "MacroSytems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Requests_Systems_SystemId",
                        column: x => x.SystemId,
                        principalTable: "Systems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "System_Locations",
                columns: table => new
                {
                    SystemId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System_Locations", x => new { x.SystemId, x.LocationId });
                    table.ForeignKey(
                        name: "FK_System_Locations_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_System_Locations_Systems_SystemId",
                        column: x => x.SystemId,
                        principalTable: "Systems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequestStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RequestId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValidationResponsibleId = table.Column<int>(type: "int", nullable: true),
                    ActionResponsibleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestStatus_Requests_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Requests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Label", "OrderBy" },
                values: new object[,]
                {
                    { 1, "- Undefined -", 0 },
                    { 2, "Global", 1 }
                });

            migrationBuilder.InsertData(
                table: "MacroSytems",
                columns: new[] { "Id", "FullLabel", "Label", "OrderBy" },
                values: new object[,]
                {
                    { 1, "- Undefined -", "- Undefined -", 0 },
                    { 2, "Systems and Networks(SR)", "SR", 1 },
                    { 3, "Computerized developments (DI)", "DI", 2 },
                    { 4, "Biometrics (BI)", "BI", 3 }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "Id", "Label", "OrderBy" },
                values: new object[,]
                {
                    { 1, "- Undefined -", 0 },
                    { 2, "i-Cloud", 1 }
                });

            migrationBuilder.InsertData(
                table: "MacroSystem_Systems",
                columns: new[] { "MacroSystemId", "SystemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "System_Locations",
                columns: new[] { "LocationId", "SystemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MacroSystem_Systems_SystemId",
                table: "MacroSystem_Systems",
                column: "SystemId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_LocationId",
                table: "Requests",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_MacroSystemId",
                table: "Requests",
                column: "MacroSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_SystemId",
                table: "Requests",
                column: "SystemId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestStatus_RequestId",
                table: "RequestStatus",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_System_Locations_LocationId",
                table: "System_Locations",
                column: "LocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MacroSystem_Systems");

            migrationBuilder.DropTable(
                name: "RequestStatus");

            migrationBuilder.DropTable(
                name: "System_Locations");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "MacroSytems");

            migrationBuilder.DropTable(
                name: "Systems");
        }
    }
}
