using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreBooks.Models;

namespace CoreBooks.ViewComponents
{
    public class NewBooks:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var bookList = new List<Books>
            {
                new Books
                {
                    ID=6,
                    BookName="Scare",
                    Author="Zweig"
                },
                 new Books
                {
                    ID=7,
                    BookName="Anna Karanina",
                    Author="Tolstoy"
                }

            };
            return View(bookList);
        }
    }
}
