﻿using Microsoft.EntityFrameworkCore;
using Menu.Models;
namespace Menu.Data
{
    public class MenuContext:DbContext
    {
        public MenuContext(DbContextOptions<MenuContext> options) :base(options) { 

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DishIngredient>().HasKey(di => new
            {
                di.DishId,
                di.IngredientId
            });
            modelBuilder.Entity<DishIngredient>().HasOne(d => d.Dish).WithMany(di => di.DishIngredients).HasForeignKey(d => d.DishId);
            modelBuilder.Entity<DishIngredient>().HasOne(d => d.Ingredient).WithMany(di => di.DishIngredients).HasForeignKey(d => d.IngredientId);

            //add some mock data
            modelBuilder.Entity<Dish>().HasData(
                    new Dish { 
                        Id=1,
                        Name="Margheritta", 
                        Price=7.50, 
                        ImageUrl= "https://cdn.shopify.com/s/files/1/0274/9503/9079/files/20220211142754-margherita-9920_5a73220e-4a1a-4d33-b38f-26e98e3cd986.jpg?v=1723650067" 
                    }
                );
            modelBuilder.Entity<Ingredient>().HasData(
                    new Ingredient
                    {
                        Id = 1,
                        Name = "Tomato Sauce"
                    },
                    new Ingredient
                    {
                        Id = 2,
                        Name = "Mzzarella"
                    }
                );
            modelBuilder.Entity<DishIngredient>().HasData(
                new DishIngredient { DishId = 1, IngredientId = 1 },
                new DishIngredient { DishId = 1, IngredientId = 2 }
                );


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<DishIngredient> DishIngredients { get; set; }
    }
}
