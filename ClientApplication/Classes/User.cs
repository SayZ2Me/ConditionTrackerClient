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

        public static string Encrypt(string textToEncrypt, string publicKeyString)
        {
            var bytesToEncrypt = Encoding.UTF8.GetBytes(textToEncrypt);

            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                try
                {
                    rsa.FromXmlString(publicKeyString.ToString());
                    var encryptedData = rsa.Encrypt(bytesToEncrypt, true);
                    var base64Encrypted = Convert.ToBase64String(encryptedData);
                    return base64Encrypted;
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
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
            string publicKeyString = HttpManager.GetPublicKey(email);

            var encryptedPassword = Encrypt(password, publicKeyString).Replace("=","");

            KeyValuePair<HttpStatusCode, string> response = HttpManager.Authenticate(email, encryptedPassword.Replace("+","="));

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