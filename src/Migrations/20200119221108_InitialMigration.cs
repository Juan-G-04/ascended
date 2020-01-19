using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AscendedGuild.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlayerClasses",
                columns: table => new
                {
                    PlayerClassId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ImageUrl = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerClasses", x => x.PlayerClassId);
                });

            migrationBuilder.CreateTable(
                name: "Spec",
                columns: table => new
                {
                    SpecId = table.Column<Guid>(nullable: false),
                    PlayerClassId = table.Column<int>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Demand = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spec", x => new { x.PlayerClassId, x.SpecId });
                    table.ForeignKey(
                        name: "FK_Spec_PlayerClasses_PlayerClassId",
                        column: x => x.PlayerClassId,
                        principalTable: "PlayerClasses",
                        principalColumn: "PlayerClassId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PlayerClasses",
                columns: new[] { "PlayerClassId", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "/images/dk.png", "Death Knight" },
                    { 2, "/images/mage.png", "Mage" },
                    { 3, "/images/rogue.png", "Rogue" },
                    { 4, "/images/dh.png", "Demon Hunter" },
                    { 5, "/images/monk.png", "Monk" },
                    { 6, "/images/shaman.png", "Shaman" },
                    { 7, "/images/druid.png", "Druid" },
                    { 8, "/images/paladin.png", "Paladin" },
                    { 9, "/images/warlock.png", "Warlock" },
                    { 10, "/images/hunter.png", "Hunter" },
                    { 11, "/images/priest.png", "Priest" },
                    { 12, "/images/warrior.png", "Warrior" }
                });

            migrationBuilder.InsertData(
                table: "Spec",
                columns: new[] { "PlayerClassId", "SpecId", "Demand", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("c6560cc2-49f0-44b2-b5f0-236a430f1fde"), 0, "/images/dk-blood.jpg", "Blood" },
                    { 7, new Guid("c82a7c08-4880-495e-a33e-46e3010e302b"), 0, "/images/druid-restoration.jpg", "Restoration" },
                    { 8, new Guid("85c07efd-e37c-4f6b-8c4d-1d242411d7af"), 0, "/images/paladin-holy.jpg", "Holy" },
                    { 8, new Guid("70a7f1e5-efcb-4994-8b3e-b8e23485a804"), 0, "/images/paladin-protection.jpg", "Protection" },
                    { 8, new Guid("f3696cb1-ee0b-4211-ad16-b5eef5d36fbb"), 0, "/images/paladin-retribution.jpg", "Retribution" },
                    { 9, new Guid("96d350fb-feaf-4d26-9f0f-c1843104669c"), 0, "/images/warlock-affliction.jpg", "Affliction" },
                    { 9, new Guid("9bb9a47c-7452-4d25-a203-44536d6c5493"), 0, "/images/warlock-demonology.jpg", "Demonology" },
                    { 7, new Guid("ff99ccf2-58a4-410c-a8ba-e231232d8d7f"), 0, "/images/druid-guardian.jpg", "Guardian" },
                    { 9, new Guid("d0a85c59-2a51-4bb8-86dc-6c8a61b917ca"), 0, "/images/warlock-destruction.jpg", "Destruction" },
                    { 10, new Guid("5b5c6666-25bb-4589-9848-3330def9c9c8"), 0, "/images/hunter-marksmanship.jpg", "Marksmanship" },
                    { 10, new Guid("fed28f86-3580-4262-9b2d-1f6f55529e66"), 0, "/images/hunter-survival.jpg", "Survival" },
                    { 11, new Guid("21fe58a9-e4d3-4f25-b225-d9cf30ff0a0e"), 0, "/images/priest-discipline.jpg", "Discipline" },
                    { 11, new Guid("ac57893a-2446-45cf-8d1b-15442c9a8065"), 0, "/images/priest-holy.jpg", "Holy" },
                    { 11, new Guid("f0e1f6f7-931b-4b1f-973d-9bed1bf8e4ba"), 0, "/images/priest-shadow.jpg", "Shadow" },
                    { 12, new Guid("7e5baee7-f812-4f1e-aea3-fdc181faeb7e"), 0, "/images/warrior-arms.jpg", "Arms" },
                    { 10, new Guid("8569a32e-805b-4e5b-ae97-e6ac4a0bbb5a"), 0, "/images/hunter-bm.jpg", "Beast Mastery" },
                    { 7, new Guid("5eab143c-be2e-459b-983e-8a392176512b"), 0, "/images/druid-feral.jpg", "Feral" },
                    { 7, new Guid("b7ff1a1e-b9f2-4557-92e6-2e9fe22510ae"), 0, "/images/druid-balance.jpg", "Balance" },
                    { 6, new Guid("09983a63-4030-4093-9d53-8548ef1d12ca"), 0, "/images/shaman-restoration.jpg", "Restoration" },
                    { 1, new Guid("bf5616bd-7f7f-4e46-8951-b863d643d6fa"), 0, "/images/dk-frost.jpg", "Frost" },
                    { 1, new Guid("5fab59d5-7ff7-402e-b7d1-87742a0d53d5"), 0, "/images/dk-unholy.jpg", "Unholy" },
                    { 2, new Guid("0e15b7c2-49fb-4fca-bc5d-1a1b27b8f5b2"), 0, "/images/mage-arcane.jpg", "Arcane" },
                    { 2, new Guid("ccf2c6e4-d68a-4759-97b7-14a4f26c4c9f"), 0, "/images/mage-fire.jpg", "Fire" },
                    { 2, new Guid("ad2c86ef-66f8-4e2c-9f61-26f100f36610"), 0, "/images/mage-frost.jpg", "Frost" },
                    { 3, new Guid("4554cd1d-26a9-4b75-aef0-0500fa88ad30"), 0, "/images/rogue-assassination.jpg", "Assassination" },
                    { 3, new Guid("9a79041c-95a6-4ce9-a485-809aa2294cc5"), 0, "/images/rogue-outlaw.jpg", "Outlaw" },
                    { 3, new Guid("dbccb283-3eb1-4620-a756-8ffc2a790298"), 0, "/images/rogue-subtlety.jpg", "Subtlety" },
                    { 4, new Guid("787a89c3-b350-49a9-80d6-be242b30b9a6"), 0, "/images/dh-havoc.jpg", "Havoc" },
                    { 4, new Guid("73ea710a-a3a0-4554-aef2-8ac4746a4391"), 0, "/images/dh-vengeance.jpg", "Vengeance" },
                    { 5, new Guid("18dad26d-20d5-4e0a-9835-ff95b38677b4"), 0, "/images/monk-brewmaster.jpg", "Brewmaster" },
                    { 5, new Guid("922d66ef-f443-4276-ae21-d9221b7cc91e"), 0, "/images/monk-mistweaver.jpg", "Mistweaver" },
                    { 5, new Guid("4d790602-7124-4e8b-af29-a49bc9809379"), 0, "/images/monk-windwalker.jpg", "Windwalker" },
                    { 6, new Guid("fe8499c3-42e4-4061-aa04-392c4f167f3c"), 0, "/images/shaman-elemental.jpg", "Elemental" },
                    { 6, new Guid("2204525b-6f49-44a1-8602-2c801b2d9e74"), 0, "/images/shaman-enhancement.jpg", "Enhancement" },
                    { 12, new Guid("2cf2c599-d8b3-4ff2-abec-afa7da5508a6"), 0, "/images/warrior-fury.jpg", "Fury" },
                    { 12, new Guid("cd1369d6-dd98-44ae-b390-a36dee7e2aa2"), 0, "/images/warrior-protection.jpg", "Protection" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Spec");

            migrationBuilder.DropTable(
                name: "PlayerClasses");
        }
    }
}
