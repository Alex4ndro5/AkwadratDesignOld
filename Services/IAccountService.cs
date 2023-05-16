using AkwadratDesign.Models.DbModels;

namespace AkwadratDesign.Services
{
    public interface IAccountService
    {
        public Admin Login(string login, string password);
    }
}
