using Models;
using DataLayer;

namespace BusinessLayer

{
    public class UserLogic
    {
        private UnitofWork unit = new UnitofWork(); 
        public User LoggedIn { get; set; }
        public List<User> Users() => (List<User>)unit.UserRepository.GetAllObj();

        public bool Login(string userN, string userP)
        {
            IEnumerable<User> users = Users();
            foreach (User u in users)
            {
                
                if (u.UserName == userN && u.Password == userP)
                {
                    LoggedIn = u;
                    return true;
                }
            }
            return false;
        }
    }
}