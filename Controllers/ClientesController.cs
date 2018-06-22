using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using projeto1.Models;

namespace projeto1.Controllers 
{
    public class ClientesController : Controller
    {
        //Extremidade HTTP = URL 
        
        public IActionResult Index()
        {
            //return "Lista de clientes";
            return View();
        }

        public IActionResult Incluir(String nome)
        {
            //return "Inclusão de clientes";

            ViewData["nome"] = nome;  //Passando dados recebidos do controller para a view.
        
            return View();
        }
    }
} 