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
                    { 1, "/images/class-icons/dk.png", "Death Knight" },
                    { 2, "/images/class-icons/mage.png", "Mage" },
                    { 3, "/images/class-icons/rogue.png", "Rogue" },
                    { 4, "/images/class-icons/dh.png", "Demon Hunter" },
                    { 5, "/images/class-icons/monk.png", "Monk" },
                    { 6, "/images/class-icons/shaman.png", "Shaman" },
                    { 7, "/images/class-icons/druid.png", "Druid" },
                    { 8, "/images/class-icons/paladin.png", "Paladin" },
                    { 9, "/images/class-icons/warlock.png", "Warlock" },
                    { 10, "/images/class-icons/hunter.png", "Hunter" },
                    { 11, "/images/class-icons/priest.png", "Priest" },
                    { 12, "/images/class-icons/warrior.png", "Warrior" }
                });

            migrationBuilder.InsertData(
                table: "Spec",
                columns: new[] { "PlayerClassId", "SpecId", "Demand", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("7cfe1662-7a15-4703-af9b-bdc44865a83c"), 0, "/images/class-icons/dk-blood.jpg", "Blood" },
                    { 7, new Guid("ec650abb-e334-4b6f-aab2-c239670c682c"), 0, "/images/class-icons/druid-restoration.jpg", "Restoration" },
                    { 8, new Guid("bbc9b896-0203-4b72-b443-21db88e624a3"), 0, "/images/class-icons/paladin-holy.jpg", "Holy" },
                    { 8, new Guid("acdc1873-6103-4e43-9855-01f8246e69d5"), 0, "/images/class-icons/paladin-protection.jpg", "Protection" },
                    { 8, new Guid("f192b2d6-8f5f-429b-b0fe-c0afd679fda8"), 0, "/images/class-icons/paladin-retribution.jpg", "Retribution" },
                    { 9, new Guid("9eeda09f-c86f-45ac-9ac3-90e64a3c91d3"), 0, "/images/class-icons/warlock-affliction.jpg", "Affliction" },
                    { 9, new Guid("a6c2df25-611c-44a5-99b7-968518219833"), 0, "/images/class-icons/warlock-demonology.jpg", "Demonology" },
                    { 7, new Guid("732df4fc-3815-4ffd-9317-ca507060a0d3"), 0, "/images/class-icons/druid-guardian.jpg", "Guardian" },
                    { 9, new Guid("bf949bb1-0e98-4297-ab15-29648d59adbe"), 0, "/images/class-icons/warlock-destruction.jpg", "Destruction" },
                    { 10, new Guid("65ee523b-ef2e-48a4-94cf-f460b1b964be"), 0, "/images/class-icons/hunter-marksmanship.jpg", "Marksmanship" },
                    { 10, new Guid("d0c2aba8-defb-4a31-b28c-c986d05b2d63"), 0, "/images/class-icons/hunter-survival.jpg", "Survival" },
                    { 11, new Guid("ec609361-14c1-49b4-9629-606402262513"), 0, "/images/class-icons/priest-discipline.jpg", "Discipline" },
                    { 11, new Guid("0af543c9-0486-42a7-9613-d5d7096a8013"), 0, "/images/class-icons/priest-holy.jpg", "Holy" },
                    { 11, new Guid("534447f5-33cb-4602-9db2-dfcadef0c945"), 0, "/images/class-icons/priest-shadow.jpg", "Shadow" },
                    { 12, new Guid("0481451c-b098-4c84-a4a2-cd328a3e5bac"), 0, "/images/class-icons/warrior-arms.jpg", "Arms" },
                    { 10, new Guid("0c69f2f0-33a5-4181-b374-25b64c27be21"), 0, "/images/class-icons/hunter-bm.jpg", "Beast Mastery" },
                    { 7, new Guid("c42ae962-f8cb-41bd-a6a5-53e8fa1d215b"), 0, "/images/class-icons/druid-feral.jpg", "Feral" },
                    { 7, new Guid("1b63dce3-d7c0-48de-a127-b660a6f4c80b"), 0, "/images/class-icons/druid-balance.jpg", "Balance" },
                    { 6, new Guid("6fcaaf4c-7379-4c68-9f13-3a018154d459"), 0, "/images/class-icons/shaman-restoration.jpg", "Restoration" },
                    { 1, new Guid("5deb45dc-af3b-4335-b87f-b392c0cfca2f"), 0, "/images/class-icons/dk-frost.jpg", "Frost" },
                    { 1, new Guid("364555df-efcb-4815-943b-f27108c1c526"), 0, "/images/class-icons/dk-unholy.jpg", "Unholy" },
                    { 2, new Guid("bc664d09-93e4-4bf4-a844-d7e67f897041"), 0, "/images/class-icons/mage-arcane.jpg", "Arcane" },
                    { 2, new Guid("c9b0d180-273f-4f0d-b5d5-d2d3c578e1ee"), 0, "/images/class-icons/mage-fire.jpg", "Fire" },
                    { 2, new Guid("d0e3c779-bb61-4109-b10d-de31b3e3bb62"), 0, "/images/class-icons/mage-frost.jpg", "Frost" },
                    { 3, new Guid("7399c8e7-9a4b-42df-b137-30d45ae10a6e"), 0, "/images/class-icons/rogue-assassination.jpg", "Assassination" },
                    { 3, new Guid("f0e9016f-f348-41d9-a13a-920caed041e3"), 0, "/images/class-icons/rogue-outlaw.jpg", "Outlaw" },
                    { 3, new Guid("374f5aca-1323-4840-b26c-6e317ff1f353"), 0, "/images/class-icons/rogue-subtlety.jpg", "Subtlety" },
                    { 4, new Guid("e2ccae81-6a80-40fe-b25d-54dfbf8592c5"), 0, "/images/class-icons/dh-havoc.jpg", "Havoc" },
                    { 4, new Guid("3318bc67-eeea-4252-a3a3-62d64510d33e"), 0, "/images/class-icons/dh-vengeance.jpg", "Vengeance" },
                    { 5, new Guid("f5e814f8-3233-4c63-a94b-15de864d19e4"), 0, "/images/class-icons/monk-brewmaster.jpg", "Brewmaster" },
                    { 5, new Guid("27487a76-70e9-4ca2-af17-4cdde9997165"), 0, "/images/class-icons/monk-mistweaver.jpg", "Mistweaver" },
                    { 5, new Guid("7bcfa67b-d2f8-4b5b-a229-931b5f0a24db"), 0, "/images/class-icons/monk-windwalker.jpg", "Windwalker" },
                    { 6, new Guid("2c6f8ea4-e56e-46fe-bf65-85f5745c7c75"), 0, "/images/class-icons/shaman-elemental.jpg", "Elemental" },
                    { 6, new Guid("9d210045-cd1e-461f-a9b2-382f3bcb9701"), 0, "/images/class-icons/shaman-enhancement.jpg", "Enhancement" },
                    { 12, new Guid("61c8467d-4752-4fef-bb03-b953b3f3d632"), 0, "/images/class-icons/warrior-fury.jpg", "Fury" },
                    { 12, new Guid("082651b9-6320-4229-8295-eea8ed65780e"), 0, "/images/class-icons/warrior-protection.jpg", "Protection" }
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
