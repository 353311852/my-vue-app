using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication.Models;

namespace WebApplication.ViewModels
{
	public class MovieGenreViewModel
	{
		public List<Movie> Movies;
		public SelectList Genres;
		public string MovieGenres { get; set; }
		public string SearchString { get; set; }	
	}
}
