using Microsoft.AspNetCore.Mvc;

namespace Banklogin.Controllers
{
    public class AccountsController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View(); // Render the Login.cshtml view
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // Validate username and password (you would typically do this against a database)
            if (username == "John" && password == "John@123")
            {
                // If credentials are valid, you might set a session or cookie to keep the user logged in
                return RedirectToAction("Dashboard"); // Redirect to the Dashboard action
            }
            else
            {
                ModelState.AddModelError("", "Invalid username or password");
                return View(); // Return the Login.cshtml view with error message
            }
        }

        // Dashboard action
        public IActionResult Dashboard()
        {
            // Check if the user is authenticated (you would typically do this using sessions or cookies)
            // If not authenticated, redirect to the login page
            // Example:
            // if (!User.Identity.IsAuthenticated)
            // {
            //     return RedirectToAction("Login");
            // }

            return View(); // Render the Dashboard.cshtml view
        }

        // Logout action
        [HttpPost]
        public IActionResult Logout()
        {
            // Perform logout operations such as clearing session or cookie
            // Example:
            // HttpContext.Session.Clear(); // Clear session
            // OR
            // HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme); // Sign out using cookies

            return RedirectToAction("Login"); // Redirect to the Login action
        }
        [HttpGet]
        public IActionResult Profile()
        {
            return RedirectToAction("Dashboard");
        }
        public IActionResult EditProfile()
        {
            return View();
        }
        public IActionResult ChangePassword()
        {
            return View();
        }
        public IActionResult ChangePassword(string currentPassword, string newPassword)
        {

            return RedirectToAction("Profile");
        }
    }
}