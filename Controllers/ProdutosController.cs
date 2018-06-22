using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using projeto1.Models;

namespace projeto1.Controllers 
{
    public class ProdutosController : Controller 
    {

        //Neste exemplo o Controller está enviando diretamente os resultados para o navegador.
        
        public string Index()
        {
            return "Página inicial de produtos";
        }

        public string Incluir(String nome, String valor) 
        {
            string retorno = "Nome: " + nome + "\n";
            retorno += "Valor: " + valor;

            return retorno;
        }

        public string Excluir (int id) 
        {
            return HtmlEncoder.Default.Encode($"Excluindo o cliente id {id}");
        }
    }

}