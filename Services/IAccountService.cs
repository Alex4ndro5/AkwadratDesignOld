using AkwadratDesign.Models.DbModels;

namespace AkwadratDesign.Services
{
    public interface IAccountService
    {
        public User Login(string login, string password);
    }
}
