﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace FreeCourse.IdentityServer.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                nullable: true);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

        
        }
    }
}
