using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Stor.Services;

namespace Stor.Migrations
{
    [DbContext(typeof(CarsContext))]
    [Migration("20170703140830_First")]
    partial class First
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("Stor.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Firm");

                    b.Property<string>("Model");

                    b.Property<int>("Price");

                    b.Property<string>("Uri");

                    b.Property<string>("Year");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });
        }
    }
}
