﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotShop.Models;
using dotShop.Models.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dotShop.Controllers
{
    public class ProductController : Controller
    {
        // GET: /<controller>/
        private IProductRepository repository;
        public int PageSize = 4;

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }


        //public ViewResult List(int productPage = 1)
        //    => View(new ProductsListViewModel
        //    {
        //        Products = repository.Products
        //            .OrderBy(p => p.ProductId)
        //            .Skip((productPage - 1) * PageSize)
        //            .Take(PageSize),
        //        PagingInfo = new PagingInfo
        //        {
        //            CurrentPage = productPage,
        //            ItemsPerPage = PageSize,
        //            TotalItems = repository.Products.Count()
        //        }
        //    });

        public ViewResult List(int productPage = 1)
            => View(repository.Products
                .OrderBy(p => p.ProductId)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize));

        //public ViewResult List() => View(repository.Products);

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
