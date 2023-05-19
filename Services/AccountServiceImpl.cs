using AkwadratDesign.Models.DbModels;

namespace AkwadratDesign.Services
{
    public class AccountServiceImpl : IAccountService
    {
        private List<User> accounts; 


        public AccountServiceImpl()
        {
            accounts = new List<User>
            {
                new User
                {
                    Login= "123",
                    Password = "123"
                }
            };
        }
        public User Login(string login, string password)
        {
            return accounts.SingleOrDefault(a => a.Login == login && a.Password == password);
        }
    }
}
