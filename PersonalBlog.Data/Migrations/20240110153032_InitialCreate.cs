using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalBlog.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutMe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    MyJop = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    MyJopFA = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MyCVPath = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutMe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    SecurityQuestion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SQAnswer = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CategoryFA = table.Column<int>(type: "int", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ShortAdress = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    School = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(100)", maxLength: 30, nullable: false),
                    Avarge = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    WorkPlace = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomePageSliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    ShortContent = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Content = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePageSliders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Interesteds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interesteds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(1000)", maxLength: 512, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SiteIdentity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Keywords = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Desciption = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    LogoText = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LogoFA = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteIdentity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    PercentageValue = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialMediaAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Account = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AccountFA = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    AccountUrl = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMediaAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Summary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Summary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ShortContent = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Content = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ViewsCount = table.Column<int>(type: "int", nullable: false),
                    SeoTags = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    SeoDecription = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    ArticIeId = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Articles_ArticIeId",
                        column: x => x.ArticIeId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AboutMe",
                columns: new[] { "Id", "BirthDate", "CreatedByName", "CreatedTime", "FirstName", "ImagePath", "IsActive", "IsDelete", "LastName", "ModifiedByName", "ModifiedTime", "MyCVPath", "MyJop", "MyJopFA" },
                values: new object[] { 1, new DateTime(1998, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "InitailCreated", new DateTime(2024, 1, 10, 18, 30, 32, 224, DateTimeKind.Local).AddTicks(4904), "M. Kaan", "", false, false, "SARICA", "InitialCreated", new DateTime(2024, 1, 10, 18, 30, 32, 224, DateTimeKind.Local).AddTicks(4905), "", "WEB DEVELOPER", "<i class=\"fa-regular fa-laptop-code\"></i>" });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "Id", "CreatedByName", "CreatedTime", "EMail", "IsActive", "IsDelete", "ModifiedByName", "ModifiedTime", "Password", "SQAnswer", "SecurityQuestion" },
                values: new object[] { 1, "InitailCreated", new DateTime(2024, 1, 10, 18, 30, 32, 224, DateTimeKind.Local).AddTicks(5934), "kaansarıca@hotmail.com", false, false, "InitialCreated", new DateTime(2024, 1, 10, 18, 30, 32, 224, DateTimeKind.Local).AddTicks(5935), "202cb962ac59075b964b07152d234b70", "d595878cf4d099846b16890e7d9fc490", " Baba İsmi ?" });

            migrationBuilder.InsertData(
                table: "ContactInfo",
                columns: new[] { "Id", "Adress", "CreatedByName", "CreatedTime", "EMail", "IsActive", "IsDelete", "ModifiedByName", "ModifiedTime", "PhoneNumber", "ShortAdress" },
                values: new object[] { 1, "Gülbağ Mah. Şişli / İstanbul", "InitailCreated", new DateTime(2024, 1, 10, 18, 30, 32, 224, DateTimeKind.Local).AddTicks(8065), "kaansarıca@hotmail.com", false, false, "InitialCreated", new DateTime(2024, 1, 10, 18, 30, 32, 224, DateTimeKind.Local).AddTicks(8066), "+90 541 918 5633", " Şişli / İstanbul" });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "Avarge", "CreatedByName", "CreatedTime", "Description", "Duration", "IsActive", "IsDelete", "ModifiedByName", "ModifiedTime", "School", "Title" },
                values: new object[] { 1, "2.65/4", "InitailCreated", new DateTime(2024, 1, 10, 18, 30, 32, 224, DateTimeKind.Local).AddTicks(7017), "Doktore yapmayı hedefliyorum .", "2020 yılı Harita Mühendislği bölümünden mezun ", false, false, "InitialCreated", new DateTime(2024, 1, 10, 18, 30, 32, 224, DateTimeKind.Local).AddTicks(7018), "İstanbul Teknik Üniversitesi", "Lisans Derecesi" });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "CreatedByName", "CreatedTime", "Description", "Duration", "IsActive", "IsDelete", "ModifiedByName", "ModifiedTime", "Title", "WorkPlace" },
                values: new object[] { 1, "InitailCreated", new DateTime(2024, 1, 10, 18, 30, 32, 224, DateTimeKind.Local).AddTicks(1727), "Çağdaş dünyanın gerçeklerinden biri olan teknoloji ile hareket etmein zorunluluğun son derece farkında olmanın haklı grurunu yaşıyorum.", "Haziran 2023 ve ...", false, false, "InitialCreated", new DateTime(2024, 1, 10, 18, 30, 32, 224, DateTimeKind.Local).AddTicks(1728), "Frelance Web Developer", "freelance" });

            migrationBuilder.InsertData(
                table: "HomePageSliders",
                columns: new[] { "Id", "Content", "CreatedByName", "CreatedTime", "IsActive", "IsDelete", "ModifiedByName", "ModifiedTime", "ShortContent", "Title" },
                values: new object[] { 1, "", "InitailCreated", new DateTime(2024, 1, 10, 18, 30, 32, 223, DateTimeKind.Local).AddTicks(9662), false, false, "InitialCreated", new DateTime(2024, 1, 10, 18, 30, 32, 223, DateTimeKind.Local).AddTicks(9663), "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. ", "Web Developper" });

            migrationBuilder.InsertData(
                table: "Interesteds",
                columns: new[] { "Id", "CreatedByName", "CreatedTime", "IsActive", "IsDelete", "ModifiedByName", "ModifiedTime", "Text" },
                values: new object[,]
                {
                    { 1, "InitialCreated", new DateTime(2024, 1, 10, 18, 30, 32, 223, DateTimeKind.Local).AddTicks(7447), false, false, "InitialCreated", new DateTime(2024, 1, 10, 18, 30, 32, 223, DateTimeKind.Local).AddTicks(7448), "Yazılım ve Teknoloji" },
                    { 2, "InitialCreated", new DateTime(2024, 1, 10, 18, 30, 32, 223, DateTimeKind.Local).AddTicks(7451), false, false, "InitialCreated", new DateTime(2024, 1, 10, 18, 30, 32, 223, DateTimeKind.Local).AddTicks(7451), "Haritacılık Faaliyetleri" },
                    { 3, "InitialCreated", new DateTime(2024, 1, 10, 18, 30, 32, 223, DateTimeKind.Local).AddTicks(7453), false, false, "InitialCreated", new DateTime(2024, 1, 10, 18, 30, 32, 223, DateTimeKind.Local).AddTicks(7453), "Tarım ve Hayvancılık faaliyetleri" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "CreatedByName", "CreatedTime", "EMail", "FirstName", "IsActive", "IsDelete", "LastName", "ModifiedByName", "ModifiedTime", "Subject", "Text" },
                values: new object[] { 1, "InitailCreated", new DateTime(2024, 1, 10, 18, 30, 32, 224, DateTimeKind.Local).AddTicks(2725), "deneme@gmail.com", "Hasan", false, false, "Erdal", "InitialCreated", new DateTime(2024, 1, 10, 18, 30, 32, 224, DateTimeKind.Local).AddTicks(2726), "deneme", "Dün Gece Yar Hanesinde\r\n                 Yastığım Bir Taş İdi\r\n                 Altım Çamur Üstüm Yağmur\r\n                 Gine Gönlüm Hoş İdi\r\n                 Ben Yandım Seni Bilmem\r\n                 Dağ Ne Kadar Yüce Olsa\r\n                 Bir Kenarı Yol Olur\r\n                 Buna Bayram Günü Derler\r\n                 Dostla Düşman Bir Olur\r\n                 Ben Yandım Seni Bilmem\r\n                 Sen Bugün Nadan İle Gezdin\r\n                 Merak Oldu Bana Sen Bugün Nadan İle Gezdin\r\n                 Merak Oldu Bana Çeşmi Mestimden Bile Süzdüm\r\n                 Merak Oldu Bana\r\n                 Ben Yandım Seni Bilmem" });

            migrationBuilder.InsertData(
                table: "SiteIdentity",
                columns: new[] { "Id", "CreatedByName", "CreatedTime", "Desciption", "IsActive", "IsDelete", "Keywords", "LogoFA", "LogoText", "ModifiedByName", "ModifiedTime", "Title" },
                values: new object[] { 1, "InitailCreated", new DateTime(2024, 1, 10, 18, 30, 32, 224, DateTimeKind.Local).AddTicks(3717), "M. Kaan SARICA Web Developer", false, false, "C#, .NET , WEB ,SOFTWARE", "<i class=\"fas fa - h - square\"></i>", "M. Kaan SARICA", "InitialCreated", new DateTime(2024, 1, 10, 18, 30, 32, 224, DateTimeKind.Local).AddTicks(3717), "Hasan Erdal" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CreatedByName", "CreatedTime", "IsActive", "IsDelete", "ModifiedByName", "ModifiedTime", "PercentageValue", "Title" },
                values: new object[] { 1, "InitailCreated", new DateTime(2024, 1, 10, 18, 30, 32, 224, DateTimeKind.Local).AddTicks(606), false, false, "InitialCreated", new DateTime(2024, 1, 10, 18, 30, 32, 224, DateTimeKind.Local).AddTicks(606), 75, "C#" });

            migrationBuilder.InsertData(
                table: "SocialMediaAccounts",
                columns: new[] { "Id", "Account", "AccountFA", "AccountUrl", "CreatedByName", "CreatedTime", "IsActive", "IsDelete", "ModifiedByName", "ModifiedTime" },
                values: new object[] { 1, "Facebook", "<i class=\"fa-brands fa-facebook-f\"></i>", "https://www.facebook.com/profile.php?id=100086037936445&locale=tr_TR", "InitailCreated", new DateTime(2024, 1, 10, 18, 30, 32, 223, DateTimeKind.Local).AddTicks(8491), false, false, "InitialCreated", new DateTime(2024, 1, 10, 18, 30, 32, 223, DateTimeKind.Local).AddTicks(8491) });

            migrationBuilder.InsertData(
                table: "Summary",
                columns: new[] { "Id", "Content", "CreatedByName", "CreatedTime", "IsActive", "IsDelete", "ModifiedByName", "ModifiedTime" },
                values: new object[] { 1, "Selemlarrrr Blog siteme hoş geldiniz :) Ben Kağan  Harita Mühendisiyim . Yazılım sektörüne olan ilgim 2020 yılında başladı . Şu anda C# ile WEB kodluyor ReactNative ile Mobile geliştiriyorum . Asli hedefim Harita Mühendislği ve Yazılımı entegre edip sonrasında teknolojik tarım kavramının en mühim gereksinimi olan Uzaktan Algılama bilim dalı ile projeler üretmek. Aslında pek kararsızım ama hayırlısı diyerek devam etmek istiyorum ... Saygı ve Sevgiyle kalın :)", "InitailCreated", new DateTime(2024, 1, 10, 18, 30, 32, 223, DateTimeKind.Local).AddTicks(6551), false, false, "InitialCreated", new DateTime(2024, 1, 10, 18, 30, 32, 223, DateTimeKind.Local).AddTicks(6551) });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ArticIeId",
                table: "Comments",
                column: "ArticIeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutMe");

            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "ContactInfo");

            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "HomePageSliders");

            migrationBuilder.DropTable(
                name: "Interesteds");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "SiteIdentity");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "SocialMediaAccounts");

            migrationBuilder.DropTable(
                name: "Summary");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
