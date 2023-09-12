using laboratory1.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace laboratory1.Controllers
{
    //зміна обробки запитів
    [ApiController]
    [Route("company")]
    public class CompanyController: ControllerBase
    {
        private readonly Random random = new Random();

        
        public IActionResult GetCompany()
        {
            // ініціалізація властивостей 
            var company = new Company
            {
                YearOfCreation = 10,
                NameCompany = "Unicorn Company",
                Founder = "Nei Anna Vasylivna.",
                Mission = "We offer the highest quality computers for people all over the world"
            };
            //завдання 2 
            var randomNumber = random.Next(0, 101);
            
            var variableToDisplay = $"There are {randomNumber}customers on the site\n" +
                $"Creation date: {company.YearOfCreation} years\n" +
                                $"Company Name: {company.NameCompany}\n" +
                                $"Founder: {company.Founder}\n" +
                                $"Mission: {company.Mission}";


            return Ok(variableToDisplay);
        }

    }
}
