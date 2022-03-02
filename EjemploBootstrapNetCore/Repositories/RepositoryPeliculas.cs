using EjemploBootstrapNetCore.Data;
using EjemploBootstrapNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploBootstrapNetCore.Repositories
{ 
    public class RepositoryPeliculas
    {
        private PeliculasContext context;

        public RepositoryPeliculas(PeliculasContext context)
        {
            this.context = context;
        }

        public List<Pelicula> GetPeliculas()
        {
            return this.context.Peliculas.ToList();
        }

        public Pelicula GetPeliculaDetails(int idpelicula)
        {
            return this.GetPeliculas().FirstOrDefault(z => z.IdPelicula == idpelicula);
        }

        public int GetMaxIdPeli()
        {
            var max = (from datos in this.context.Peliculas
                       select datos.IdPelicula).Max();

            return max + 1;
        }

        public void InsertarPelicula(string Titulo, int Duracion, string Sinopsis, string Genero, string Trailer, string Imagen, int Valoracion)
        {
            Pelicula peli = new Pelicula();
            peli.IdPelicula = this.GetMaxIdPeli();
            peli.Titulo = Titulo;
            peli.Duracion = Duracion;
            peli.Sinopsis = Sinopsis;
            peli.Genero = Genero;
            peli.Trailer = Trailer;
            peli.Imagen = Imagen;
            peli.Valoracion = Valoracion;

            this.context.Peliculas.Add(peli);
            this.context.SaveChanges();
        }
    }
}
