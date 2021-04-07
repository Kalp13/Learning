using BookStore.WASM.Models;
using System.Threading.Tasks;

namespace BookStore.WASM.Contracts
{
    public interface IAuthenticationRepository
    {
        Task<bool> Register(UserRegistrationModel user);

        Task<bool> Login(UserLoginModel user);

        Task LogOut();
    }
}
