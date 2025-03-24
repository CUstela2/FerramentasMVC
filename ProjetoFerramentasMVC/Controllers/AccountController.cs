using Microsoft.AspNetCore.Mvc;
using ProjetoFerramentasMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFerramentasMVC.Controllers
{
    public class AccountController : Controller
    {
        // GET: /Account/Login
        public IActionResult Login()
        {
            return View();  // Retorna a view Login.cshtml
        }

        // POST: /Account/Login
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            // Lógica de validação de login
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                ViewBag.ErrorMessage = "E-mail e senha são obrigatórios.";
                return View();  // Retorna a view de login com a mensagem de erro
            }

            // Lógica fictícia para autenticação (você pode substituir com uma autenticação real)
            if (email == "usuario@exemplo.com" && password == "senha123")
            {
                // Autenticação bem-sucedida, redirecionar para a página inicial
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Login inválido, mostra uma mensagem de erro
                ViewBag.ErrorMessage = "Credenciais inválidas.";
                return View();
            }
        }

        // GET: /Account/Register
        public IActionResult Register()
        {
            return View();  // Retorna a view Register.cshtml
        }

        // POST: /Account/Register
        [HttpPost]
        public IActionResult Register(string email, string password, string confirmPassword)
        {
            // Lógica para registrar o usuário
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                ViewBag.ErrorMessage = "Todos os campos são obrigatórios.";
                return View();  // Retorna a view de registro com a mensagem de erro
            }

            if (password != confirmPassword)
            {
                ViewBag.ErrorMessage = "As senhas não coincidem.";
                return View();  // Retorna a view com a mensagem de erro
            }

            // Lógica fictícia de registro (você pode adicionar a lógica para salvar no banco de dados)
            // Exemplo fictício: armazenando em uma lista de usuários

            // Supondo que o cadastro tenha sido realizado com sucesso
            ViewBag.SuccessMessage = "Cadastro realizado com sucesso!";
            return RedirectToAction("Login", "Account"); 
        }

        public IActionResult ForgotPassword()
        {
            return View();  
        }

        [HttpPost]
        public IActionResult ForgotPassword(string email)
        {
           
            if (string.IsNullOrEmpty(email))
            {
                ViewBag.ErrorMessage = "Por favor, forneça um e-mail válido.";
                return View();  
            }

            

            ViewBag.SuccessMessage = "Se o e-mail fornecido existir, um link de redefinição foi enviado.";
            return View();  
        }

        // GET: /Account/Logout
        public IActionResult Logout()
        {
        

            return RedirectToAction("Login", "Account"); 
        }

        // GET: /Account/Perfil
        public IActionResult Perfil()
        {
  

            return View(); 
        }
        public IActionResult Cadastro()
{
    return View();  // Certifique-se de que a view será retornada
}
    }
}
