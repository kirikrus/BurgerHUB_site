using BurgerHUB.Models;

namespace BurgerHUB.Interfaces
{
    public interface IClients
    {
        IEnumerable<ClientID> Clients { get; }
    }
}
