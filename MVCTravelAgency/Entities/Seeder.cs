using MVCTravelAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTravelAgency.Entities
{
    public class Seeder
    {
        public static void SeedTours(DBContext content)
        {
            if (!content.Categories.Any())
            {
                content.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Tours.Any())
            {
                content.AddRange(
                    new Tour
                    {
                        Name = "«Мікс вікенд: Будапешт + Відень»",
                        Img = "/img/1.jpg",
                        DepartureTown = "Львів",
                        Period = 4,
                        IsNightCrossing = true,
                        Countries = "Авcтрія, Угорщина",
                        Price = 35,
                        DepartureDate = "07/02/2020",
                        isFavorite = true,
                        Category = Categories["Touristic"]
                    },
                    new Tour
                    {
                        Name = "«Прага - моє улюблене місто»",
                        Img = "/img/2.jpg",
                        DepartureTown = "Львів",
                        Period = 4,
                        IsNightCrossing = true,
                        Countries = "Польща, Німеччина, Чехія",
                        Price = 30,
                        DepartureDate = "07/02/2020",
                        isFavorite = true,
                        Category = Categories["Touristic"]
                    },
                     new Tour
                     {
                         Name = "«Європейська мозаїка: Краків-Прага-Відень-Будапешт»",
                         Img = "/img/3.jpg",
                         DepartureTown = "Львів",
                         Period = 4,
                         IsNightCrossing = false,
                         Countries = "Австрія, Польща, Угорщина, Чехія",
                         Price = 115,
                         DepartureDate = "14/02/2020",
                         isFavorite = true,
                         Category = Categories["Touristic"]
                     },
                     new Tour
                     {
                         Name = "«Чарівність Парижу!»",
                         Img = "/img/4.jpg",
                         DepartureTown = "Львів",
                         Period = 6,
                         IsNightCrossing = false,
                         Countries = "Франція, Німеччина, Угорщина",
                         Price = 218,
                         DepartureDate = "28/02/2020",
                         isFavorite = true,
                         Category = Categories["Touristic"]
                     },
                    new Tour
                    {
                        Name = "«Погляд в минуле: Рим, Помпеї, Неаполь»",
                        Img = "/img/5.jpg",
                        DepartureTown = "Львів",
                        Period = 6,
                        IsNightCrossing = false,
                        Countries = "Угорщина, Австрія, Італія, Ватикан",
                        Price = 218,
                        DepartureDate = "05/03/2020",
                        isFavorite = true,
                        Category = Categories["Touristic"]
                    }, new Tour
                    {
                        Name = "«Ласкаві хвилі Адріатики»",
                        Img = "/img/6.jpg",
                        DepartureTown = "Львів",
                        Period = 10,
                        IsNightCrossing = true,
                        Countries = "Хорватія, Угорщина",
                        Price = 320,
                        DepartureDate = "22/05/2020",
                        isFavorite = true,
                        Category = Categories["Relax"]
                    }, new Tour
                    {
                        Name = "«Золоті піски Іспанії!»",
                        Img = "/img/7.jpg",
                        DepartureTown = "Львів",
                        Period = 13,
                        IsNightCrossing = true,
                        Countries = "Іспанія, Італія, Франція, Монако",
                        Price = 320,
                        DepartureDate = "06/05/2020",
                        isFavorite = true,
                        Category = Categories["Relax"]
                    }, new Tour
                    {
                        Name = "«Відпочинок з насолодою: Болгарія і Греція»",
                        Img = "/img/8.jpg",
                        DepartureTown = "Львів",
                        Period = 9,
                        IsNightCrossing = true,
                        Countries = "Болгарія, Греція, Угорщина",
                        Price = 355,
                        DepartureDate = "06/05/2020",
                        isFavorite = true,
                        Category = Categories["Relax"]
                    }
                );

            }
            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                        {
                            new Category {Name = "Touristic", Description = "For sightseeing and touristic"},
                            new Category {Name = "Relax", Description = "For relax"},
                        };

                    category = new Dictionary<string, Category>();
                    foreach (Category item in list)
                    {
                        category.Add(item.Name, item);
                    }
                }
                return category;
            }
        }
    }
}
