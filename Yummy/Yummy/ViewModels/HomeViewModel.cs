using Yummy.Models;

namespace Yummy.ViewModels
{
    public class HomeViewModel
    {
        public List<Category> Categories { get; set; }

        public List<Meal> Meals { get; set; }
    }
}
