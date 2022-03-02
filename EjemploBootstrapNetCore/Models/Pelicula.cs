using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploBootstrapNetCore.Models
{
	[Table("PELICULA")]
	public class Pelicula
	{
		[Key]
		[Column("ID_PELICULA")]
		public int IdPelicula { get; set; }

		[Column("TITULO")]
		public string Titulo { get; set; }

		[Column("DURACION")]
		public int Duracion { get; set; }

		[Column("GENERO")]
		public string Genero { get; set; }

		[Column("SINOPSIS")]
		public string Sinopsis { get; set; }

		[Column("TRAILER")]
		public string Trailer { get; set; }

		[Column("IMAGEN")]
		public string Imagen { get; set; }

		[Column("VALORACION")]
		public int Valoracion { get; set; }
	}
}
