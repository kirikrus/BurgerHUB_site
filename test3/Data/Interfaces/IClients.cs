using BurgerHUB.Models;

namespace BurgerHUB.Data.Interfaces
{
    public interface IClients
    {
        IEnumerable<Client> Clients { get; }
    }
}
