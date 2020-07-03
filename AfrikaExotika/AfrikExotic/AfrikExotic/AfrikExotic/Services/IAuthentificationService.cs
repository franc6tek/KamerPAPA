using AfrikExotic.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AfrikExotic.Services
{
    public interface IAuthentificationService
    {
        Task<string> Login(string email, string passWord);
        Task<string> Register(string email, string passWord);
    }
}
