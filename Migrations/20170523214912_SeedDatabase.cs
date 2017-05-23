using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vega.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Audi')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('BMW')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Toyota')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Honda')");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('A4', 1)");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('A6', 1)");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('A8', 1)");
            
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('X1', 2)");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('X3', 2)");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('X5', 2)");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('X5', 2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Makes WHERE Name IN('Audi', 'BMW', 'Toyota', 'Honda')");
        }
    }
}
