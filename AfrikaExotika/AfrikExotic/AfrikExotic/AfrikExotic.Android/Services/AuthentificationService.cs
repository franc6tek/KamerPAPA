using AfrikExotic.Droid.Services;
using AfrikExotic.Services;
using Firebase.Auth;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(AuthentificationService))]
namespace AfrikExotic.Droid.Services
{
    public class AuthentificationService : IAuthentificationService
    {
        public async Task<string> Login(string email, string passWord)
        {
            try
            {
                var user = await FirebaseAuth.Instance.SignInWithEmailAndPasswordAsync(email, passWord);
                var token = await user.User.GetIdTokenAsync(false);
                return token.Token;
            }
            catch (FirebaseAuthInvalidUserException notFound)
            {
                return notFound.Message;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public async Task<string> Register(string email, string passWord)
        {
            try
            {
                var user = await FirebaseAuth.Instance.CreateUserWithEmailAndPasswordAsync(email, passWord);
                var token = await user.User.GetIdTokenAsync(false);
                return token.Token;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}