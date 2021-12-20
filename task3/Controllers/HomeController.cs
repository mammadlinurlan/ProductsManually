using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using task3.Models;

namespace task3.Controllers
{
    public class HomeController:Controller
    {

        public ActionResult Index()
        {
            List<Product> products = new List<Product>
            {

                new Product()
                {
                    Id = 1,
                     ImageSrc = "dinocase.jpeg",
                      Title = "iPhone 11",
                       Desc = "SWEET DINO CASE",
                        Price = "15 azn"
                },
                  new Product()
                {
                    Id = 2,
                     ImageSrc = "dylanbrian.jpeg",
                      Title = "iPhone X",
                       Desc = "DYLAN O`BRIEN CASE",
                        Price = "15 azn"
                },
                    new Product()
                {
                    Id = 3,
                     ImageSrc = "samsungmodel1.jpeg",
                      Title = "SAMSUNG A30",
                       Desc = "FAMOUS PARENTAL ADVISORY CASE",
                        Price = "15 azn"
                },
                      new Product()
                {
                    Id = 4,
                     ImageSrc = "songip11.jpeg",
                      Title = "iPhone 11",
                       Desc = "SONG PLAYER CASE",
                        Price = "15 azn"
                }
                 



            };



            return View(products);
        }
        
    }
}
