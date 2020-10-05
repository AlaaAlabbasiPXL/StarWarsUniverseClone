using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarWarsUniverse.Data.Migrations
{
    public partial class clonemovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Uri", "Created", "Director", "Edited", "EpisodeId", "OpeningCrawl", "Producer", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { "http://swapi.dev/api/films/1/", new DateTime(2014, 12, 10, 14, 23, 31, 880, DateTimeKind.Utc), "George Lucas", new DateTime(2014, 12, 20, 19, 49, 45, 256, DateTimeKind.Utc), 4, @"It is a period of civil war.
                Rebel spaceships, striking
                from a hidden base, have won
                their first victory against
                the evil Galactic Empire.

                During the battle, Rebel
                spies managed to steal secret
                plans to the Empire's
                ultimate weapon, the DEATH
                STAR, an armored space
                station with enough power
                to destroy an entire planet.

                Pursued by the Empire's
                sinister agents, Princess
                Leia races home aboard her
                starship, custodian of the
                stolen plans that can save her
                people and restore
                freedom to the galaxy....", "Gary Kurtz, Rick McCallum", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "A New Hope" },
                    { "http://swapi.dev/api/films/2/", new DateTime(2014, 12, 12, 11, 26, 24, 656, DateTimeKind.Utc), "Irvin Kershner", new DateTime(2014, 12, 15, 13, 7, 53, 386, DateTimeKind.Utc), 5, @"It is a dark time for the
                Rebellion. Although the Death
                Star has been destroyed,
                Imperial troops have driven the
                Rebel forces from their hidden
                base and pursued them across
                the galaxy.

                Evading the dreaded Imperial
                Starfleet, a group of freedom
                fighters led by Luke Skywalker
                has established a new secret
                base on the remote ice world
                of Hoth.

                The evil lord Darth Vader,
                obsessed with finding young
                Skywalker, has dispatched
                thousands of remote probes into
                the far reaches of space....", "Gary Kurtz, Rick McCallum", new DateTime(1980, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Empire Strikes Back" },
                    { "http://swapi.dev/api/films/3/", new DateTime(2014, 12, 18, 10, 39, 33, 255, DateTimeKind.Utc), "Richard Marquand", new DateTime(2014, 12, 20, 9, 48, 37, 462, DateTimeKind.Utc), 6, @"Luke Skywalker has returned to
                his home planet of Tatooine in
                an attempt to rescue his
                friend Han Solo from the
                clutches of the vile gangster
                Jabba the Hutt.

                Little does Luke know that the
                GALACTIC EMPIRE has secretly
                begun construction on a new
                armored space station even
                more powerful than the first
                dreaded Death Star.

                When completed, this ultimate
                weapon will spell certain doom
                for the small band of rebels
                struggling to restore freedom
                to the galaxy...", "Howard G. Kazanjian, George Lucas, Rick McCallum", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Return of the Jedi" },
                    { "http://swapi.dev/api/films/4/", new DateTime(2014, 12, 19, 16, 52, 55, 740, DateTimeKind.Utc), "George Lucas", new DateTime(2014, 12, 20, 10, 54, 7, 216, DateTimeKind.Utc), 1, @"Turmoil has engulfed the
                Galactic Republic. The taxation
                of trade routes to outlying star
                systems is in dispute.

                Hoping to resolve the matter
                with a blockade of deadly
                battleships, the greedy Trade
                Federation has stopped all
                shipping to the small planet
                of Naboo.

                While the Congress of the
                Republic endlessly debates
                this alarming chain of events,
                the Supreme Chancellor has
                secretly dispatched two Jedi
                Knights, the guardians of
                peace and justice in the
                galaxy, to settle the conflict....", "Rick McCallum", new DateTime(1999, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Phantom Menace" },
                    { "http://swapi.dev/api/films/5/", new DateTime(2014, 12, 20, 10, 57, 57, 886, DateTimeKind.Utc), "George Lucas", new DateTime(2014, 12, 20, 20, 18, 48, 516, DateTimeKind.Utc), 2, @"There is unrest in the Galactic
                Senate. Several thousand solar
                systems have declared their
                intentions to leave the Republic.

                This separatist movement,
                under the leadership of the
                mysterious Count Dooku, has
                made it difficult for the limited
                number of Jedi Knights to maintain 
                peace and order in the galaxy.

                Senator Amidala, the former
                Queen of Naboo, is returning
                to the Galactic Senate to vote
                on the critical issue of creating
                an ARMY OF THE REPUBLIC
                to assist the overwhelmed
                Jedi....", "Rick McCallum", new DateTime(2002, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Attack of the Clones" },
                    { "http://swapi.dev/api/films/6/", new DateTime(2014, 12, 20, 18, 49, 38, 403, DateTimeKind.Utc), "George Lucas", new DateTime(2014, 12, 20, 20, 47, 52, 73, DateTimeKind.Utc), 3, @"War! The Republic is crumbling
                under attacks by the ruthless
                Sith Lord, Count Dooku.
                There are heroes on both sides.
                Evil is everywhere.

                In a stunning move, the
                fiendish droid leader, General
                Grievous, has swept into the
                Republic capital and kidnapped
                Chancellor Palpatine, leader of
                the Galactic Senate.

                As the Separatist Droid Army
                attempts to flee the besieged
                capital with their valuable
                hostage, two Jedi Knights lead a
                desperate mission to rescue the
                captive Chancellor....", "Rick McCallum", new DateTime(2005, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Revenge of the Sith" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Uri",
                keyValue: "http://swapi.dev/api/films/1/");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Uri",
                keyValue: "http://swapi.dev/api/films/2/");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Uri",
                keyValue: "http://swapi.dev/api/films/3/");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Uri",
                keyValue: "http://swapi.dev/api/films/4/");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Uri",
                keyValue: "http://swapi.dev/api/films/5/");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Uri",
                keyValue: "http://swapi.dev/api/films/6/");
        }
    }
}
