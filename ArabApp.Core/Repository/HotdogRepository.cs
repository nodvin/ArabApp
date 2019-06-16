using ArabApp.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabApp.Core.Repository
{
    public class HotdogRepository
    {
        private static List<HotdogGroup> hotdogGroups = new List<HotdogGroup>()
        {
            new HotdogGroup()
            {
                HotdogGroupId = 1, Title = "Meat Lovers", ImagePath = "", Hotdogs = new List<Hotdog>()
                {
                    new Hotdog
                    {
                        HotdogId = 1,
                        Name = "Regular Hotdog",
                        ShortDescription = "The best there is on this planet",
                        Description = "Machego smelly cheese danish fontina",
                        ImagePath = "hotdog1",
                        Available = true,
                        PrepTime = 10,
                        Ingredients = new List<string>() {"Regular Bun" , "Sausage" , "Ketchup", "Mayonnaise"},
                        Price = 8,
                        isFavorite = true
                    },
                    new Hotdog
                    {
                        HotdogId = 1,
                        Name = "Extra long Hotdog",
                        ShortDescription = "The best there is on this planet",
                        Description = "Machego smelly cheese danish fontina",
                        ImagePath = "hotdog2",
                        Available = true,
                        PrepTime = 10,
                        Ingredients = new List<string>() {"Extra long Bun" , "Long Sausage" , "Ketchup", "Mayonnaise"},
                        Price = 8,
                        isFavorite = true
                    }
                }
            },
            new HotdogGroup()
            {
                HotdogGroupId = 1, Title = "Veggie Lovers", ImagePath = "", Hotdogs = new List<Hotdog>()
                {
                    new Hotdog
                    {
                        HotdogId = 4,
                        Name = "Veggie Hotdog", 
                        ShortDescription = "American for non-meat lovers",
                        Description = "Veggies Veggies",
                        ImagePath = "hotdog4",
                        Available = true,
                        PrepTime = 10,
                        Ingredients = new List<string>() {"Bun" , "Veggie Sausage" , "Ketchup", "Mayonnaise"},
                        Price = 8,
                        isFavorite = false
                        
                    }
                }
            }
        };

        public List<Hotdog> GetAllHotdogs()
        {
            IEnumerable<Hotdog> hotdogs =
                from hotdogGroup in hotdogGroups
                from hotdog in hotdogGroup.Hotdogs

                select hotdog;

            return hotdogs.ToList<Hotdog>();
        }

        public Hotdog GetHotdogById(int hotdogId)
        {
            IEnumerable<Hotdog> hotdogs =
                from hotdogGroup in hotdogGroups
                from hotdog in hotdogGroup.Hotdogs
                where hotdog.HotdogId == hotdogId

                select hotdog;

            return hotdogs.FirstOrDefault();
        }

        public List<HotdogGroup> GetGroupedHotdogs()
        {
            return hotdogGroups;
        }

        public List<Hotdog> GetHotdogsForGroup(int hotdogGroupId)
        {
            var group = hotdogGroups.Where(c => c.HotdogGroupId == hotdogGroupId).FirstOrDefault();

            if(group!=null)
            {
                return group.Hotdogs;
            }
            return null;
        }

        public List<Hotdog> GetFavoriteHotdogs()
        {
            IEnumerable<Hotdog> hotdogs =
                from hotdogGroup in hotdogGroups
                from hotdog in hotdogGroup.Hotdogs
                where hotdog.isFavorite
                select hotdog;

            return hotdogs.ToList<Hotdog>();
        }
    }
}
