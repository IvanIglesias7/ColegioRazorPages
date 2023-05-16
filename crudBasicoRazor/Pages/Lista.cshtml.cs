using DAL.Modelo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace crudBasicoRazor.Pages
{
    public class ListaModel : PageModel
    {
        //Inicializo el contexto para la conexion
        ColegioBasicoContext cb = new ColegioBasicoContext();

        //Declaro la lista de los alumnos
        public List<Alumno> listAlumnos { get; set; }

        public void OnGet()
        {
            listAlumnos = cb.Alumnos.ToList();
        }
    }

}
