using Microsoft.AspNetCore.Mvc;
using Menu.Data;
using Menu.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;

namespace Menu.Controllers
{
    public class Menu : Controller
    {
        private readonly MenuService _menuService;
        public Menu(MenuService menuService) { 
            _menuService = menuService;
        }
        public async Task<IActionResult> Index(string searchString)
        {
            var dishes = await _menuService.GetDishesAsync(searchString);
            return View(dishes);
        }

        public async Task<IActionResult> Details(int? id)
        {
            var dish = await _menuService.GetDishDetailsAsync(id);
            if (dish == null) { 
                return NotFound();
            }
            return View(dish);
        }
    }
}
