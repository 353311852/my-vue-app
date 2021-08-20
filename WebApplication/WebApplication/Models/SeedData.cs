using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplication.Models
{
	public class SeedData
	{
		public async static Task InitializeAsync(IServiceProvider serviceProvider)
		{
			using (var context = new MovieContext(serviceProvider.GetRequiredService<DbContextOptions<MovieContext>>()))
			{
				if (context.Movie.Any())
				{
					return;
				}
				await context.Movie.AddRangeAsync(
					new Movie
					{
						Title = "When Harry Met Sally",
						ReleaseDate = DateTime.Parse("1989-2-12"),
						Genre = "Romantic Comedy",
						Price = 7.99M,
						Rating = "R"
					},

					new Movie
					{
						Title = "Ghostbusters ",
						ReleaseDate = DateTime.Parse("1984-3-13"),
						Genre = "Comedy",
						Price = 8.99M,
						Rating = "R"
					},

					new Movie
					{
						Title = "Ghostbusters 2",
						ReleaseDate = DateTime.Parse("1986-2-23"),
						Genre = "Comedy",
						Price = 9.99M,
						Rating = "R"
					},

					new Movie
					{
						Title = "Rio Bravo",
						ReleaseDate = DateTime.Parse("1959-4-15"),
						Genre = "Western",
						Price = 3.99M,
						Rating = "R"
					},

					new Movie
					{
						Title = "白 泽",
						ReleaseDate = DateTime.Parse("1995-9-22"),
						Genre = "Western",
						Price = 100.99M,
						Rating = "R"
					}
					);
				context.SaveChanges();
			}
		}
	}
}
