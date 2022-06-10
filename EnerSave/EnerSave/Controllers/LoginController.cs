using ConsultasMVC;
using EnerSave.Dominio;
using EnerSave.Views.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
namespace EnerSave.Controllers
{
    public class LoginController : Controller
    {

        private readonly IUsuarioStore _model;

        public LoginController(IUsuarioStore model)
        {
            _model = model;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Logout()
        {
            LoginSingleton.Instance.IdUsuario = 0;
            LoginSingleton.Instance.Logado = false;
            LoginSingleton.Instance.Usuario = string.Empty;
            LoginSingleton.Instance.Nome = string.Empty;

            return Redirect("/");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(UsuarioViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (_model.LoginAsync(model.Login, model.Senha).Result)
                {
                    var usuario = await _model.GetByLogin(model.Login);

                    LoginSingleton.Instance.IdUsuario = usuario.Id;
                    LoginSingleton.Instance.Logado = true;
                    LoginSingleton.Instance.Usuario = usuario.Login;
                    LoginSingleton.Instance.Nome = usuario.Nome;

                    return Redirect("/");
                }
            }

            ViewData["Mensagem"] = "Usuário ou senha Inválidos!";

            return View();
        }
    }
}
