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
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Ghostbusters",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Rating = "Not Rated"
                },
                new Movie
                {
                    Title = "The Dark Knight",
                    ReleaseDate = DateTime.Parse("2008-07-18"),
                    Genre = "Action",
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Pulp Fiction",
                    ReleaseDate = DateTime.Parse("1994-10-14"),
                    Genre = "Crime",
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Forrest Gump",
                    ReleaseDate = DateTime.Parse("1994-07-06"),
                    Genre = "Drama",
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "The Matrix",
                    ReleaseDate = DateTime.Parse("1999-03-31"),
                    Genre = "Sci-Fi",
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Inception",
                    ReleaseDate = DateTime.Parse("2010-07-16"),
                    Genre = "Sci-Fi",
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "The Silence of the Lambs",
                    ReleaseDate = DateTime.Parse("1991-02-14"),
                    Genre = "Thriller",
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Jurassic Park",
                    ReleaseDate = DateTime.Parse("1993-06-11"),
                    Genre = "Adventure",
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "The Shawshank Redemption",
                    ReleaseDate = DateTime.Parse("1994-09-10"),
                    Genre = "Drama",
                    Rating = "R"
                },
                new Movie
                {
                    Title = "The Godfather",
                    ReleaseDate = DateTime.Parse("1972-03-24"),
                    Genre = "Crime",
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Fight Club",
                    ReleaseDate = DateTime.Parse("1999-10-15"),
                    Genre = "Drama",
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Schindler's List",
                    ReleaseDate = DateTime.Parse("1993-12-15"),
                    Genre = "Biography",
                    Rating = "R"
                },
                new Movie
                {
                    Title = "The Lord of the Rings: The Fellowship of the Ring",
                    ReleaseDate = DateTime.Parse("2001-12-19"),
                    Genre = "Fantasy",
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Titanic",
                    ReleaseDate = DateTime.Parse("1997-12-19"),
                    Genre = "Romance",
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Eternal Sunshine of the Spotless Mind",
                    ReleaseDate = DateTime.Parse("2004-03-19"),
                    Genre = "Romance",
                    Rating = "R"
                },
                new Movie
                {
                    Title = "The Avengers",
                    ReleaseDate = DateTime.Parse("2012-05-04"),
                    Genre = "Action",
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "The Grand Budapest Hotel",
                    ReleaseDate = DateTime.Parse("2014-03-07"),
                    Genre = "Comedy",
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Casablanca",
                    ReleaseDate = DateTime.Parse("1942-11-26"),
                    Genre = "Drama",
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Gone with the Wind",
                    ReleaseDate = DateTime.Parse("1939-12-15"),
                    Genre = "Drama",
                    Rating = "G"
                },
                new Movie
                {
                    Title = "The Wizard of Oz",
                    ReleaseDate = DateTime.Parse("1939-08-25"),
                    Genre = "Adventure",
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Citizen Kane",
                    ReleaseDate = DateTime.Parse("1941-05-01"),
                    Genre = "Drama",
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "The Graduate",
                    ReleaseDate = DateTime.Parse("1967-12-22"),
                    Genre = "Comedy",
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Star Wars: Episode IV - A New Hope",
                    ReleaseDate = DateTime.Parse("1977-05-25"),
                    Genre = "Action",
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "The Breakfast Club",
                    ReleaseDate = DateTime.Parse("1985-02-15"),
                    Genre = "Drama",
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Back to the Future",
                    ReleaseDate = DateTime.Parse("1985-07-03"),
                    Genre = "Adventure",
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "The Lion King",
                    ReleaseDate = DateTime.Parse("1994-06-15"),
                    Genre = "Animation",
                    Rating = "G"
                },
                new Movie
                {
                    Title = "Avatar",
                    ReleaseDate = DateTime.Parse("2009-12-18"),
                    Genre = "Action",
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Toy Story",
                    ReleaseDate = DateTime.Parse("1995-11-22"),
                    Genre = "Animation",
                    Rating = "G"
                },
                new Movie
                {
                    Title = "Jaws",
                    ReleaseDate = DateTime.Parse("1975-06-20"),
                    Genre = "Adventure",
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "The Terminator",
                    ReleaseDate = DateTime.Parse("1984-10-26"),
                    Genre = "Action",
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Braveheart",
                    ReleaseDate = DateTime.Parse("1995-05-24"),
                    Genre = "Biography",
                    Rating = "R"
                },
                new Movie
                {
                    Title = "The Shining",
                    ReleaseDate = DateTime.Parse("1980-05-23"),
                    Genre = "Horror",
                    Rating = "R"
                },
                new Movie
                {
                    Title = "The Great Gatsby",
                    ReleaseDate = DateTime.Parse("2013-05-10"),
                    Genre = "Drama",
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "The Social Network",
                    ReleaseDate = DateTime.Parse("2010-10-01"),
                    Genre = "Biography",
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "La La Land",
                    ReleaseDate = DateTime.Parse("2016-12-09"),
                    Genre = "Musical",
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "The Revenant",
                    ReleaseDate = DateTime.Parse("2015-12-25"),
                    Genre = "Adventure",
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Coco",
                    ReleaseDate = DateTime.Parse("2017-11-22"),
                    Genre = "Animation",
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "The Shape of Water",
                    ReleaseDate = DateTime.Parse("2017-12-22"),
                    Genre = "Drama",
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Get Out",
                    ReleaseDate = DateTime.Parse("2017-02-24"),
                    Genre = "Horror",
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Black Panther",
                    ReleaseDate = DateTime.Parse("2018-02-16"),
                    Genre = "Action",
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Bohemian Rhapsody",
                    ReleaseDate = DateTime.Parse("2018-11-02"),
                    Genre = "Biography",
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "A Star Is Born",
                    ReleaseDate = DateTime.Parse("2018-10-05"),
                    Genre = "Drama",
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Parasite",
                    ReleaseDate = DateTime.Parse("2019-05-21"),
                    Genre = "Comedy",
                    Rating = "R"
                },
                new Movie
                {
                    Title = "1917",
                    ReleaseDate = DateTime.Parse("2019-12-25"),
                    Genre = "Drama",
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Soul",
                    ReleaseDate = DateTime.Parse("2020-12-25"),
                    Genre = "Animation",
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Nomadland",
                    ReleaseDate = DateTime.Parse("2020-09-11"),
                    Genre = "Drama",
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Dune",
                    ReleaseDate = DateTime.Parse("2021-10-22"),
                    Genre = "Sci-Fi",
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Encanto",
                    ReleaseDate = DateTime.Parse("2021-11-24"),
                    Genre = "Animation",
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Moonlight Serenade",
                    ReleaseDate = DateTime.Parse("2010-05-21"),
                    Genre = "Drama",
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Whispers of the Wind",
                    ReleaseDate = DateTime.Parse("2018-09-14"),
                    Genre = "Romance",
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Starlight Symphony",
                    ReleaseDate = DateTime.Parse("2015-12-10"),
                    Genre = "Musical",
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Midnight Mirage",
                    ReleaseDate = DateTime.Parse("2019-04-03"),
                    Genre = "Thriller",
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Labyrinth of Illusions",
                    ReleaseDate = DateTime.Parse("2021-08-22"),
                    Genre = "Fantasy",
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Ephemeral Echoes",
                    ReleaseDate = DateTime.Parse("2017-06-11"),
                    Genre = "Sci-Fi",
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Enigma Enclave",
                    ReleaseDate = DateTime.Parse("2020-11-30"),
                    Genre = "Mystery",
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Velvet Vortex",
                    ReleaseDate = DateTime.Parse("2018-02-27"),
                    Genre = "Drama",
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Mystical Meadows",
                    ReleaseDate = DateTime.Parse("2016-03-17"),
                    Genre = "Adventure",
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Whirlwind Waltz",
                    ReleaseDate = DateTime.Parse("2014-07-08"),
                    Genre = "Romantic Comedy",
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Chronicles of Cosmos",
                    ReleaseDate = DateTime.Parse("2022-01-05"),
                    Genre = "Sci-Fi",
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Solstice Sonata",
                    ReleaseDate = DateTime.Parse("2019-12-18"),
                    Genre = "Drama",
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Aurora Awakening",
                    ReleaseDate = DateTime.Parse("2016-11-27"),
                    Genre = "Fantasy",
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Stardust Symphony",
                    ReleaseDate = DateTime.Parse("2018-10-01"),
                    Genre = "Musical",
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Echoes of Eternity",
                    ReleaseDate = DateTime.Parse("2017-03-29"),
                    Genre = "Drama",
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Celestial Chronicles",
                    ReleaseDate = DateTime.Parse("2020-08-14"),
                    Genre = "Sci-Fi",
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Whispering Waves",
                    ReleaseDate = DateTime.Parse("2015-06-20"),
                    Genre = "Romance",
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Journey to Jupiter",
                    ReleaseDate = DateTime.Parse("2021-09-30"),
                    Genre = "Adventure",
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Rhapsody in Red",
                    ReleaseDate = DateTime.Parse("2018-12-19"),
                    Genre = "Drama",
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Sapphire Skyline",
                    ReleaseDate = DateTime.Parse("2016-07-22"),
                    Genre = "Action",
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Dreamscape",
                    ReleaseDate = DateTime.Parse("2014-04-16"),
                    Genre = "Fantasy",
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Midnight Masquerade",
                    ReleaseDate = DateTime.Parse("2020-02-11"),
                    Genre = "Romantic Comedy",
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Eternal Embrace",
                    ReleaseDate = DateTime.Parse("2017-01-28"),
                    Genre = "Romance",
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Echoes of Eden",
                    ReleaseDate = DateTime.Parse("2015-08-29"),
                    Genre = "Drama",
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Serenade of the Stars",
                    ReleaseDate = DateTime.Parse("2019-07-17"),
                    Genre = "Musical",
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Cascade of Dreams",
                    ReleaseDate = DateTime.Parse("2016-09-13"),
                    Genre = "Fantasy",
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Aurora Ascending",
                    ReleaseDate = DateTime.Parse("2018-11-30"),
                    Genre = "Sci-Fi",
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Whispers in the Wind",
                    ReleaseDate = DateTime.Parse("2014-03-20"),
                    Genre = "Romance",
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Echoes of Enchantment",
                    ReleaseDate = DateTime.Parse("2020-05-12"),
                    Genre = "Fantasy",
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Spectacle of the Stars",
                    ReleaseDate = DateTime.Parse("2017-04-28"),
                    Genre = "Musical",
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Midnight Melodies",
                    ReleaseDate = DateTime.Parse("2019-08-22"),
                    Genre = "Romance",
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Symphony of Shadows",
                    ReleaseDate = DateTime.Parse("2015-10-18"),
                    Genre = "Thriller",
                    Rating = "R"
                }
            );
            context.SaveChanges();
        }
    }
}