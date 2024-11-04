using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopSampleWebApi.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class BaseEntityChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9048), "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/g/200/200/?image=501", "Licensed Cotton Car", 10451.42124238375000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9102), "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/g/200/200/?image=933", "Gorgeous Granite Chips", 36275.346760062017000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9123), "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/g/200/200/?image=385", "Awesome Wooden Cheese", 17059.957289705301000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9142), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/g/200/200/?image=957", "Awesome Steel Table", 10155.699797747881000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9166), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/g/200/200/?image=821", "Ergonomic Rubber Shirt", 38155.599639847885000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9185), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/g/200/200/?image=33", "Rustic Granite Keyboard", 17266.095235529594000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9204), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/g/200/200/?image=70", "Awesome Steel Fish", 39338.369083738598000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9234), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/g/200/200/?image=767", "Generic Cotton Chicken", 24846.580225735519000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9252), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/g/200/200/?image=213", "Rustic Steel Sausages", 31888.621438490452000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9271), "https://picsum.photos/g/200/200/?image=771", "Handcrafted Wooden Pants", 34770.661508831184000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9288), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/g/200/200/?image=43", "Awesome Metal Fish", 28394.123887958814000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9310), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/g/200/200/?image=1001", "Ergonomic Wooden Pants", 15011.434103718044000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9326), "https://picsum.photos/g/200/200/?image=591", "Handmade Cotton Cheese", 9998.482666751606000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9368), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/g/200/200/?image=632", "Ergonomic Frozen Table", 46200.185408754089000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9387), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/g/200/200/?image=812", "Practical Frozen Fish", 32559.252182971352000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9403), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/g/200/200/?image=186", "Handcrafted Wooden Bike", 15638.04783712607000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9421), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/g/200/200/?image=621", "Small Steel Ball", 9380.318096273207000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9439), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/g/200/200/?image=74", "Intelligent Cotton Table", 9340.274950108493000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9454), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/g/200/200/?image=398", "Unbranded Rubber Shoes", 31416.528639597093000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9471), "https://picsum.photos/g/200/200/?image=114", "Ergonomic Fresh Chicken", 15571.163485446099000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9512), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/g/200/200/?image=785", "Generic Cotton Bacon", 47225.812012133138000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9530), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/g/200/200/?image=712", "Handmade Rubber Mouse", 46271.361099747965000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9546), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/g/200/200/?image=304", "Practical Granite Shoes", 4935.9063518868772000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9561), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/g/200/200/?image=178", "Ergonomic Metal Chair", 28384.390795046005000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9576), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/g/200/200/?image=492", "Awesome Metal Hat", 35861.739477710957000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9594), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/g/200/200/?image=673", "Sleek Plastic Chips", 45318.607873751645000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9611), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/g/200/200/?image=822", "Practical Rubber Table", 32967.189689986838000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9648), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/g/200/200/?image=661", "Fantastic Soft Towels", 9668.989800693768000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9665), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/g/200/200/?image=443", "Handcrafted Fresh Keyboard", 9681.850065529956000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9682), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/g/200/200/?image=662", "Intelligent Concrete Tuna", 47997.881627290916000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9700), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/g/200/200/?image=1000", "Tasty Frozen Shoes", 30007.055490124936000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9715), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/g/200/200/?image=985", "Handmade Soft Ball", 48610.615652764395000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9732), "https://picsum.photos/g/200/200/?image=584", "Small Granite Bike", 17521.71654824138000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9766), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/g/200/200/?image=579", "Handmade Metal Pizza", 25785.492696259582000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9783), "https://picsum.photos/g/200/200/?image=53", "Sleek Plastic Fish", 25518.30292260034000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9799), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/g/200/200/?image=557", "Generic Rubber Cheese", 23392.251544519297000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9815), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/g/200/200/?image=386", "Handmade Rubber Hat", 29944.89798448647000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9831), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/g/200/200/?image=45", "Generic Rubber Towels", 43849.774498207236000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9847), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/g/200/200/?image=220", "Tasty Granite Bacon", 35291.850089711956000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9862), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/g/200/200/?image=889", "Licensed Concrete Chips", 40823.001289083782000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9898), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/g/200/200/?image=382", "Small Wooden Chips", 9859.579888962089000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9914), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/g/200/200/?image=805", "Rustic Metal Tuna", 28129.532134466979000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9931), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/g/200/200/?image=34", "Refined Rubber Tuna", 13366.238956287986000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9947), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/g/200/200/?image=997", "Handmade Soft Chair", 27120.493884537528000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9963), "https://picsum.photos/g/200/200/?image=463", "Awesome Granite Cheese", 24294.152708390788000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 249, DateTimeKind.Local).AddTicks(9978), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/g/200/200/?image=841", "Intelligent Metal Shirt", 23603.55004845266000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(10), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/g/200/200/?image=995", "Ergonomic Cotton Fish", 40568.433101673896000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(26), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/g/200/200/?image=243", "Refined Fresh Hat", 35922.503246150037000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(42), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/g/200/200/?image=923", "Tasty Rubber Car", 29514.339794643892000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(56), "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/g/200/200/?image=75", "Generic Concrete Computer", 31389.315365189487000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(71), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/g/200/200/?image=353", "Sleek Frozen Bike", 32567.129271655187000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(85), "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/g/200/200/?image=678", "Tasty Plastic Car", 36835.096401037248000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(100), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/g/200/200/?image=345", "Handmade Rubber Ball", 35896.221714500062000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(141), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/g/200/200/?image=761", "Handcrafted Granite Car", 20636.076779131939000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(157), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/g/200/200/?image=474", "Refined Plastic Hat", 37203.250074041358000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(172), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/g/200/200/?image=423", "Tasty Steel Shoes", 35169.007062568357000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(188), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/g/200/200/?image=121", "Gorgeous Metal Shoes", 47562.650662179134000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(202), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/g/200/200/?image=129", "Ergonomic Fresh Salad", 39633.543957559299000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(218), "https://picsum.photos/g/200/200/?image=83", "Unbranded Concrete Towels", 2931.0115024285099000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(232), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/g/200/200/?image=850", "Small Granite Fish", 3164.2125173018252000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(258), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/g/200/200/?image=208", "Incredible Soft Ball", 15221.303632220209000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(275), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/g/200/200/?image=70", "Awesome Fresh Tuna", 20921.72179607568000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(291), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/g/200/200/?image=836", "Small Wooden Soap", 34651.509672784045000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(306), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/g/200/200/?image=478", "Handcrafted Frozen Towels", 3166.6116586879065000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(322), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/g/200/200/?image=1058", "Intelligent Frozen Soap", 15584.966694701137000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(337), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/g/200/200/?image=265", "Ergonomic Fresh Shirt", 31542.908983262935000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(374), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/g/200/200/?image=7", "Ergonomic Wooden Cheese", 45246.886019415674000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(389), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/g/200/200/?image=556", "Incredible Rubber Pants", 48532.186585286382000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(405), "https://picsum.photos/g/200/200/?image=683", "Awesome Metal Shoes", 21781.254013850197000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(421), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/g/200/200/?image=78", "Gorgeous Steel Hat", 23472.762471036297000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(437), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/g/200/200/?image=896", "Tasty Rubber Sausages", 1132.85975822078218000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(452), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/g/200/200/?image=251", "Small Plastic Chips", 47820.692354340744000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(466), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/g/200/200/?image=408", "Small Steel Mouse", 42057.360431395756000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(505), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/g/200/200/?image=592", "Sleek Wooden Fish", 32611.63755292767000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(521), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/g/200/200/?image=666", "Awesome Frozen Fish", 38591.465918873636000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(538), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/g/200/200/?image=1059", "Practical Fresh Chair", 25978.842639789339000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(553), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/g/200/200/?image=319", "Refined Steel Salad", 15187.363744052296000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(567), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/g/200/200/?image=629", "Sleek Frozen Chair", 34902.893297584444000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(583), "https://picsum.photos/g/200/200/?image=928", "Intelligent Frozen Soap", 21594.959461593342000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(617), "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/g/200/200/?image=340", "Refined Metal Pants", 17598.260333623997000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(633), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/g/200/200/?image=115", "Practical Cotton Towels", 46360.344893555181000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(649), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/g/200/200/?image=21", "Small Wooden Sausages", 25456.87901778275000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(664), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/g/200/200/?image=95", "Gorgeous Fresh Mouse", 9215.589538562182000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(679), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/g/200/200/?image=230", "Generic Plastic Mouse", 31698.803654127539000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(694), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/g/200/200/?image=640", "Ergonomic Cotton Keyboard", 10520.217373388582000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(709), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/g/200/200/?image=620", "Ergonomic Fresh Bacon", 11183.12734368566000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(743), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/g/200/200/?image=1068", "Licensed Soft Table", 24535.048885492116000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(758), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/g/200/200/?image=947", "Fantastic Rubber Cheese", 38357.543659186275000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(774), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/g/200/200/?image=484", "Fantastic Rubber Pizza", 12876.089888560016000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(790), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/g/200/200/?image=817", "Fantastic Frozen Gloves", 20555.812573630375000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(806), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/g/200/200/?image=928", "Licensed Wooden Shoes", 44069.699269023091000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(822), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/g/200/200/?image=88", "Fantastic Plastic Towels", 40619.469730150093000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(854), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/g/200/200/?image=1012", "Unbranded Soft Chips", 23752.126898423167000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(872), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/g/200/200/?image=393", "Handcrafted Soft Mouse", 26843.259460030089000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(888), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/g/200/200/?image=687", "Generic Wooden Chips", 26145.904878313765000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(903), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/g/200/200/?image=262", "Handcrafted Metal Pants", 22332.61410010381000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(918), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/g/200/200/?image=723", "Refined Metal Pants", 5749.5671900939318000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(934), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/g/200/200/?image=504", "Unbranded Frozen Hat", 34830.546150658831000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(949), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/g/200/200/?image=284", "Generic Frozen Fish", 8824.939536107421000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 9, 21, 7, 250, DateTimeKind.Local).AddTicks(981), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/g/200/200/?image=234", "Gorgeous Rubber Computer", 46438.1824161475000m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(4943), null, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/g/200/200/?image=26", "Incredible Concrete Fish", 29464.254324756768000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(4992), null, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/g/200/200/?image=221", "Licensed Steel Mouse", 29161.619845995636000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5023), null, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/g/200/200/?image=967", "Tasty Steel Cheese", 37637.425780276482000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5036), null, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/g/200/200/?image=40", "Licensed Soft Hat", 46010.652231765171000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5047), null, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/g/200/200/?image=667", "Awesome Steel Salad", 44675.17262416364000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5059), null, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/g/200/200/?image=1", "Licensed Wooden Soap", 31884.138616247133000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5071), null, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/g/200/200/?image=170", "Unbranded Plastic Pizza", 13828.7834856692000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5085), null, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/g/200/200/?image=893", "Handmade Rubber Computer", 3892.4100434771668000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5115), null, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/g/200/200/?image=763", "Small Plastic Chicken", 42355.674426735193000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "DeletedOn", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5128), null, "https://picsum.photos/g/200/200/?image=982", "Gorgeous Soft Gloves", 12639.352091038798000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5145), null, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/g/200/200/?image=1010", "Intelligent Soft Car", 25297.379556832207000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5155), null, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/g/200/200/?image=24", "Handcrafted Concrete Bike", 33126.370423937286000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "DeletedOn", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5167), null, "https://picsum.photos/g/200/200/?image=211", "Fantastic Soft Tuna", 26917.610871297978000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5178), null, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/g/200/200/?image=25", "Refined Concrete Sausages", 11259.71469342855000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5199), null, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/g/200/200/?image=839", "Licensed Soft Cheese", 46272.355407414716000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5209), null, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/g/200/200/?image=220", "Tasty Rubber Car", 24167.763143693609000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5220), null, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/g/200/200/?image=219", "Rustic Cotton Sausages", 25425.792467927305000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5231), null, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/g/200/200/?image=3", "Ergonomic Frozen Shirt", 49760.541654092275000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5242), null, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/g/200/200/?image=776", "Sleek Granite Ball", 22839.919218927922000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "DeletedOn", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5251), null, "https://picsum.photos/g/200/200/?image=895", "Ergonomic Wooden Sausages", 15917.933379520388000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5262), null, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/g/200/200/?image=1041", "Intelligent Soft Pants", 47414.912225151358000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5296), null, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/g/200/200/?image=650", "Gorgeous Rubber Chips", 8311.753740879273000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5305), null, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/g/200/200/?image=342", "Intelligent Frozen Salad", 33519.667683683733000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5318), null, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/g/200/200/?image=297", "Intelligent Concrete Table", 3133.580020390476000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5327), null, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/g/200/200/?image=29", "Unbranded Metal Car", 25147.565688032087000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5335), null, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/g/200/200/?image=323", "Unbranded Steel Chicken", 9769.916802923633000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5343), null, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/g/200/200/?image=739", "Tasty Plastic Chips", 34734.188733336126000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5378), null, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/g/200/200/?image=401", "Practical Soft Bike", 24879.89977226007000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5389), null, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/g/200/200/?image=983", "Fantastic Soft Soap", 40174.67050922516000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5399), null, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/g/200/200/?image=124", "Handmade Rubber Bike", 35169.765940720382000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5408), null, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/g/200/200/?image=245", "Handmade Soft Towels", 21772.370822215446000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5419), null, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/g/200/200/?image=515", "Generic Fresh Chair", 44781.59730473116000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "DeletedOn", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5427), null, "https://picsum.photos/g/200/200/?image=602", "Gorgeous Granite Towels", 30799.010941572887000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5454), null, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/g/200/200/?image=471", "Licensed Concrete Cheese", 34934.341076999902000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "DeletedOn", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5464), null, "https://picsum.photos/g/200/200/?image=588", "Awesome Frozen Shirt", 27737.593498983605000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5473), null, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/g/200/200/?image=880", "Awesome Metal Chips", 28417.104913043531000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5482), null, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/g/200/200/?image=144", "Handmade Cotton Chips", 4063.9886962798484000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5492), null, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/g/200/200/?image=666", "Unbranded Cotton Soap", 20868.312940073192000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5500), null, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/g/200/200/?image=275", "Intelligent Steel Bacon", 14650.365506905323000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5510), null, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/g/200/200/?image=1003", "Intelligent Wooden Towels", 36156.383646821969000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5537), null, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/g/200/200/?image=352", "Ergonomic Metal Ball", 30496.699700439818000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5546), null, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/g/200/200/?image=619", "Incredible Frozen Shirt", 47118.486623777904000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5555), null, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/g/200/200/?image=906", "Fantastic Metal Mouse", 42008.111219299406000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5564), null, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/g/200/200/?image=473", "Small Granite Car", 27263.890773061249000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "DeletedOn", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5574), null, "https://picsum.photos/g/200/200/?image=434", "Awesome Granite Shoes", 21783.113089187246000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5583), null, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/g/200/200/?image=143", "Awesome Steel Sausages", 42607.86029960315000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5610), null, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/g/200/200/?image=633", "Ergonomic Frozen Shoes", 14812.253726681795000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5621), null, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/g/200/200/?image=8", "Unbranded Fresh Fish", 33940.870826801084000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5630), null, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/g/200/200/?image=430", "Awesome Metal Soap", 23778.845881966237000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5639), null, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/g/200/200/?image=97", "Rustic Plastic Chicken", 18094.850542796012000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5647), null, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/g/200/200/?image=256", "Refined Cotton Salad", 39968.807219844082000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5656), null, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/g/200/200/?image=642", "Tasty Cotton Chips", 40645.641828280404000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5665), null, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/g/200/200/?image=817", "Fantastic Concrete Tuna", 11842.437694650268000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5694), null, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/g/200/200/?image=593", "Practical Frozen Hat", 23959.991751156075000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5703), null, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/g/200/200/?image=970", "Awesome Plastic Chicken", 39459.940709180501000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5712), null, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/g/200/200/?image=243", "Handmade Concrete Shirt", 33641.267590695638000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5721), null, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/g/200/200/?image=27", "Awesome Frozen Pizza", 11034.216904330136000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5730), null, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/g/200/200/?image=977", "Ergonomic Fresh Pants", 40099.641742407617000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "DeletedOn", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5739), null, "https://picsum.photos/g/200/200/?image=535", "Licensed Concrete Salad", 44709.543442228412000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5747), null, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/g/200/200/?image=796", "Licensed Fresh Chair", 23882.251782828347000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5775), null, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/g/200/200/?image=317", "Refined Rubber Shoes", 48002.12750389674000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5784), null, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/g/200/200/?image=300", "Licensed Metal Sausages", 42028.667345280776000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5794), null, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/g/200/200/?image=634", "Unbranded Cotton Tuna", 33581.820170757291000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5803), null, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/g/200/200/?image=115", "Refined Fresh Shirt", 21215.685312104961000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5812), null, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/g/200/200/?image=958", "Refined Concrete Pizza", 25669.484742869638000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5822), null, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/g/200/200/?image=475", "Refined Rubber Fish", 48727.376469724042000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5842), null, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/g/200/200/?image=357", "Practical Cotton Soap", 20921.875522561803000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5851), null, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/g/200/200/?image=150", "Unbranded Rubber Chips", 22182.76874723863000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "DeletedOn", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5860), null, "https://picsum.photos/g/200/200/?image=15", "Generic Concrete Chair", 30945.182399152622000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5869), null, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/g/200/200/?image=800", "Fantastic Rubber Shoes", 7528.4361392285000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5877), null, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/g/200/200/?image=708", "Unbranded Metal Tuna", 35095.459650670607000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5886), null, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/g/200/200/?image=898", "Handmade Steel Towels", 28467.31019788035000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5917), null, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/g/200/200/?image=793", "Awesome Plastic Towels", 38897.144260940174000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5926), null, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/g/200/200/?image=562", "Intelligent Soft Soap", 47152.166615221058000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5935), null, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/g/200/200/?image=285", "Awesome Frozen Salad", 34219.073193126863000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5944), null, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/g/200/200/?image=589", "Rustic Rubber Shirt", 15715.575939942101000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5953), null, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/g/200/200/?image=555", "Intelligent Soft Bike", 22427.757988555002000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5961), null, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/g/200/200/?image=969", "Tasty Concrete Chair", 45387.770927361988000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "DeletedOn", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(5970), null, "https://picsum.photos/g/200/200/?image=160", "Handcrafted Fresh Chicken", 5062.1482734904848000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(6005), null, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/g/200/200/?image=442", "Sleek Cotton Fish", 34134.311340876018000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(6015), null, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/g/200/200/?image=845", "Licensed Granite Shoes", 12449.112580031007000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(6024), null, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/g/200/200/?image=384", "Rustic Granite Hat", 9506.621691832439000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(6033), null, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/g/200/200/?image=920", "Practical Wooden Pizza", 49859.684851829411000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(6042), null, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/g/200/200/?image=853", "Refined Soft Salad", 12814.884173364839000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(6050), null, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/g/200/200/?image=125", "Handmade Wooden Computer", 30725.218910772784000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(6077), null, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/g/200/200/?image=469", "Refined Cotton Ball", 36398.985344451603000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(6087), null, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/g/200/200/?image=623", "Ergonomic Cotton Salad", 44246.951710848004000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(6096), null, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/g/200/200/?image=444", "Handcrafted Fresh Sausages", 14157.587309863731000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(6104), null, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/g/200/200/?image=101", "Handcrafted Metal Ball", 15719.657430565885000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(6113), null, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/g/200/200/?image=461", "Sleek Steel Keyboard", 3709.641043938234000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(6122), null, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/g/200/200/?image=1027", "Practical Steel Bike", 41138.398146069356000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(6131), null, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/g/200/200/?image=235", "Licensed Cotton Towels", 19722.349643196451000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(6159), null, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/g/200/200/?image=68", "Ergonomic Steel Gloves", 25247.086666677469000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(6168), null, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/g/200/200/?image=447", "Generic Fresh Computer", 11381.064235252634000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(6177), null, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/g/200/200/?image=806", "Licensed Soft Car", 42465.17209688084000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(6186), null, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/g/200/200/?image=303", "Incredible Rubber Chair", 44692.458882355857000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(6194), null, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/g/200/200/?image=362", "Generic Wooden Shoes", 34291.612602509023000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(6203), null, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/g/200/200/?image=715", "Awesome Metal Computer", 22956.693061029643000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(6212), null, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/g/200/200/?image=312", "Ergonomic Frozen Towels", 48539.967336111418000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "DeletedOn", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 9, 52, 58, 169, DateTimeKind.Local).AddTicks(6239), null, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/g/200/200/?image=141", "Rustic Granite Bacon", 6296.216103771096000m });
        }
    }
}
