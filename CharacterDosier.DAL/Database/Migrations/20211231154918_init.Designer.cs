﻿// <auto-generated />
using System;
using CharacterDosier.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CharacterDosier.DAL.Database.Migrations
{
    [DbContext(typeof(CharacterDbContext))]
    [Migration("20211231154918_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("CharacterDosier.DAL.Models.Apperance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Eyes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Hail")
                        .HasColumnType("TEXT");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Image")
                        .HasColumnType("BLOB");

                    b.Property<string>("Skin")
                        .HasColumnType("TEXT");

                    b.Property<int>("Weight")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("Apperances");
                });

            modelBuilder.Entity("CharacterDosier.DAL.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Aligment")
                        .HasColumnType("TEXT");

                    b.Property<string>("Background")
                        .HasColumnType("TEXT");

                    b.Property<string>("Class")
                        .HasColumnType("TEXT");

                    b.Property<int>("Experience")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Inpiration")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Proficency")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Race")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("CharacterDosier.DAL.Models.CombatAbilities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArmorClass")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Initiative")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Speed")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("CombatAbilities");
                });

            modelBuilder.Entity("CharacterDosier.DAL.Models.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Amount")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CharacterId1")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ValueId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Weight")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId1");

                    b.HasIndex("ValueId");

                    b.ToTable("Equipments");
                });

            modelBuilder.Entity("CharacterDosier.DAL.Models.Feature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("CharacterDosier.DAL.Models.Health", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CurrentHP")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DeathSaves")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DiceType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaxHP")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RemainingHitDice")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TemporaryHP")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TotalHitDice")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("Healths");
                });

            modelBuilder.Entity("CharacterDosier.DAL.Models.Personality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("PersonalityTraits");
                });

            modelBuilder.Entity("CharacterDosier.DAL.Models.SpellCasting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SpellAttackBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SpellSaveDC")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("spellCastings");
                });

            modelBuilder.Entity("CharacterDosier.DAL.Models.Wealth", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Copper")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Elerium")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Gold")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Platinum")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Silver")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Wealth");
                });

            modelBuilder.Entity("CharacterDosier.DAL.Models.Apperance", b =>
                {
                    b.HasOne("CharacterDosier.DAL.Models.Character", "Character")
                        .WithOne("Apperance")
                        .HasForeignKey("CharacterDosier.DAL.Models.Apperance", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("CharacterDosier.DAL.Models.CombatAbilities", b =>
                {
                    b.HasOne("CharacterDosier.DAL.Models.Character", "Character")
                        .WithOne("Combat")
                        .HasForeignKey("CharacterDosier.DAL.Models.CombatAbilities", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("CharacterDosier.DAL.Models.Equipment", b =>
                {
                    b.HasOne("CharacterDosier.DAL.Models.Character", "Character")
                        .WithMany("Equipment")
                        .HasForeignKey("CharacterId1");

                    b.HasOne("CharacterDosier.DAL.Models.Wealth", "Value")
                        .WithMany()
                        .HasForeignKey("ValueId");

                    b.Navigation("Character");

                    b.Navigation("Value");
                });

            modelBuilder.Entity("CharacterDosier.DAL.Models.Feature", b =>
                {
                    b.HasOne("CharacterDosier.DAL.Models.Character", "Character")
                        .WithMany("Features")
                        .HasForeignKey("CharacterId");

                    b.Navigation("Character");
                });

            modelBuilder.Entity("CharacterDosier.DAL.Models.Health", b =>
                {
                    b.HasOne("CharacterDosier.DAL.Models.Character", "Character")
                        .WithOne("Health")
                        .HasForeignKey("CharacterDosier.DAL.Models.Health", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("CharacterDosier.DAL.Models.Personality", b =>
                {
                    b.HasOne("CharacterDosier.DAL.Models.Character", "Character")
                        .WithOne("Personality")
                        .HasForeignKey("CharacterDosier.DAL.Models.Personality", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("CharacterDosier.DAL.Models.SpellCasting", b =>
                {
                    b.HasOne("CharacterDosier.DAL.Models.Character", "Character")
                        .WithOne("SpellCasting")
                        .HasForeignKey("CharacterDosier.DAL.Models.SpellCasting", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("CharacterDosier.DAL.Models.Character", b =>
                {
                    b.Navigation("Apperance");

                    b.Navigation("Combat");

                    b.Navigation("Equipment");

                    b.Navigation("Features");

                    b.Navigation("Health");

                    b.Navigation("Personality");

                    b.Navigation("SpellCasting");
                });
#pragma warning restore 612, 618
        }
    }
}
