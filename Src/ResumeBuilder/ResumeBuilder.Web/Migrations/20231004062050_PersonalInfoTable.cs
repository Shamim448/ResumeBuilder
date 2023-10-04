using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResumeBuilder.Web.Migrations
{
    /// <inheritdoc />
    public partial class PersonalInfoTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalInfo_Resumes_ResumeId",
                table: "PersonalInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonalInfo",
                table: "PersonalInfo");

            migrationBuilder.RenameTable(
                name: "PersonalInfo",
                newName: "PersonalInfos");

            migrationBuilder.RenameIndex(
                name: "IX_PersonalInfo_ResumeId",
                table: "PersonalInfos",
                newName: "IX_PersonalInfos_ResumeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonalInfos",
                table: "PersonalInfos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalInfos_Resumes_ResumeId",
                table: "PersonalInfos",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalInfos_Resumes_ResumeId",
                table: "PersonalInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonalInfos",
                table: "PersonalInfos");

            migrationBuilder.RenameTable(
                name: "PersonalInfos",
                newName: "PersonalInfo");

            migrationBuilder.RenameIndex(
                name: "IX_PersonalInfos_ResumeId",
                table: "PersonalInfo",
                newName: "IX_PersonalInfo_ResumeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonalInfo",
                table: "PersonalInfo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalInfo_Resumes_ResumeId",
                table: "PersonalInfo",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
