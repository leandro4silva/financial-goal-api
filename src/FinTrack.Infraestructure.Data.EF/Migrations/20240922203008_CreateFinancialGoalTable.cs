using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinTrack.Infraestructure.Data.EF.Migrations
{
    public partial class CreateFinancialGoalTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FinancialGoalTransations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Amount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TransactionType = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialGoalTransations", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FinancialGoal",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GoalAmount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Deadline = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdealMonthlySaving = table.Column<decimal>(type: "decimal(65,30)", maxLength: 999999999, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TransactionsId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialGoal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FinancialGoal_FinancialGoalTransations_TransactionsId",
                        column: x => x.TransactionsId,
                        principalTable: "FinancialGoalTransations",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_FinancialGoal_TransactionsId",
                table: "FinancialGoal",
                column: "TransactionsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FinancialGoal");

            migrationBuilder.DropTable(
                name: "FinancialGoalTransations");
        }
    }
}
