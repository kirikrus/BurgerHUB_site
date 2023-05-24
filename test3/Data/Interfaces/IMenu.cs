using BurgerHUB.Models;

namespace BurgerHUB.Data.Interfaces
{
    public interface IMenu
    {
        IEnumerable<BurgerIDMenu> BurgersMenu { get; }
    }
}
