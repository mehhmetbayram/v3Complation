using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace v3Complation.DataAccess.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bsItemDimTypes",
                columns: table => new
                {
                    ItemDimTypeCode = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemDimTypeDescription = table.Column<string>(maxLength: 150, nullable: false),
                    RowGuid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bsItemDimTypes", x => x.ItemDimTypeCode);
                });

            migrationBuilder.CreateTable(
                name: "bsItemTypes",
                columns: table => new
                {
                    ItemTypeCode = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemTypeDescription = table.Column<string>(maxLength: 150, nullable: false),
                    RowGuid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bsItemTypes", x => x.ItemTypeCode);
                });

            migrationBuilder.CreateTable(
                name: "cdBarcodeTypes",
                columns: table => new
                {
                    BarcodeTypeCode = table.Column<string>(maxLength: 30, nullable: false),
                    BarcodeTypeDescription = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cdBarcodeTypes", x => x.BarcodeTypeCode);
                });

            migrationBuilder.CreateTable(
                name: "cdColors",
                columns: table => new
                {
                    ColorCode = table.Column<string>(maxLength: 10, nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ColorDescription = table.Column<string>(maxLength: 100, nullable: false),
                    SortOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cdColors", x => x.ColorCode);
                });

            migrationBuilder.CreateTable(
                name: "cdHierarchies",
                columns: table => new
                {
                    HierarchyCode = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ParentHierarchyCode = table.Column<int>(nullable: true, defaultValueSql: "0"),
                    HierarchyDescription = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cdHierarchies", x => x.HierarchyCode);
                });

            migrationBuilder.CreateTable(
                name: "cdItemDim1s",
                columns: table => new
                {
                    ItemDim1Code = table.Column<string>(maxLength: 10, nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ItemDim1Description = table.Column<string>(maxLength: 30, nullable: true),
                    SortOrder = table.Column<int>(maxLength: 444, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cdItemDim1s", x => x.ItemDim1Code);
                });

            migrationBuilder.CreateTable(
                name: "cdLanguages",
                columns: table => new
                {
                    LanguageCode = table.Column<string>(maxLength: 10, nullable: false),
                    LanguageDescription = table.Column<string>(maxLength: 30, nullable: false),
                    RowGuid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cdLanguages", x => x.LanguageCode);
                });

            migrationBuilder.CreateTable(
                name: "cdUnitOfMeasures",
                columns: table => new
                {
                    UnitOfMeasureCode = table.Column<string>(maxLength: 30, nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    UnitOfMeasureDescription = table.Column<string>(maxLength: 150, nullable: false),
                    RowGuid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cdUnitOfMeasures", x => x.UnitOfMeasureCode);
                });

            migrationBuilder.CreateTable(
                name: "cItemTaxGrs",
                columns: table => new
                {
                    ItemTaxGrCode = table.Column<string>(maxLength: 30, nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ItemTaxGrDescription = table.Column<string>(maxLength: 30, nullable: false),
                    RowGuid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cItemTaxGrs", x => x.ItemTaxGrCode);
                });

            migrationBuilder.CreateTable(
                name: "bsBasePrices",
                columns: table => new
                {
                    BasePriceCode = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasePriceDescription = table.Column<string>(maxLength: 70, nullable: false),
                    RowGuid = table.Column<Guid>(nullable: false),
                    LanguageCode = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bsBasePrices", x => x.BasePriceCode);
                    table.ForeignKey(
                        name: "FK_bsBasePrices_cdLanguages_LanguageCode",
                        column: x => x.LanguageCode,
                        principalTable: "cdLanguages",
                        principalColumn: "LanguageCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cdCurrencies",
                columns: table => new
                {
                    CurrencyCode = table.Column<string>(maxLength: 10, nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CurrencyDescription = table.Column<string>(maxLength: 30, nullable: false),
                    RowGuid = table.Column<Guid>(nullable: false),
                    LanguageCode = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cdCurrencies", x => x.CurrencyCode);
                    table.ForeignKey(
                        name: "FK_cdCurrencies_cdLanguages_LanguageCode",
                        column: x => x.LanguageCode,
                        principalTable: "cdLanguages",
                        principalColumn: "LanguageCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cdItems",
                columns: table => new
                {
                    ItemCode = table.Column<string>(maxLength: 30, nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ItemTypeCode = table.Column<int>(nullable: false),
                    ItemDescription = table.Column<string>(maxLength: 200, nullable: false),
                    ByWeight = table.Column<short>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UseHome = table.Column<bool>(nullable: false),
                    ItemDimTypeCode = table.Column<int>(nullable: false),
                    UnitOfMeasureCode = table.Column<string>(maxLength: 30, nullable: true),
                    ItemTaxGrCode = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cdItems", x => x.ItemCode);
                    table.ForeignKey(
                        name: "FK_cdItems_bsItemDimTypes_ItemDimTypeCode",
                        column: x => x.ItemDimTypeCode,
                        principalTable: "bsItemDimTypes",
                        principalColumn: "ItemDimTypeCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cdItems_cItemTaxGrs_ItemTaxGrCode",
                        column: x => x.ItemTaxGrCode,
                        principalTable: "cItemTaxGrs",
                        principalColumn: "ItemTaxGrCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cdItems_bsItemTypes_ItemTypeCode",
                        column: x => x.ItemTypeCode,
                        principalTable: "bsItemTypes",
                        principalColumn: "ItemTypeCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cdItems_cdUnitOfMeasures_UnitOfMeasureCode",
                        column: x => x.UnitOfMeasureCode,
                        principalTable: "cdUnitOfMeasures",
                        principalColumn: "UnitOfMeasureCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cdCountries",
                columns: table => new
                {
                    CountryCode = table.Column<string>(maxLength: 10, nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CountryDescription = table.Column<string>(maxLength: 140, nullable: false),
                    CurrencyCode = table.Column<string>(maxLength: 10, nullable: false),
                    LanguageCode = table.Column<string>(maxLength: 10, nullable: false),
                    RowGuid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cdCountries", x => x.CountryCode);
                    table.ForeignKey(
                        name: "FK_cdCountries_cdCurrencies_CurrencyCode",
                        column: x => x.CurrencyCode,
                        principalTable: "cdCurrencies",
                        principalColumn: "CurrencyCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cdCountries_cdLanguages_LanguageCode",
                        column: x => x.LanguageCode,
                        principalTable: "cdLanguages",
                        principalColumn: "LanguageCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "prItemBarcodes",
                columns: table => new
                {
                    Barcode = table.Column<string>(maxLength: 30, nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    BarcodeTypeCode = table.Column<string>(maxLength: 30, nullable: false),
                    ItemTypeCode = table.Column<int>(nullable: false),
                    ItemCode = table.Column<string>(maxLength: 30, nullable: false),
                    ColorCode = table.Column<string>(maxLength: 10, nullable: false),
                    ItemDim1Code = table.Column<string>(maxLength: 10, nullable: false),
                    UnitOfMeasureCode = table.Column<string>(maxLength: 30, nullable: false),
                    Quantity = table.Column<float>(nullable: false),
                    RowGuid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prItemBarcodes", x => x.Barcode);
                    table.ForeignKey(
                        name: "FK_prItemBarcodes_cdBarcodeTypes_BarcodeTypeCode",
                        column: x => x.BarcodeTypeCode,
                        principalTable: "cdBarcodeTypes",
                        principalColumn: "BarcodeTypeCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prItemBarcodes_cdColors_ColorCode",
                        column: x => x.ColorCode,
                        principalTable: "cdColors",
                        principalColumn: "ColorCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prItemBarcodes_cdItems_ItemCode",
                        column: x => x.ItemCode,
                        principalTable: "cdItems",
                        principalColumn: "ItemCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prItemBarcodes_cdItemDim1s_ItemDim1Code",
                        column: x => x.ItemDim1Code,
                        principalTable: "cdItemDim1s",
                        principalColumn: "ItemDim1Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prItemBarcodes_bsItemTypes_ItemTypeCode",
                        column: x => x.ItemTypeCode,
                        principalTable: "bsItemTypes",
                        principalColumn: "ItemTypeCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prItemBarcodes_cdUnitOfMeasures_UnitOfMeasureCode",
                        column: x => x.UnitOfMeasureCode,
                        principalTable: "cdUnitOfMeasures",
                        principalColumn: "UnitOfMeasureCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "prItemHierarchies",
                columns: table => new
                {
                    HierarchyCode = table.Column<int>(nullable: false),
                    ItemCode = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prItemHierarchies", x => new { x.ItemCode, x.HierarchyCode });
                    table.ForeignKey(
                        name: "FK_prItemHierarchies_cdHierarchies_HierarchyCode",
                        column: x => x.HierarchyCode,
                        principalTable: "cdHierarchies",
                        principalColumn: "HierarchyCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_prItemHierarchies_cdItems_ItemCode",
                        column: x => x.ItemCode,
                        principalTable: "cdItems",
                        principalColumn: "ItemCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "prItemNotes",
                columns: table => new
                {
                    ItemCode = table.Column<string>(maxLength: 30, nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    RowGuid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prItemNotes", x => x.ItemCode);
                    table.ForeignKey(
                        name: "FK_prItemNotes_cdItems_ItemCode",
                        column: x => x.ItemCode,
                        principalTable: "cdItems",
                        principalColumn: "ItemCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "prItemPhotos",
                columns: table => new
                {
                    ItemTypeCode = table.Column<int>(nullable: false),
                    ItemCode = table.Column<string>(maxLength: 30, nullable: false),
                    ColorCode = table.Column<string>(maxLength: 10, nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ImagePath = table.Column<string>(maxLength: 300, nullable: false),
                    RowGuid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prItemPhotos", x => new { x.ItemTypeCode, x.ItemCode, x.ColorCode });
                    table.ForeignKey(
                        name: "FK_prItemPhotos_cdColors_ColorCode",
                        column: x => x.ColorCode,
                        principalTable: "cdColors",
                        principalColumn: "ColorCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prItemPhotos_cdItems_ItemCode",
                        column: x => x.ItemCode,
                        principalTable: "cdItems",
                        principalColumn: "ItemCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prItemPhotos_bsItemTypes_ItemTypeCode",
                        column: x => x.ItemTypeCode,
                        principalTable: "bsItemTypes",
                        principalColumn: "ItemTypeCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "prItemVariants",
                columns: table => new
                {
                    ItemTypeCode = table.Column<int>(nullable: false),
                    ItemCode = table.Column<string>(maxLength: 30, nullable: false),
                    ColorCode = table.Column<string>(maxLength: 10, nullable: false),
                    ItemDim1Code = table.Column<string>(maxLength: 10, nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    RowGuid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prItemVariants", x => new { x.ItemTypeCode, x.ItemCode, x.ColorCode, x.ItemDim1Code });
                    table.ForeignKey(
                        name: "FK_prItemVariants_cdColors_ColorCode",
                        column: x => x.ColorCode,
                        principalTable: "cdColors",
                        principalColumn: "ColorCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_prItemVariants_cdItems_ItemCode",
                        column: x => x.ItemCode,
                        principalTable: "cdItems",
                        principalColumn: "ItemCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_prItemVariants_cdItemDim1s_ItemDim1Code",
                        column: x => x.ItemDim1Code,
                        principalTable: "cdItemDim1s",
                        principalColumn: "ItemDim1Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_prItemVariants_bsItemTypes_ItemTypeCode",
                        column: x => x.ItemTypeCode,
                        principalTable: "bsItemTypes",
                        principalColumn: "ItemTypeCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "prItemBasePrices",
                columns: table => new
                {
                    ItemTypeCode = table.Column<int>(nullable: false),
                    ItemCode = table.Column<string>(maxLength: 30, nullable: false),
                    BasePriceCode = table.Column<int>(nullable: false),
                    CountryCode = table.Column<string>(maxLength: 10, nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CurrencyCode = table.Column<string>(maxLength: 10, nullable: true),
                    PriceDate = table.Column<DateTime>(nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    RowGuid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prItemBasePrices", x => new { x.ItemTypeCode, x.ItemCode, x.BasePriceCode, x.CountryCode });
                    table.ForeignKey(
                        name: "FK_prItemBasePrices_bsBasePrices_BasePriceCode",
                        column: x => x.BasePriceCode,
                        principalTable: "bsBasePrices",
                        principalColumn: "BasePriceCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prItemBasePrices_cdCountries_CountryCode",
                        column: x => x.CountryCode,
                        principalTable: "cdCountries",
                        principalColumn: "CountryCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_prItemBasePrices_cdCurrencies_CurrencyCode",
                        column: x => x.CurrencyCode,
                        principalTable: "cdCurrencies",
                        principalColumn: "CurrencyCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prItemBasePrices_cdItems_ItemCode",
                        column: x => x.ItemCode,
                        principalTable: "cdItems",
                        principalColumn: "ItemCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prItemBasePrices_bsItemTypes_ItemTypeCode",
                        column: x => x.ItemTypeCode,
                        principalTable: "bsItemTypes",
                        principalColumn: "ItemTypeCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "trStocks",
                columns: table => new
                {
                    ItemTypeCode = table.Column<int>(nullable: false),
                    ItemCode = table.Column<string>(maxLength: 30, nullable: false),
                    ColorCode = table.Column<string>(maxLength: 10, nullable: false),
                    ItemDim1Code = table.Column<string>(maxLength: 10, nullable: false),
                    Barcode = table.Column<string>(maxLength: 30, nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Quantity = table.Column<float>(nullable: false),
                    RowGuid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trStocks", x => new { x.ItemTypeCode, x.ItemCode, x.ColorCode, x.ItemDim1Code, x.Barcode });
                    table.ForeignKey(
                        name: "FK_trStocks_prItemBarcodes_Barcode",
                        column: x => x.Barcode,
                        principalTable: "prItemBarcodes",
                        principalColumn: "Barcode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_trStocks_cdColors_ColorCode",
                        column: x => x.ColorCode,
                        principalTable: "cdColors",
                        principalColumn: "ColorCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_trStocks_cdItems_ItemCode",
                        column: x => x.ItemCode,
                        principalTable: "cdItems",
                        principalColumn: "ItemCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_trStocks_cdItemDim1s_ItemDim1Code",
                        column: x => x.ItemDim1Code,
                        principalTable: "cdItemDim1s",
                        principalColumn: "ItemDim1Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_trStocks_bsItemTypes_ItemTypeCode",
                        column: x => x.ItemTypeCode,
                        principalTable: "bsItemTypes",
                        principalColumn: "ItemTypeCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "bsItemDimTypes",
                columns: new[] { "ItemDimTypeCode", "ItemDimTypeDescription", "RowGuid" },
                values: new object[,]
                {
                    { 1, "Varyantsiz", new Guid("41e15164-51d3-4b41-a6ff-e07ac2e1bf97") },
                    { 2, "Renk", new Guid("15f928d4-bc89-4342-b5fb-66750546569a") },
                    { 3, "RenkBeden", new Guid("ef77f293-15a6-4db5-9a45-621247a28735") }
                });

            migrationBuilder.InsertData(
                table: "bsItemTypes",
                columns: new[] { "ItemTypeCode", "ItemTypeDescription", "RowGuid" },
                values: new object[,]
                {
                    { 1, "Urun", new Guid("f21d9b06-a130-4dd5-afa6-4e604d9a1a5c") },
                    { 2, "Malzeme", new Guid("b1f1e16a-3ee3-4fe4-8314-860f8ff954dd") },
                    { 4, "Masraf", new Guid("7f506d6a-1550-4ed9-92a0-f71741443d7d") },
                    { 5, "Servis", new Guid("3382898c-c37d-458b-959b-8d99b81d82d4") },
                    { 6, "Sabit Kiymet", new Guid("8c5281dc-658f-4a74-b026-7467c3ac9959") }
                });

            migrationBuilder.InsertData(
                table: "cItemTaxGrs",
                columns: new[] { "ItemTaxGrCode", "CreateDate", "IsActive", "ItemTaxGrDescription", "ModifiedDate", "RowGuid" },
                values: new object[,]
                {
                    { "%0", new DateTime(2020, 4, 1, 1, 15, 40, 696, DateTimeKind.Local).AddTicks(404), true, "Vergisiz", new DateTime(2020, 4, 1, 1, 15, 40, 696, DateTimeKind.Local).AddTicks(408), new Guid("1012e49c-942e-4ec2-a3c7-dafa57b6eaba") },
                    { "%1", new DateTime(2020, 4, 1, 1, 15, 40, 696, DateTimeKind.Local).AddTicks(966), true, "%1 Vergi", new DateTime(2020, 4, 1, 1, 15, 40, 696, DateTimeKind.Local).AddTicks(968), new Guid("920e6cba-f38b-4be2-a9c4-a3c50b5617a0") },
                    { "%8", new DateTime(2020, 4, 1, 1, 15, 40, 696, DateTimeKind.Local).AddTicks(977), true, "%8 Vergi", new DateTime(2020, 4, 1, 1, 15, 40, 696, DateTimeKind.Local).AddTicks(977), new Guid("45707b75-8192-40ad-bd70-9ed991582535") }
                });

            migrationBuilder.InsertData(
                table: "cdLanguages",
                columns: new[] { "LanguageCode", "LanguageDescription", "RowGuid" },
                values: new object[] { "TR", "Turkce", new Guid("c6df3927-9d11-4780-bcbb-d413601fa6c3") });

            migrationBuilder.InsertData(
                table: "cdUnitOfMeasures",
                columns: new[] { "UnitOfMeasureCode", "CreateDate", "IsActive", "ModifiedDate", "RowGuid", "UnitOfMeasureDescription" },
                values: new object[,]
                {
                    { "AD", new DateTime(2020, 4, 1, 1, 15, 40, 685, DateTimeKind.Local).AddTicks(6846), true, new DateTime(2020, 4, 1, 1, 15, 40, 686, DateTimeKind.Local).AddTicks(8720), new Guid("11cb94b1-0f6e-4ece-803b-9f9497bf930e"), "Adet" },
                    { "KG", new DateTime(2020, 4, 1, 1, 15, 40, 687, DateTimeKind.Local).AddTicks(244), true, new DateTime(2020, 4, 1, 1, 15, 40, 687, DateTimeKind.Local).AddTicks(249), new Guid("ed6cb860-4c6d-41dd-9e8c-ab25413718ad"), "Kilo" },
                    { "GR", new DateTime(2020, 4, 1, 1, 15, 40, 687, DateTimeKind.Local).AddTicks(270), true, new DateTime(2020, 4, 1, 1, 15, 40, 687, DateTimeKind.Local).AddTicks(270), new Guid("3719097e-b3f0-42aa-ad31-7feb756c737f"), "Gram" },
                    { "L", new DateTime(2020, 4, 1, 1, 15, 40, 687, DateTimeKind.Local).AddTicks(273), true, new DateTime(2020, 4, 1, 1, 15, 40, 687, DateTimeKind.Local).AddTicks(274), new Guid("581bb191-a356-42c1-8a61-522fee576106"), "Litre" }
                });

            migrationBuilder.InsertData(
                table: "cdCurrencies",
                columns: new[] { "CurrencyCode", "CreateDate", "CurrencyDescription", "IsActive", "LanguageCode", "ModifiedDate", "RowGuid" },
                values: new object[] { "TRY", new DateTime(2020, 4, 1, 1, 15, 40, 772, DateTimeKind.Local).AddTicks(3699), "Türk Lirası", true, "TR", new DateTime(2020, 4, 1, 1, 15, 40, 772, DateTimeKind.Local).AddTicks(3704), new Guid("b11a7e0d-fe21-47ea-92d6-bebad735815f") });

            migrationBuilder.InsertData(
                table: "cdCountries",
                columns: new[] { "CountryCode", "CountryDescription", "CreateDate", "CurrencyCode", "IsActive", "LanguageCode", "ModifiedDate", "RowGuid" },
                values: new object[] { "TR", "Turkiye", new DateTime(2020, 4, 1, 1, 15, 40, 788, DateTimeKind.Local).AddTicks(4697), "TRY", true, "TR", new DateTime(2020, 4, 1, 1, 15, 40, 788, DateTimeKind.Local).AddTicks(4702), new Guid("42c76ba4-2a4a-46a9-9da2-b05a0b960a8e") });

            migrationBuilder.CreateIndex(
                name: "IX_bsBasePrices_LanguageCode",
                table: "bsBasePrices",
                column: "LanguageCode");

            migrationBuilder.CreateIndex(
                name: "IX_cdCountries_CurrencyCode",
                table: "cdCountries",
                column: "CurrencyCode");

            migrationBuilder.CreateIndex(
                name: "IX_cdCountries_LanguageCode",
                table: "cdCountries",
                column: "LanguageCode");

            migrationBuilder.CreateIndex(
                name: "IX_cdCurrencies_LanguageCode",
                table: "cdCurrencies",
                column: "LanguageCode");

            migrationBuilder.CreateIndex(
                name: "IX_cdItems_ItemDimTypeCode",
                table: "cdItems",
                column: "ItemDimTypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_cdItems_ItemTaxGrCode",
                table: "cdItems",
                column: "ItemTaxGrCode");

            migrationBuilder.CreateIndex(
                name: "IX_cdItems_ItemTypeCode",
                table: "cdItems",
                column: "ItemTypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_cdItems_UnitOfMeasureCode",
                table: "cdItems",
                column: "UnitOfMeasureCode");

            migrationBuilder.CreateIndex(
                name: "IX_prItemBarcodes_BarcodeTypeCode",
                table: "prItemBarcodes",
                column: "BarcodeTypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_prItemBarcodes_ColorCode",
                table: "prItemBarcodes",
                column: "ColorCode");

            migrationBuilder.CreateIndex(
                name: "IX_prItemBarcodes_ItemCode",
                table: "prItemBarcodes",
                column: "ItemCode");

            migrationBuilder.CreateIndex(
                name: "IX_prItemBarcodes_ItemDim1Code",
                table: "prItemBarcodes",
                column: "ItemDim1Code");

            migrationBuilder.CreateIndex(
                name: "IX_prItemBarcodes_ItemTypeCode",
                table: "prItemBarcodes",
                column: "ItemTypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_prItemBarcodes_UnitOfMeasureCode",
                table: "prItemBarcodes",
                column: "UnitOfMeasureCode");

            migrationBuilder.CreateIndex(
                name: "IX_prItemBasePrices_BasePriceCode",
                table: "prItemBasePrices",
                column: "BasePriceCode");

            migrationBuilder.CreateIndex(
                name: "IX_prItemBasePrices_CountryCode",
                table: "prItemBasePrices",
                column: "CountryCode");

            migrationBuilder.CreateIndex(
                name: "IX_prItemBasePrices_CurrencyCode",
                table: "prItemBasePrices",
                column: "CurrencyCode");

            migrationBuilder.CreateIndex(
                name: "IX_prItemBasePrices_ItemCode",
                table: "prItemBasePrices",
                column: "ItemCode");

            migrationBuilder.CreateIndex(
                name: "IX_prItemHierarchies_HierarchyCode",
                table: "prItemHierarchies",
                column: "HierarchyCode");

            migrationBuilder.CreateIndex(
                name: "IX_prItemPhotos_ColorCode",
                table: "prItemPhotos",
                column: "ColorCode");

            migrationBuilder.CreateIndex(
                name: "IX_prItemPhotos_ItemCode",
                table: "prItemPhotos",
                column: "ItemCode");

            migrationBuilder.CreateIndex(
                name: "IX_prItemVariants_ColorCode",
                table: "prItemVariants",
                column: "ColorCode");

            migrationBuilder.CreateIndex(
                name: "IX_prItemVariants_ItemCode",
                table: "prItemVariants",
                column: "ItemCode");

            migrationBuilder.CreateIndex(
                name: "IX_prItemVariants_ItemDim1Code",
                table: "prItemVariants",
                column: "ItemDim1Code");

            migrationBuilder.CreateIndex(
                name: "IX_trStocks_Barcode",
                table: "trStocks",
                column: "Barcode");

            migrationBuilder.CreateIndex(
                name: "IX_trStocks_ColorCode",
                table: "trStocks",
                column: "ColorCode");

            migrationBuilder.CreateIndex(
                name: "IX_trStocks_ItemCode",
                table: "trStocks",
                column: "ItemCode");

            migrationBuilder.CreateIndex(
                name: "IX_trStocks_ItemDim1Code",
                table: "trStocks",
                column: "ItemDim1Code");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "prItemBasePrices");

            migrationBuilder.DropTable(
                name: "prItemHierarchies");

            migrationBuilder.DropTable(
                name: "prItemNotes");

            migrationBuilder.DropTable(
                name: "prItemPhotos");

            migrationBuilder.DropTable(
                name: "prItemVariants");

            migrationBuilder.DropTable(
                name: "trStocks");

            migrationBuilder.DropTable(
                name: "bsBasePrices");

            migrationBuilder.DropTable(
                name: "cdCountries");

            migrationBuilder.DropTable(
                name: "cdHierarchies");

            migrationBuilder.DropTable(
                name: "prItemBarcodes");

            migrationBuilder.DropTable(
                name: "cdCurrencies");

            migrationBuilder.DropTable(
                name: "cdBarcodeTypes");

            migrationBuilder.DropTable(
                name: "cdColors");

            migrationBuilder.DropTable(
                name: "cdItems");

            migrationBuilder.DropTable(
                name: "cdItemDim1s");

            migrationBuilder.DropTable(
                name: "cdLanguages");

            migrationBuilder.DropTable(
                name: "bsItemDimTypes");

            migrationBuilder.DropTable(
                name: "cItemTaxGrs");

            migrationBuilder.DropTable(
                name: "bsItemTypes");

            migrationBuilder.DropTable(
                name: "cdUnitOfMeasures");
        }
    }
}
