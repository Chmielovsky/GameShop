using GameShopUI.Models;
using GameShopUI.Repositories;
using GameShopUI.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace GameShopUI.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AdminController(ApplicationDbContext db)
        {
            _db = db;
        }

        [Route("Admin/Panel")]
        public IActionResult Index()
        {
            return View();
        }


        [Route("/admin/panel/product-list")]
        public async Task<IActionResult> ProductList()
        {

            IEnumerable<Game> gamesList = await (from game in _db.Games
                                             join genre in _db.Genres
                                             on game.GenreId equals genre.Id
                                           
                                             select new Game
                                             {
                                                 Id = game.Id,
                                                 Image = game.Image,
                                                 AuthorName = game.AuthorName,
                                                 GameName = game.GameName,
                                                 GenreId = game.GenreId,
                                                 Price = game.Price,
                                                 GenreName = genre.GenreName
                                             }
                         ).ToListAsync();

           

            return View(gamesList);
        }

        [Route("/admin/panel/edit-product/{idProduct}")]
        public IActionResult EditProduct(int idProduct, string GameName, string Image, double Price, string AuthorName)
        {
            
            var game = _db.Games.FirstOrDefault(game => game.Id == idProduct);
            if (game == null)
            {
                Redirect("/admin/panel/product-list");
            }
            if (GameName!= null)
            {
                game.GameName = GameName;
            }

            if (Image!= null)
            {
                game.Image = Image;
            }

            if (Price != 0)
            {
                game.Price = Price;
            }

            if (AuthorName!=null)
            {
                game.AuthorName = AuthorName;
            }

            _db.Games.Update(game);
            _db.SaveChanges();
           
            return View(game);
        }

        [Route("/admin/panel/delete-product/{idProduct}")]
        public IActionResult DeleteProduct(int idProduct)
        {
            var game = _db.Games.FirstOrDefault(game => game.Id == idProduct);
            _db.Games.Remove(game);
            _db.SaveChanges();
            return View();
            
        }


    }
}
