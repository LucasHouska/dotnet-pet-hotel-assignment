using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_bakery.Migrations
{
    public partial class ChangedPetOwnerIdToPetOwner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_PetOwners_petOwnerId",
                table: "Pets");

            migrationBuilder.RenameColumn(
                name: "petOwnerId",
                table: "Pets",
                newName: "petOwner");

            migrationBuilder.RenameIndex(
                name: "IX_Pets_petOwnerId",
                table: "Pets",
                newName: "IX_Pets_petOwner");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_PetOwners_petOwner",
                table: "Pets",
                column: "petOwner",
                principalTable: "PetOwners",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_PetOwners_petOwner",
                table: "Pets");

            migrationBuilder.RenameColumn(
                name: "petOwner",
                table: "Pets",
                newName: "petOwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Pets_petOwner",
                table: "Pets",
                newName: "IX_Pets_petOwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_PetOwners_petOwnerId",
                table: "Pets",
                column: "petOwnerId",
                principalTable: "PetOwners",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
