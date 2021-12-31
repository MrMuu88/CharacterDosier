using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CharacterDosier.DAL.Database.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    Race = table.Column<string>(type: "TEXT", nullable: true),
                    Class = table.Column<string>(type: "TEXT", nullable: true),
                    Experience = table.Column<int>(type: "INTEGER", nullable: false),
                    Background = table.Column<string>(type: "TEXT", nullable: true),
                    Aligment = table.Column<string>(type: "TEXT", nullable: true),
                    Inpiration = table.Column<int>(type: "INTEGER", nullable: false),
                    Proficency = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wealth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Platinum = table.Column<int>(type: "INTEGER", nullable: false),
                    Elerium = table.Column<int>(type: "INTEGER", nullable: false),
                    Gold = table.Column<int>(type: "INTEGER", nullable: false),
                    Silver = table.Column<int>(type: "INTEGER", nullable: false),
                    Copper = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wealth", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Apperances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Image = table.Column<byte[]>(type: "BLOB", nullable: true),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Height = table.Column<int>(type: "INTEGER", nullable: false),
                    Weight = table.Column<int>(type: "INTEGER", nullable: false),
                    Eyes = table.Column<string>(type: "TEXT", nullable: true),
                    Skin = table.Column<string>(type: "TEXT", nullable: true),
                    Hail = table.Column<string>(type: "TEXT", nullable: true),
                    CharacterId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apperances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Apperances_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CombatAbilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ArmorClass = table.Column<int>(type: "INTEGER", nullable: false),
                    Initiative = table.Column<int>(type: "INTEGER", nullable: false),
                    Speed = table.Column<int>(type: "INTEGER", nullable: false),
                    CharacterId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CombatAbilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CombatAbilities_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    CharacterId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Features_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Healths",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MaxHP = table.Column<int>(type: "INTEGER", nullable: false),
                    CurrentHP = table.Column<int>(type: "INTEGER", nullable: false),
                    TemporaryHP = table.Column<int>(type: "INTEGER", nullable: false),
                    DiceType = table.Column<int>(type: "INTEGER", nullable: false),
                    TotalHitDice = table.Column<int>(type: "INTEGER", nullable: false),
                    RemainingHitDice = table.Column<int>(type: "INTEGER", nullable: false),
                    DeathSaves = table.Column<int>(type: "INTEGER", nullable: false),
                    CharacterId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Healths", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Healths_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonalityTraits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CharacterId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalityTraits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonalityTraits_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "spellCastings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SpellSaveDC = table.Column<int>(type: "INTEGER", nullable: false),
                    SpellAttackBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    CharacterId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_spellCastings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_spellCastings_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Equipments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Weight = table.Column<int>(type: "INTEGER", nullable: false),
                    Amount = table.Column<int>(type: "INTEGER", nullable: false),
                    ValueId = table.Column<int>(type: "INTEGER", nullable: true),
                    CharacterId1 = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipments_Characters_CharacterId1",
                        column: x => x.CharacterId1,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Equipments_Wealth_ValueId",
                        column: x => x.ValueId,
                        principalTable: "Wealth",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apperances_CharacterId",
                table: "Apperances",
                column: "CharacterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CombatAbilities_CharacterId",
                table: "CombatAbilities",
                column: "CharacterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_CharacterId1",
                table: "Equipments",
                column: "CharacterId1");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_ValueId",
                table: "Equipments",
                column: "ValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Features_CharacterId",
                table: "Features",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Healths_CharacterId",
                table: "Healths",
                column: "CharacterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonalityTraits_CharacterId",
                table: "PersonalityTraits",
                column: "CharacterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_spellCastings_CharacterId",
                table: "spellCastings",
                column: "CharacterId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apperances");

            migrationBuilder.DropTable(
                name: "CombatAbilities");

            migrationBuilder.DropTable(
                name: "Equipments");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "Healths");

            migrationBuilder.DropTable(
                name: "PersonalityTraits");

            migrationBuilder.DropTable(
                name: "spellCastings");

            migrationBuilder.DropTable(
                name: "Wealth");

            migrationBuilder.DropTable(
                name: "Characters");
        }
    }
}
