﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Recommend.API.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectRecommends",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    FromUserId = table.Column<int>(nullable: false),
                    FromUserName = table.Column<string>(nullable: true),
                    FromUserAvatar = table.Column<string>(nullable: true),
                    RecommednType = table.Column<int>(nullable: false),
                    ProjectId = table.Column<int>(nullable: false),
                    ProjectAvatar = table.Column<string>(nullable: true),
                    Company = table.Column<string>(nullable: true),
                    Introduction = table.Column<string>(nullable: true),
                    Tags = table.Column<string>(nullable: true),
                    FinStage = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    RecommendTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectRecommends", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectRecommends");
        }
    }
}
