using AkwadratDesign.Models.DbModels;

namespace AkwadratDesign.Services
{
    public class AccountServiceImpl : IAccountService
    {
        private List<Admin> accounts; 


        public AccountServiceImpl()
        {
            accounts = new List<Admin>
            {
                new Admin
                {
                    Login= "123",
                    Password = "123"
                }
            };
        }
        public Admin Login(string login, string password)
        {
            return accounts.SingleOrDefault(a => a.Login == login && a.Password == password);
        }
    }
}
