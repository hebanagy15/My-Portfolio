using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {

            List<Project> projects = new List<Project>
            {
                new Project
                {
                    Id = 1,
                    Title = "E-Commerce",
                    Description = "This is a fully functional E-Commerce web application developed using ASP.NET Core MVC. It allows users to browse products, add items to a shopping cart, and place orders. The platform supports product categories, user registration/login, and basic admin features for managing inventory. The application follows the MVC architecture and utilizes Entity Framework Core for database operations.",
                    ImageURL = "/images/e-commerce.png",
                    ProjectURL = "https://github.com/hebanagy15/SWD5_S1_Team_2"

                },
                new Project
                {
                    Id = 2,
                    Title = "Library Management System",
                    Description = "A Library Management System designed to handle and organize the operations of a library using SQL for data storage and management. The system provides functionalities for managing books, members, and borrow/return transactions. The project was developed with a focus on relational database design, using SQL queries, stored procedures, and normalization techniques to ensure data integrity and efficiency.",
                    ImageURL ="/images/Library.png",
                    ProjectURL = "https://github.com/hebanagy15/DataBase-Management-System"
                },
                new Project
                {
                    Id = 3,
                    Title = "Spongbob Test Drive",
                    Description = "It is a game to help Spongebob to get the driver's license and consists of 3 stages,First one, which is the beginning of the game, a two-dimensional window to start or end.Second one, which is a three-dimensional window,in which you collect stars and not injure the fish and the diver.The last, consists of two cases winning or losing.If you win, you get the license and exit.If you lose, you start again or exit.",
                    ImageURL = "/images/Spongbob.jpg",
                    ProjectURL = "https://github.com/hebanagy15/SpongbobTestDrive"
                }
            };
            return View(projects);
        }
    }
}
