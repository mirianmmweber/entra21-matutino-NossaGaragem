﻿using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View.Controllers
{
    public class CategoriaController : Controller
    {
        private CategoriaRepository repository;

        // Construtor tem como objetivo inicializar
        // objetos ou tipos primitivos que 
        // para o devido funcionamento da classe
        // Sempre executado o contrutor ao 
        // instanciar um objeto da classe ou seja
        // ao fazer 'new CategoriaController()'
        public CategoriaController()
        {
            repository = new CategoriaRepository();
        }

        // GET: Categoria
        public ActionResult Index()
        {
            List<Categoria> categorias = repository.ObterTodos();
            ViewBag.Categorias = categorias;


            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult Store(string nome)
        {
            Categoria categoria = new Categoria();
            categoria.Nome = nome;
            repository.Inserir(categoria);
            return RedirectToAction("Index");

        }
    }
}