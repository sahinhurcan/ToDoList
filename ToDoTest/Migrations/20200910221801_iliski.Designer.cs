﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDoTest.Models;

namespace ToDoTest.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20200910221801_iliski")]
    partial class iliski
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ToDoTest.Models.gorevler", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Durumu")
                        .HasColumnType("int");

                    b.Property<string>("GorevDetay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grubu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int?>("kullaniciID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("kullaniciID");

                    b.ToTable("gorevlers");
                });

            modelBuilder.Entity("ToDoTest.Models.kullanicilar", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KullaniciAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonelAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YetkiID")
                        .HasColumnType("int");

                    b.Property<int?>("kullanicilarID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("kullanicilarID");

                    b.ToTable("kullanicilars");
                });

            modelBuilder.Entity("ToDoTest.Models.gorevler", b =>
                {
                    b.HasOne("ToDoTest.Models.kullanicilar", "kullanici")
                        .WithMany()
                        .HasForeignKey("kullaniciID");
                });

            modelBuilder.Entity("ToDoTest.Models.kullanicilar", b =>
                {
                    b.HasOne("ToDoTest.Models.kullanicilar", null)
                        .WithMany("kullanicilars")
                        .HasForeignKey("kullanicilarID");
                });
#pragma warning restore 612, 618
        }
    }
}
