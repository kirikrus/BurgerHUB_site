using BurgerHUB.Models;

namespace BurgerHUB.Interfaces
{
    public interface IMenu
    {
        IEnumerable<BurgerIDMenu> BurgersMenu { get; }
    }
}
