using BurgerHUB.Models;

namespace BurgerHUB.Data.Interfaces
{
    public interface IClients
    {
        IEnumerable<ClientID> Clients { get; }
    }
}
