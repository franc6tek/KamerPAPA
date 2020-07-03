using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AfrikExotic.iOS.Services;
using AfrikExotic.Services;
using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(AuthentificationService))]
namespace AfrikExotic.iOS.Services
{
    public class AuthentificationService : IAuthentificationService
    {
        public async Task<string> Login(string email, string passWord)
        {
            try
            {
                var user = await Firebase.Auth.Auth.DefaultInstance.SignInWithPasswordAsync(email, passWord);
                var token = await user.User.GetIdTokenAsync(false);
                return token;
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
                var user = await Firebase.Auth.Auth.DefaultInstance.CreateUserAsync(email, passWord);
                var token = await user.User.GetIdTokenAsync(false);
                return token;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}