using Menu.Data;
using Menu.Models;
using Microsoft.EntityFrameworkCore;

public class MenuService
{
    private readonly MenuContext _context;

    public MenuService(MenuContext context)
    {
        _context = context;
    }

    public async Task<List<Dish>> GetDishesAsync(string? searchString)
    {
        var dishes = from d in _context.Dishes
                     select d;
        if (!string.IsNullOrEmpty(searchString))
        {
            dishes = dishes.Where(d => d.Name.Contains(searchString));
            return await dishes.ToListAsync();
        }
        return await dishes.ToListAsync();
    }

    public async Task<Dish> GetDishDetailsAsync(int? id)
    {
        var dish = await _context.Dishes
                .Include(di => di.DishIngredients)
                .ThenInclude(i => i.Ingredient)
                .FirstOrDefaultAsync(x => x.Id == id);

        return dish;
    }
}
