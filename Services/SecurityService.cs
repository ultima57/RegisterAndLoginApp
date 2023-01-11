using RegisterAndLoginApp.Models;

namespace RegisterAndLoginApp.Services {
    public class SecurityService {
        List<UserModel> knownusers = new List<UserModel>();

        public SecurityService() {

            using (ApplicationContext db = new ApplicationContext()) {

                var users = db.Users.ToList();

                foreach (var u in users) {

                    knownusers.Add(u);
                }
            }
        }
        public bool alreadyExsists(UserModel user) {
            return knownusers.Any(u => u.Login == user.Login);
        }
        public bool isValid(UserModel user) {
            using (ApplicationContext db = new ApplicationContext()) {

                var newUser = new UserModel { Login = user.Login, Password = user.Password };
                db.Users.Add(newUser);
                db.SaveChanges();
                knownusers.Add(newUser);

            }
            return knownusers.Any(p => p.Login == user.Login && p.Password == user.Password);
        }
    }

}
