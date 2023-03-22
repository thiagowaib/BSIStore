﻿// <auto-generated />
using System;
using BSIStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BSIStore.Migrations
{
    [DbContext(typeof(BsiStoreContext))]
    [Migration("20230322011526_InitalCreate")]
    partial class InitalCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("BSIStore.Models.Produto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("categoria")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("dataValidade")
                        .HasColumnType("TEXT");

                    b.Property<string>("descricao")
                        .HasColumnType("TEXT");

                    b.Property<double>("preco")
                        .HasColumnType("REAL");

                    b.HasKey("id");

                    b.ToTable("Produto");
                });
#pragma warning restore 612, 618
        }
    }
}