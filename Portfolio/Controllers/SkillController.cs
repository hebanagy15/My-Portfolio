using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using System.Reflection;

namespace Portfolio.Controllers
{
    public class SkillController : Controller
    {
        public IActionResult Index()
        {
            List<Skill> skills = new List<Skill>()
            {
                new Skill
                {
                    Id = 1,
                    Title = "ASP.NET Core MVC",
                    Type = "Technical"
                },
                new Skill
                {
                    Id = 2,
                    Title = "C# Programming Language",
                    Type = "Technical"
                },
                new Skill
                {
                    Id = 3,
                    Title = "LINQ",
                    Type = "Technical"
                },
                new Skill
                {
                    Id = 4,
                    Title = "SQL",
                    Type = "Technical"
                },
                new Skill
                {
                    Id = 5,
                    Title = "Entity Framework",
                    Type = "Technical"
                },
                new Skill
                {
                    Id = 6,
                    Title = "Problem Solving",
                    Type = "Soft"
                },
                new Skill
                {
                    Id = 7,
                    Title = "Leadership & Teamwork",
                    Type = "Soft"
                },
                new Skill
                {
                    Id = 8,
                    Title = "Python",
                    Type = "Technical"
                },
                new Skill
                {
                    Id = 9,
                    Title = "C++",
                    Type = "Technical"
                },
                new Skill
                {
                    Id = 10,
                    Title = "Data Structure & Algorithms",
                    Type = "Technical"
                }  ,
                new Skill
                {
                    Id = 11,
                    Title = "Time Management",
                    Type = "Soft"
                },
                new Skill
                {
                    Id = 12,
                    Title = "Communication Skills",
                    Type = "Soft"
                },
                new Skill
                {
                    Id = 13,
                    Title = "Continuous Learning",
                    Type = "Soft"
                },
                new Skill
                {
                    Id = 14,
                    Title = "Critical Thinking",
                    Type = "Soft"
                }
                
                

            };
            return View(skills);
        }
    }
}
