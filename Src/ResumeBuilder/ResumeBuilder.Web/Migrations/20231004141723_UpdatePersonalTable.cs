using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResumeBuilder.Web.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePersonalTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalInfos_Resumes_ResumeId",
                table: "PersonalInfos");

            migrationBuilder.DropIndex(
                name: "IX_PersonalInfos_ResumeId",
                table: "PersonalInfos");

            migrationBuilder.DropColumn(
                name: "ResumeId",
                table: "PersonalInfos");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalInfos_Resumes_Id",
                table: "PersonalInfos",
                column: "Id",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalInfos_Resumes_Id",
                table: "PersonalInfos");

            migrationBuilder.AddColumn<Guid>(
                name: "ResumeId",
                table: "PersonalInfos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_PersonalInfos_ResumeId",
                table: "PersonalInfos",
                column: "ResumeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalInfos_Resumes_ResumeId",
                table: "PersonalInfos",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
