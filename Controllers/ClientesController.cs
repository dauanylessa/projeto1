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
        
        public string Index(){

            return "Lista de clientes";

        }

        public string Incluir(){
            return "Inclusão de clientes";
        }
    }
} 