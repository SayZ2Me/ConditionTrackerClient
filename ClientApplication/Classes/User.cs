using System.Text;
using System.Security.Cryptography;
using ClientApplication.Managers;
using System.Net;

namespace ClientApplication.Classes
{
    public class User
    {
        private static User _instance;

        private string _name;
        private string _Email;
        private string _accessToken;
        private User(string name, string email, string accessToken)
        {
            _name = name;
            _Email = email;
            _accessToken = accessToken;
        }
        public string AccessToken { get { return _accessToken; } }
        public string Name { get { return _name; } }
        public string Email { get { return _Email; } }

        private static string GetPasswordHash(string password, string salt)
        {
            var sha256encryption = new SHA256Managed();
            string hash = string.Empty;
            byte[] encrypted = sha256encryption.ComputeHash(Encoding.ASCII.GetBytes(salt + password));
            foreach (byte theByte in encrypted) { hash += theByte.ToString("x2"); }
            return hash;
        }
        public static User GetInstance()
        {
            if (_instance == null)
            {
                throw new Exception("You are not logged into the application.");
            }
            else
            {
                return _instance;
            }
        }
        public static bool Login(string email, string password)
        {
            string salt = HttpManager.GetSalt(email);

            string passwordHash = GetPasswordHash(password, salt);

            KeyValuePair<HttpStatusCode, string> response = HttpManager.Authenticate(email, passwordHash);

            if (response.Key == HttpStatusCode.OK)
            {
                _instance = new User("PlaceHolder", email, response.Value);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}