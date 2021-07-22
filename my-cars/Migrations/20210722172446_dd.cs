using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace my_cars.Migrations
{
    public partial class dd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "garages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Address = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    District = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Subdistrict = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Province = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    PostCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Tel = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    PackageCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Mail = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    TimeAvaliable = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    FlagActive = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "date", maxLength: 20, nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "date", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_garages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "reasons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReasonDesc = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    FlagActive = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "date", maxLength: 20, nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "date", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reasons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "titles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleName = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    FlagActive = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "date", maxLength: 20, nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "date", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_titles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fname = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Lname = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Tel = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Address = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Gender = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    FlagActive = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "date", maxLength: 20, nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "date", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleId = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_admins_titles_TitleId",
                        column: x => x.TitleId,
                        principalTable: "titles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fname = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Lname = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Tel = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Gender = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    FlagActive = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "date", maxLength: 20, nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "date", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    TitleId = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_customers_titles_TitleId",
                        column: x => x.TitleId,
                        principalTable: "titles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fname = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Lname = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Tel = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    Position = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    FlagActive = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "date", maxLength: 20, nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "date", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    TitleId = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    GarageId = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_employees_garages_GarageId",
                        column: x => x.GarageId,
                        principalTable: "garages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employees_titles_TitleId",
                        column: x => x.TitleId,
                        principalTable: "titles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "adminLogins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UserPass = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    FlagActive = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "date", maxLength: 20, nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "date", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    AdminId = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adminLogins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_adminLogins_admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "carBrands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandCode = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    FlagActive = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "date", maxLength: 20, nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "date", maxLength: 20, nullable: false),
                    BrandName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    AdminId = table.Column<int>(type: "int", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carBrands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_carBrands_admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "custLogins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UserPass = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    ExpirePass = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    FlagActive = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "date", maxLength: 20, nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "date", maxLength: 20, nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    CustomerId = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_custLogins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_custLogins_customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "empLogins",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    UserName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UserPass = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    ExpirePass = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "date", maxLength: 20, nullable: false),
                    FlagActive = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "date", maxLength: 20, nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "date", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    EmployeeId = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empLogins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_empLogins_employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "carModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelCode = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    BrandCode = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    ModelName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    ModelYear = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    SubModelName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    FlagActive = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "date", maxLength: 20, nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "date", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    CarBrandId = table.Column<int>(type: "int", nullable: true),
                    AdminId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_carModels_admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_carModels_carBrands_CarBrandId",
                        column: x => x.CarBrandId,
                        principalTable: "carBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LicenseId = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Province = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    FlagActive = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "date", maxLength: 20, nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "date", maxLength: 20, nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    CarBrandId = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    CarModelId = table.Column<int>(type: "int", maxLength: 20, nullable: true),
                    CustomerId = table.Column<int>(type: "int", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cars_carBrands_CarBrandId",
                        column: x => x.CarBrandId,
                        principalTable: "carBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cars_carModels_CarModelId",
                        column: x => x.CarModelId,
                        principalTable: "carModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cars_customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlagActive = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "date", maxLength: 20, nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "date", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarId = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    CustomerId = table.Column<int>(type: "int", maxLength: 20, nullable: true),
                    GarageId = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_appointments_cars_CarId",
                        column: x => x.CarId,
                        principalTable: "cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_appointments_customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_appointments_garages_GarageId",
                        column: x => x.GarageId,
                        principalTable: "garages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "appointmentDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppDate = table.Column<DateTime>(type: "date", maxLength: 20, nullable: false),
                    AppTime = table.Column<DateTime>(type: "datetime", maxLength: 20, nullable: false),
                    Postpone = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    FinishDate = table.Column<DateTime>(type: "date", maxLength: 20, nullable: false),
                    ConfirmDate = table.Column<DateTime>(type: "date", maxLength: 20, nullable: false),
                    CancelDate = table.Column<DateTime>(type: "date", maxLength: 20, nullable: false),
                    ReasonDesc = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    FlagActive = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "date", maxLength: 20, nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "date", maxLength: 20, nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppointmentId = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    EmployeeId = table.Column<int>(type: "int", maxLength: 20, nullable: true),
                    ReasonId = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appointmentDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_appointmentDetails_appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_appointmentDetails_employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_appointmentDetails_reasons_ReasonId",
                        column: x => x.ReasonId,
                        principalTable: "reasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_adminLogins_AdminId",
                table: "adminLogins",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_admins_TitleId",
                table: "admins",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_appointmentDetails_AppointmentId",
                table: "appointmentDetails",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_appointmentDetails_EmployeeId",
                table: "appointmentDetails",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_appointmentDetails_ReasonId",
                table: "appointmentDetails",
                column: "ReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_appointments_CarId",
                table: "appointments",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_appointments_CustomerId",
                table: "appointments",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_appointments_GarageId",
                table: "appointments",
                column: "GarageId");

            migrationBuilder.CreateIndex(
                name: "IX_carBrands_AdminId",
                table: "carBrands",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_carModels_AdminId",
                table: "carModels",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_carModels_CarBrandId",
                table: "carModels",
                column: "CarBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_cars_CarBrandId",
                table: "cars",
                column: "CarBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_cars_CarModelId",
                table: "cars",
                column: "CarModelId");

            migrationBuilder.CreateIndex(
                name: "IX_cars_CustomerId",
                table: "cars",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_custLogins_CustomerId",
                table: "custLogins",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_customers_TitleId",
                table: "customers",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_empLogins_EmployeeId",
                table: "empLogins",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_employees_GarageId",
                table: "employees",
                column: "GarageId");

            migrationBuilder.CreateIndex(
                name: "IX_employees_TitleId",
                table: "employees",
                column: "TitleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "adminLogins");

            migrationBuilder.DropTable(
                name: "appointmentDetails");

            migrationBuilder.DropTable(
                name: "custLogins");

            migrationBuilder.DropTable(
                name: "empLogins");

            migrationBuilder.DropTable(
                name: "appointments");

            migrationBuilder.DropTable(
                name: "reasons");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "cars");

            migrationBuilder.DropTable(
                name: "garages");

            migrationBuilder.DropTable(
                name: "carModels");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "carBrands");

            migrationBuilder.DropTable(
                name: "admins");

            migrationBuilder.DropTable(
                name: "titles");
        }
    }
}
