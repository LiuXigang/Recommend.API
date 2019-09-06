﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Recommend.API.Data;

namespace Recommend.API.Migrations
{
    [DbContext(typeof(RecommendDbContext))]
    [Migration("20190906153530_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Recommend.API.Model.ProjectRecommend", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Company");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("FinStage");

                    b.Property<string>("FromUserAvatar");

                    b.Property<int>("FromUserId");

                    b.Property<string>("FromUserName");

                    b.Property<string>("Introduction");

                    b.Property<string>("ProjectAvatar");

                    b.Property<int>("ProjectId");

                    b.Property<int>("RecommednType");

                    b.Property<DateTime>("RecommendTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Tags");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("ProjectRecommends");
                });
#pragma warning restore 612, 618
        }
    }
}
