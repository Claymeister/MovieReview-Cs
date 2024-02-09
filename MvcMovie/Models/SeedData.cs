using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Rating = "R",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Ghostbusters",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Rating = "PG",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Rating = "PG",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Rating = "Not Rated",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "The Dark Knight",
                    ReleaseDate = DateTime.Parse("2008-07-18"),
                    Genre = "Action",
                    Rating = "PG-13",
                    Price = 11.99M
                },
                new Movie
                {
                    Title = "Pulp Fiction",
                    ReleaseDate = DateTime.Parse("1994-10-14"),
                    Genre = "Crime",
                    Rating = "R",
                    Price = 10.99M
                },
                new Movie
                {
                    Title = "Forrest Gump",
                    ReleaseDate = DateTime.Parse("1994-07-06"),
                    Genre = "Drama",
                    Rating = "PG-13",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "The Matrix",
                    ReleaseDate = DateTime.Parse("1999-03-31"),
                    Genre = "Sci-Fi",
                    Rating = "R",
                    Price = 12.99M
                },
                new Movie
                {
                    Title = "Inception",
                    ReleaseDate = DateTime.Parse("2010-07-16"),
                    Genre = "Sci-Fi",
                    Rating = "PG-13",
                    Price = 14.99M
                },
                new Movie
                {
                    Title = "The Silence of the Lambs",
                    ReleaseDate = DateTime.Parse("1991-02-14"),
                    Genre = "Thriller",
                    Rating = "R",
                    Price = 10.99M
                },
                new Movie
                {
                    Title = "Jurassic Park",
                    ReleaseDate = DateTime.Parse("1993-06-11"),
                    Genre = "Adventure",
                    Rating = "PG-13",
                    Price = 11.99M
                },
                new Movie
                {
                    Title = "The Shawshank Redemption",
                    ReleaseDate = DateTime.Parse("1994-09-10"),
                    Genre = "Drama",
                    Rating = "R",
                    Price = 12.99M
                },
                new Movie
                {
                    Title = "The Godfather",
                    ReleaseDate = DateTime.Parse("1972-03-24"),
                    Genre = "Crime",
                    Rating = "R",
                    Price = 14.99M
                },
                new Movie
                {
                    Title = "Fight Club",
                    ReleaseDate = DateTime.Parse("1999-10-15"),
                    Genre = "Drama",
                    Rating = "R",
                    Price = 11.99M
                },
                new Movie
                {
                    Title = "Schindler's List",
                    ReleaseDate = DateTime.Parse("1993-12-15"),
                    Genre = "Biography",
                    Rating = "R",
                    Price = 13.99M
                },
                new Movie
                {
                    Title = "The Lord of the Rings: The Fellowship of the Ring",
                    ReleaseDate = DateTime.Parse("2001-12-19"),
                    Genre = "Fantasy",
                    Rating = "PG-13",
                    Price = 14.99M
                },
                new Movie
                {
                    Title = "Titanic",
                    ReleaseDate = DateTime.Parse("1997-12-19"),
                    Genre = "Romance",
                    Rating = "PG-13",
                    Price = 12.99M
                },
                new Movie
                {
                    Title = "Eternal Sunshine of the Spotless Mind",
                    ReleaseDate = DateTime.Parse("2004-03-19"),
                    Genre = "Romance",
                    Rating = "R",
                    Price = 10.99M
                },
                new Movie
                {
                    Title = "The Avengers",
                    ReleaseDate = DateTime.Parse("2012-05-04"),
                    Genre = "Action",
                    Rating = "PG-13",
                    Price = 13.99M
                },
                new Movie
                {
                    Title = "The Grand Budapest Hotel",
                    ReleaseDate = DateTime.Parse("2014-03-07"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 11.99M
                },
                new Movie
                {
                    Title = "Casablanca",
                    ReleaseDate = DateTime.Parse("1942-11-26"),
                    Genre = "Drama",
                    Rating = "PG",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Gone with the Wind",
                    ReleaseDate = DateTime.Parse("1939-12-15"),
                    Genre = "Drama",
                    Rating = "G",
                    Price = 11.99M
                },
                new Movie
                {
                    Title = "The Wizard of Oz",
                    ReleaseDate = DateTime.Parse("1939-08-25"),
                    Genre = "Adventure",
                    Rating = "PG",
                    Price = 12.99M
                },
                new Movie
                {
                    Title = "Citizen Kane",
                    ReleaseDate = DateTime.Parse("1941-05-01"),
                    Genre = "Drama",
                    Rating = "PG",
                    Price = 14.99M
                },
                new Movie
                {
                    Title = "The Graduate",
                    ReleaseDate = DateTime.Parse("1967-12-22"),
                    Genre = "Comedy",
                    Rating = "PG",
                    Price = 10.99M
                },
                new Movie
                {
                    Title = "Star Wars: Episode IV - A New Hope",
                    ReleaseDate = DateTime.Parse("1977-05-25"),
                    Genre = "Action",
                    Rating = "PG",
                    Price = 13.99M
                },
                new Movie
                {
                    Title = "The Breakfast Club",
                    ReleaseDate = DateTime.Parse("1985-02-15"),
                    Genre = "Drama",
                    Rating = "R",
                    Price = 11.99M
                },
                new Movie
                {
                    Title = "Back to the Future",
                    ReleaseDate = DateTime.Parse("1985-07-03"),
                    Genre = "Adventure",
                    Rating = "PG",
                    Price = 12.99M
                },
                new Movie
                {
                    Title = "The Lion King",
                    ReleaseDate = DateTime.Parse("1994-06-15"),
                    Genre = "Animation",
                    Rating = "G",
                    Price = 10.99M
                },
                new Movie
                {
                    Title = "Avatar",
                    ReleaseDate = DateTime.Parse("2009-12-18"),
                    Genre = "Action",
                    Rating = "PG-13",
                    Price = 14.99M
                },
                new Movie
                {
                    Title = "Toy Story",
                    ReleaseDate = DateTime.Parse("1995-11-22"),
                    Genre = "Animation",
                    Rating = "G",
                    Price = 11.99M
                },
                new Movie
                {
                    Title = "Jaws",
                    ReleaseDate = DateTime.Parse("1975-06-20"),
                    Genre = "Adventure",
                    Rating = "PG",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "The Terminator",
                    ReleaseDate = DateTime.Parse("1984-10-26"),
                    Genre = "Action",
                    Rating = "R",
                    Price = 12.99M
                },
                new Movie
                {
                    Title = "Braveheart",
                    ReleaseDate = DateTime.Parse("1995-05-24"),
                    Genre = "Biography",
                    Rating = "R",
                    Price = 13.99M
                },
                new Movie
                {
                    Title = "The Shining",
                    ReleaseDate = DateTime.Parse("1980-05-23"),
                    Genre = "Horror",
                    Rating = "R",
                    Price = 11.99M
                },
                new Movie
                {
                    Title = "The Great Gatsby",
                    ReleaseDate = DateTime.Parse("2013-05-10"),
                    Genre = "Drama",
                    Rating = "PG-13",
                    Price = 14.99M
                },
                new Movie
                {
                    Title = "The Social Network",
                    ReleaseDate = DateTime.Parse("2010-10-01"),
                    Genre = "Biography",
                    Rating = "PG-13",
                    Price = 10.99M
                },
                new Movie
                {
                    Title = "La La Land",
                    ReleaseDate = DateTime.Parse("2016-12-09"),
                    Genre = "Musical",
                    Rating = "PG-13",
                    Price = 11.99M
                },
                new Movie
                {
                    Title = "The Revenant",
                    ReleaseDate = DateTime.Parse("2015-12-25"),
                    Genre = "Adventure",
                    Rating = "R",
                    Price = 13.99M
                },
                new Movie
                {
                    Title = "Coco",
                    ReleaseDate = DateTime.Parse("2017-11-22"),
                    Genre = "Animation",
                    Rating = "PG",
                    Price = 10.99M
                },
                new Movie
                {
                    Title = "The Shape of Water",
                    ReleaseDate = DateTime.Parse("2017-12-22"),
                    Genre = "Drama",
                    Rating = "R",
                    Price = 12.99M
                },
                new Movie
                {
                    Title = "Get Out",
                    ReleaseDate = DateTime.Parse("2017-02-24"),
                    Genre = "Horror",
                    Rating = "R",
                    Price = 11.99M
                },
                new Movie
                {
                    Title = "Black Panther",
                    ReleaseDate = DateTime.Parse("2018-02-16"),
                    Genre = "Action",
                    Rating = "PG-13",
                    Price = 13.99M
                },
                new Movie
                {
                    Title = "Bohemian Rhapsody",
                    ReleaseDate = DateTime.Parse("2018-11-02"),
                    Genre = "Biography",
                    Rating = "PG-13",
                    Price = 14.99M
                },
                new Movie
                {
                    Title = "A Star Is Born",
                    ReleaseDate = DateTime.Parse("2018-10-05"),
                    Genre = "Drama",
                    Rating = "R",
                    Price = 12.99M
                },
                new Movie
                {
                    Title = "Parasite",
                    ReleaseDate = DateTime.Parse("2019-05-21"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 11.99M
                },
                new Movie
                {
                    Title = "1917",
                    ReleaseDate = DateTime.Parse("2019-12-25"),
                    Genre = "Drama",
                    Rating = "R",
                    Price = 12.99M
                },
                new Movie
                {
                    Title = "Soul",
                    ReleaseDate = DateTime.Parse("2020-12-25"),
                    Genre = "Animation",
                    Rating = "PG",
                    Price = 10.99M
                },
                new Movie
                {
                    Title = "Nomadland",
                    ReleaseDate = DateTime.Parse("2020-09-11"),
                    Genre = "Drama",
                    Rating = "R",
                    Price = 12.99M
                },
                new Movie
                {
                    Title = "Dune",
                    ReleaseDate = DateTime.Parse("2021-10-22"),
                    Genre = "Sci-Fi",
                    Rating = "PG-13",
                    Price = 14.99M
                },
                new Movie
                {
                    Title = "Encanto",
                    ReleaseDate = DateTime.Parse("2021-11-24"),
                    Genre = "Animation",
                    Rating = "PG",
                    Price = 11.99M
                },
                new Movie
                {
                    Title = "Moonlight Serenade",
                    ReleaseDate = DateTime.Parse("2010-05-21"),
                    Genre = "Drama",
                    Rating = "PG-13",
                    Price = 12.99M
                },
                new Movie
                {
                    Title = "Whispers of the Wind",
                    ReleaseDate = DateTime.Parse("2018-09-14"),
                    Genre = "Romance",
                    Rating = "PG",
                    Price = 11.99M
                },
                new Movie
                {
                    Title = "Starlight Symphony",
                    ReleaseDate = DateTime.Parse("2015-12-10"),
                    Genre = "Musical",
                    Rating = "PG-13",
                    Price = 14.99M
                },
                new Movie
                {
                    Title = "Midnight Mirage",
                    ReleaseDate = DateTime.Parse("2019-04-03"),
                    Genre = "Thriller",
                    Rating = "R",
                    Price = 10.99M
                },
                new Movie
                {
                    Title = "Labyrinth of Illusions",
                    ReleaseDate = DateTime.Parse("2021-08-22"),
                    Genre = "Fantasy",
                    Rating = "PG",
                    Price = 13.99M
                },
                new Movie
                {
                    Title = "Ephemeral Echoes",
                    ReleaseDate = DateTime.Parse("2017-06-11"),
                    Genre = "Sci-Fi",
                    Rating = "PG-13",
                    Price = 14.99M
                },
                new Movie
                {
                    Title = "Enigma Enclave",
                    ReleaseDate = DateTime.Parse("2020-11-30"),
                    Genre = "Mystery",
                    Rating = "PG-13",
                    Price = 13.99M
                },
                new Movie
                {
                    Title = "Velvet Vortex",
                    ReleaseDate = DateTime.Parse("2018-02-27"),
                    Genre = "Drama",
                    Rating = "R",
                    Price = 12.99M
                },
                new Movie
                {
                    Title = "Mystical Meadows",
                    ReleaseDate = DateTime.Parse("2016-03-17"),
                    Genre = "Adventure",
                    Rating = "PG-13",
                    Price = 11.99M
                },
                new Movie
                {
                    Title = "Whirlwind Waltz",
                    ReleaseDate = DateTime.Parse("2014-07-08"),
                    Genre = "Romantic Comedy",
                    Rating = "PG",
                    Price = 10.99M
                },
                new Movie
                {
                    Title = "Chronicles of Cosmos",
                    ReleaseDate = DateTime.Parse("2022-01-05"),
                    Genre = "Sci-Fi",
                    Rating = "PG-13",
                    Price = 14.99M
                },
                new Movie
                {
                    Title = "Aurora's Awakening",
                    ReleaseDate = DateTime.Parse("2019-12-18"),
                    Genre = "Fantasy",
                    Rating = "PG",
                    Price = 13.99M
                },
                new Movie
                {
                    Title = "Eternal Embrace",
                    ReleaseDate = DateTime.Parse("2013-09-29"),
                    Genre = "Romance",
                    Rating = "PG-13",
                    Price = 11.99M
                },
                new Movie
                {
                    Title = "Majestic Mirage",
                    ReleaseDate = DateTime.Parse("2017-03-08"),
                    Genre = "Drama",
                    Rating = "R",
                    Price = 12.99M
                },
                new Movie
                {
                    Title = "Whispering Willows",
                    ReleaseDate = DateTime.Parse("2016-11-14"),
                    Genre = "Horror",
                    Rating = "R",
                    Price = 11.99M
                },
                new Movie
                {
                    Title = "Lunar Lullaby",
                    ReleaseDate = DateTime.Parse("2015-02-20"),
                    Genre = "Animation",
                    Rating = "G",
                    Price = 10.99M
                },
                new Movie
                {
                    Title = "Magnetic Monsoons",
                    ReleaseDate = DateTime.Parse("2022-07-17"),
                    Genre = "Action",
                    Rating = "PG-13",
                    Price = 14.99M
                },
                new Movie
                {
                    Title = "Spectral Sonata",
                    ReleaseDate = DateTime.Parse("2018-10-30"),
                    Genre = "Musical",
                    Rating = "PG",
                    Price = 13.99M
                },
                new Movie
                {
                    Title = "Silent Symphony",
                    ReleaseDate = DateTime.Parse("2019-06-25"),
                    Genre = "Mystery",
                    Rating = "PG-13",
                    Price = 12.99M
                },
                new Movie
                {
                    Title = "Nebula Nocturne",
                    ReleaseDate = DateTime.Parse("2020-04-01"),
                    Genre = "Sci-Fi",
                    Rating = "PG-13",
                    Price = 11.99M
                },
                new Movie
                {
                    Title = "Radiant Rhapsody",
                    ReleaseDate = DateTime.Parse("2014-08-03"),
                    Genre = "Romantic Comedy",
                    Rating = "PG",
                    Price = 10.99M
                },
                new Movie
                {
                    Title = "Cryptic Carnival",
                    ReleaseDate = DateTime.Parse("2021-03-12"),
                    Genre = "Thriller",
                    Rating = "R",
                    Price = 14.99M
                },
                new Movie
                {
                    Title = "Dreamscape Duet",
                    ReleaseDate = DateTime.Parse("2017-09-28"),
                    Genre = "Drama",
                    Rating = "PG-13",
                    Price = 13.99M
                },
                new Movie
                {
                    Title = "Phantom Phantasy",
                    ReleaseDate = DateTime.Parse("2015-10-22"),
                    Genre = "Fantasy",
                    Rating = "PG",
                    Price = 12.99M
                },
                new Movie
                {
                    Title = "Mystic Mosaic",
                    ReleaseDate = DateTime.Parse("2016-05-07"),
                    Genre = "Adventure",
                    Rating = "PG-13",
                    Price = 11.99M
                },
                new Movie
                {
                    Title = "Surreal Symphony",
                    ReleaseDate = DateTime.Parse("2021-11-09"),
                    Genre = "Musical",
                    Rating = "PG",
                    Price = 10.99M
                },
                new Movie
                {
                    Title = "Everlasting Eclipse",
                    ReleaseDate = DateTime.Parse("2022-04-18"),
                    Genre = "Horror",
                    Rating = "R",
                    Price = 11.99M
                },
                new Movie
                {
                    Title = "Astral Aurora",
                    ReleaseDate = DateTime.Parse("2019-08-26"),
                    Genre = "Animation",
                    Rating = "G",
                    Price = 10.99M
                },
                new Movie
                {
                    Title = "Whimsical Whirlpool",
                    ReleaseDate = DateTime.Parse("2018-06-14"),
                    Genre = "Action",
                    Rating = "PG-13",
                    Price = 14.99M
                },
                new Movie
                {
                    Title = "Celestial Cascade",
                    ReleaseDate = DateTime.Parse("2014-01-19"),
                    Genre = "Romance",
                    Rating = "PG",
                    Price = 13.99M
                },
                new Movie
                {
                    Title = "Ethereal Elegy",
                    ReleaseDate = DateTime.Parse("2013-04-05"),
                    Genre = "Drama",
                    Rating = "R",
                    Price = 12.99M
                },
                new Movie
                {
                    Title = "Cosmic Carnival",
                    ReleaseDate = DateTime.Parse("2020-02-07"),
                    Genre = "Sci-Fi",
                    Rating = "PG-13",
                    Price = 14.99M
                },
                new Movie
                {
                    Title = "Sonic Serendipity",
                    ReleaseDate = DateTime.Parse("2015-07-31"),
                    Genre = "Adventure",
                    Rating = "PG-13",
                    Price = 13.99M
                },
                new Movie
                {
                    Title = "Magnetic Mirage",
                    ReleaseDate = DateTime.Parse("2018-03-26"),
                    Genre = "Thriller",
                    Rating = "R",
                    Price = 12.99M
                },
                new Movie
                {
                    Title = "Neon Nostalgia",
                    ReleaseDate = DateTime.Parse("2016-09-11"),
                    Genre = "Action",
                    Rating = "PG-13",
                    Price = 11.99M
                },
                new Movie
                {
                    Title = "Gossamer Gaze",
                    ReleaseDate = DateTime.Parse("2017-12-02"),
                    Genre = "Fantasy",
                    Rating = "PG",
                    Price = 10.99M
                },
                new Movie
                {
                    Title = "Lunar Luminescence",
                    ReleaseDate = DateTime.Parse("2022-09-06"),
                    Genre = "Romantic Comedy",
                    Rating = "PG",
                    Price = 11.99M
                },
                new Movie
                {
                    Title = "Quantum Quasar",
                    ReleaseDate = DateTime.Parse("2019-01-15"),
                    Genre = "Sci-Fi",
                    Rating = "PG-13",
                    Price = 14.99M
                },
                new Movie
                {
                    Title = "Rhapsody in Ruby",
                    ReleaseDate = DateTime.Parse("2020-06-30"),
                    Genre = "Musical",
                    Rating = "PG",
                    Price = 13.99M
                },
                new Movie
                {
                    Title = "Mystic Mirage",
                    ReleaseDate = DateTime.Parse("2014-04-23"),
                    Genre = "Mystery",
                    Rating = "PG-13",
                    Price = 12.99M
                },
                new Movie
                {
                    Title = "Eternal Echo",
                    ReleaseDate = DateTime.Parse("2015-10-12"),
                    Genre = "Drama",
                    Rating = "R",
                    Price = 11.99M
                }
            );
            context.SaveChanges();
        }
    }
}