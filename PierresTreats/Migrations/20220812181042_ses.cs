using Microsoft.EntityFrameworkCore.Migrations;

namespace PierresTreats.Migrations
{
    public partial class ses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flavor_AspNetUsers_UserId",
                table: "Flavor");

            migrationBuilder.DropForeignKey(
                name: "FK_FlavorTreat_Flavor_FlavorId",
                table: "FlavorTreat");

            migrationBuilder.DropForeignKey(
                name: "FK_FlavorTreat_Treat_TreatId",
                table: "FlavorTreat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Treat",
                table: "Treat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Flavor",
                table: "Flavor");

            migrationBuilder.RenameTable(
                name: "Treat",
                newName: "Treats");

            migrationBuilder.RenameTable(
                name: "Flavor",
                newName: "Flavors");

            migrationBuilder.RenameIndex(
                name: "IX_Flavor_UserId",
                table: "Flavors",
                newName: "IX_Flavors_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Treats",
                table: "Treats",
                column: "TreatId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flavors",
                table: "Flavors",
                column: "FlavorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Flavors_AspNetUsers_UserId",
                table: "Flavors",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FlavorTreat_Flavors_FlavorId",
                table: "FlavorTreat",
                column: "FlavorId",
                principalTable: "Flavors",
                principalColumn: "FlavorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlavorTreat_Treats_TreatId",
                table: "FlavorTreat",
                column: "TreatId",
                principalTable: "Treats",
                principalColumn: "TreatId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flavors_AspNetUsers_UserId",
                table: "Flavors");

            migrationBuilder.DropForeignKey(
                name: "FK_FlavorTreat_Flavors_FlavorId",
                table: "FlavorTreat");

            migrationBuilder.DropForeignKey(
                name: "FK_FlavorTreat_Treats_TreatId",
                table: "FlavorTreat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Treats",
                table: "Treats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Flavors",
                table: "Flavors");

            migrationBuilder.RenameTable(
                name: "Treats",
                newName: "Treat");

            migrationBuilder.RenameTable(
                name: "Flavors",
                newName: "Flavor");

            migrationBuilder.RenameIndex(
                name: "IX_Flavors_UserId",
                table: "Flavor",
                newName: "IX_Flavor_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Treat",
                table: "Treat",
                column: "TreatId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flavor",
                table: "Flavor",
                column: "FlavorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Flavor_AspNetUsers_UserId",
                table: "Flavor",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FlavorTreat_Flavor_FlavorId",
                table: "FlavorTreat",
                column: "FlavorId",
                principalTable: "Flavor",
                principalColumn: "FlavorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlavorTreat_Treat_TreatId",
                table: "FlavorTreat",
                column: "TreatId",
                principalTable: "Treat",
                principalColumn: "TreatId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
