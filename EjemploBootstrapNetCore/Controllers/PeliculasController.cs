using EjemploBootstrapNetCore.Models;
using EjemploBootstrapNetCore.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploBootstrapNetCore.Controllers
{
    public class PeliculasController : Controller
    {
        private RepositoryPeliculas repo;

        public PeliculasController(RepositoryPeliculas repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            List<Pelicula> peliculas = this.repo.GetPeliculas();
            return View(peliculas);
        }

        public IActionResult _InfoPeliculaPartial(int idpelicula)
        {
            Pelicula peli = this.repo.GetPeliculaDetails(idpelicula);
            return PartialView("_InfoPeliculaPartial", peli);
        }

        public IActionResult NormalForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NormalForm(string Titulo, int Duracion, string Sinopsis, string Genero, string Trailer, string Imagen, int Valoracion)
        {
            this.repo.InsertarPelicula(Titulo, Duracion, Sinopsis, Genero, Trailer, Imagen, Valoracion);
            return RedirectToAction("Index");
        }

        public IActionResult ModalForm()
        {
            return PartialView("_ModalForm");
        }

        [HttpPost]
        public IActionResult ModalForm(string Titulo, int Duracion, string Sinopsis, string Genero, string Trailer, string Imagen, int Valoracion)
        {
            this.repo.InsertarPelicula(Titulo, Duracion, Sinopsis, Genero, Trailer, Imagen, Valoracion);
            return RedirectToAction("Index");
        }
    }
}
