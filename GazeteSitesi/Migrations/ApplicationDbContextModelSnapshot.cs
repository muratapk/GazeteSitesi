﻿// <auto-generated />
using System;
using GazeteSitesi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GazeteSitesi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GazeteSitesi.Models.Gazete", b =>
                {
                    b.Property<int>("GazeteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GazeteId"), 1L, 1);

                    b.Property<string>("GazeteAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GazeteAdres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GazeteEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GazeteFacebook")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GazeteInstagram")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GazeteLogo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GazeteSlogan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GazeteTelefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GazeteYoutube")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GazeteId");

                    b.ToTable("Gazetes");
                });

            modelBuilder.Entity("GazeteSitesi.Models.Haberler", b =>
                {
                    b.Property<int>("HaberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HaberId"), 1L, 1);

                    b.Property<string>("HaberBaslik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HaberIcerik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HaberKonu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HaberManset")
                        .HasColumnType("int");

                    b.Property<DateTime>("HaberTarih")
                        .HasColumnType("datetime2");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<int>("KonumId")
                        .HasColumnType("int");

                    b.Property<int>("ResimId")
                        .HasColumnType("int");

                    b.Property<int>("YazarId")
                        .HasColumnType("int");

                    b.HasKey("HaberId");

                    b.HasIndex("KategoriId");

                    b.HasIndex("KonumId");

                    b.HasIndex("ResimId");

                    b.HasIndex("YazarId");

                    b.ToTable("haberlers");
                });

            modelBuilder.Entity("GazeteSitesi.Models.Kategoriler", b =>
                {
                    b.Property<int>("KategoriId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KategoriId"), 1L, 1);

                    b.Property<string>("KategoriAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KategoriId");

                    b.ToTable("Kategorilers");
                });

            modelBuilder.Entity("GazeteSitesi.Models.Konumlar", b =>
                {
                    b.Property<int>("KonumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KonumId"), 1L, 1);

                    b.Property<string>("KonumAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KonumId");

                    b.ToTable("Konumlars");
                });

            modelBuilder.Entity("GazeteSitesi.Models.Kullanicilar", b =>
                {
                    b.Property<int>("KullaniciId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KullaniciId"), 1L, 1);

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciSifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("YetkiId")
                        .HasColumnType("int");

                    b.HasKey("KullaniciId");

                    b.HasIndex("YetkiId");

                    b.ToTable("Kullanicilars");
                });

            modelBuilder.Entity("GazeteSitesi.Models.Reklamlar", b =>
                {
                    b.Property<int>("ReklamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReklamId"), 1L, 1);

                    b.Property<int>("KonumId")
                        .HasColumnType("int");

                    b.Property<int?>("KonumlarKonumId")
                        .HasColumnType("int");

                    b.Property<string>("ReklamKonu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReklamResim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReklamId");

                    b.HasIndex("KonumlarKonumId");

                    b.ToTable("Reklamlars");
                });

            modelBuilder.Entity("GazeteSitesi.Models.Resimler", b =>
                {
                    b.Property<int>("ResimId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResimId"), 1L, 1);

                    b.Property<string>("ResimAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ResimId");

                    b.ToTable("Resimlers");
                });

            modelBuilder.Entity("GazeteSitesi.Models.Yazarlar", b =>
                {
                    b.Property<int>("YazarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YazarId"), 1L, 1);

                    b.Property<string>("YazarAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarResim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarSifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YazarId");

                    b.ToTable("Yazarlars");
                });

            modelBuilder.Entity("GazeteSitesi.Models.Yetkiler", b =>
                {
                    b.Property<int>("YetkiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YetkiId"), 1L, 1);

                    b.Property<string>("YetkiAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YetkiId");

                    b.ToTable("Yetkilers");
                });

            modelBuilder.Entity("GazeteSitesi.Models.Yorumlar", b =>
                {
                    b.Property<int>("YorumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YorumId"), 1L, 1);

                    b.Property<int>("HaberId")
                        .HasColumnType("int");

                    b.Property<string>("YorumAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YorumMesaj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YorumId");

                    b.HasIndex("HaberId");

                    b.ToTable("Yorumlars");
                });

            modelBuilder.Entity("GazeteSitesi.Models.Haberler", b =>
                {
                    b.HasOne("GazeteSitesi.Models.Kategoriler", "Kategoriler")
                        .WithMany("Haberlers")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GazeteSitesi.Models.Konumlar", "Konumlar")
                        .WithMany("Haberlers")
                        .HasForeignKey("KonumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GazeteSitesi.Models.Resimler", "Resimler")
                        .WithMany("Haberlers")
                        .HasForeignKey("ResimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GazeteSitesi.Models.Yazarlar", "Yazarlar")
                        .WithMany("Haberlers")
                        .HasForeignKey("YazarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategoriler");

                    b.Navigation("Konumlar");

                    b.Navigation("Resimler");

                    b.Navigation("Yazarlar");
                });

            modelBuilder.Entity("GazeteSitesi.Models.Kullanicilar", b =>
                {
                    b.HasOne("GazeteSitesi.Models.Yetkiler", "Yetkiler")
                        .WithMany("Kullanicilars")
                        .HasForeignKey("YetkiId");

                    b.Navigation("Yetkiler");
                });

            modelBuilder.Entity("GazeteSitesi.Models.Reklamlar", b =>
                {
                    b.HasOne("GazeteSitesi.Models.Konumlar", "Konumlar")
                        .WithMany("Reklamlars")
                        .HasForeignKey("KonumlarKonumId");

                    b.Navigation("Konumlar");
                });

            modelBuilder.Entity("GazeteSitesi.Models.Yorumlar", b =>
                {
                    b.HasOne("GazeteSitesi.Models.Haberler", "Haberler")
                        .WithMany("Yorumlars")
                        .HasForeignKey("HaberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Haberler");
                });

            modelBuilder.Entity("GazeteSitesi.Models.Haberler", b =>
                {
                    b.Navigation("Yorumlars");
                });

            modelBuilder.Entity("GazeteSitesi.Models.Kategoriler", b =>
                {
                    b.Navigation("Haberlers");
                });

            modelBuilder.Entity("GazeteSitesi.Models.Konumlar", b =>
                {
                    b.Navigation("Haberlers");

                    b.Navigation("Reklamlars");
                });

            modelBuilder.Entity("GazeteSitesi.Models.Resimler", b =>
                {
                    b.Navigation("Haberlers");
                });

            modelBuilder.Entity("GazeteSitesi.Models.Yazarlar", b =>
                {
                    b.Navigation("Haberlers");
                });

            modelBuilder.Entity("GazeteSitesi.Models.Yetkiler", b =>
                {
                    b.Navigation("Kullanicilars");
                });
#pragma warning restore 612, 618
        }
    }
}
