using EnRuka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnRuka.Controllers
{
    public class HomeController : Controller
    {
        EnrukaEntities cnx; 

        public HomeController()
           {
               cnx = new EnrukaEntities();
               }
           public ActionResult Formulario()
               {
                   return View();
               }
           public ActionResult Listado()
               {
                   return View(cnx.Producto.ToList());
               }
           public ActionResult Guardar(int id, string insumo, string temporada, string tipo, int cantidad)
               {
                   Producto nuevo = new Producto()
                   {
                       Id = id,
                       Insumo = insumo,
                       Temporada = temporada,
                       Tipo = tipo,
                       Cantidad = cantidad
                   };
                   cnx.Producto.Add(nuevo);
                   cnx.SaveChanges();

                   return View("Listado", cnx.Producto.ToList());
               }
            public ActionResult Eliminar(int Id)
            {
                cnx.Producto.Remove(cnx.Producto.Where(x => x.Id == Id).First());
                cnx.SaveChanges();
                return View("Listado", cnx.Producto.ToList());
            }
           }
        }
