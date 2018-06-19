﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using scm_mainbanner.Data;

namespace scm_mainbanner.Migrations
{
    [DbContext(typeof(ScmContext))]
    [Migration("20180619141059_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("scm_mainbanner.Models.Banner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("bannerImageUrl");

                    b.Property<int>("contentType");

                    b.Property<string>("endDate");

                    b.Property<int>("gubun");

                    b.Property<int>("idx");

                    b.Property<string>("isUsing")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<byte>("linkType");

                    b.Property<int>("priority");

                    b.Property<string>("registrant");

                    b.Property<int>("releaseCycle");

                    b.Property<string>("startDate");

                    b.Property<string>("worker");

                    b.HasKey("Id");

                    b.ToTable("banners");
                });
#pragma warning restore 612, 618
        }
    }
}
