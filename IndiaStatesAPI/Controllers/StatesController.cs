using Microsoft.AspNetCore.Mvc;
using IndiaStatesAPI.Models;
using System.Collections.Generic;

namespace IndiaStatesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StatesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetStates()
        {
            var states = new List<IndianState>
            {
                new IndianState { Id = 1, Name = "Andhra Pradesh", Type = "State" },
                new IndianState { Id = 2, Name = "Arunachal Pradesh", Type = "State" },
                new IndianState { Id = 3, Name = "Assam", Type = "State" },
                new IndianState { Id = 4, Name = "Bihar", Type = "State" },
                new IndianState { Id = 5, Name = "Chhattisgarh", Type = "State" },
                new IndianState { Id = 6, Name = "Goa", Type = "State" },
                new IndianState { Id = 7, Name = "Gujarat", Type = "State" },
                new IndianState { Id = 8, Name = "Haryana", Type = "State" },
                new IndianState { Id = 9, Name = "Himachal Pradesh", Type = "State" },
                new IndianState { Id = 10, Name = "Jharkhand", Type = "State" },
                new IndianState { Id = 11, Name = "Karnataka", Type = "State" },
                new IndianState { Id = 12, Name = "Kerala", Type = "State" },
                new IndianState { Id = 13, Name = "Madhya Pradesh", Type = "State" },
                new IndianState { Id = 14, Name = "Maharashtra", Type = "State" },
                new IndianState { Id = 15, Name = "Manipur", Type = "State" },
                new IndianState { Id = 16, Name = "Meghalaya", Type = "State" },
                new IndianState { Id = 17, Name = "Mizoram", Type = "State" },
                new IndianState { Id = 18, Name = "Nagaland", Type = "State" },
                new IndianState { Id = 19, Name = "Odisha", Type = "State" },
                new IndianState { Id = 20, Name = "Punjab", Type = "State" },
                new IndianState { Id = 21, Name = "Rajasthan", Type = "State" },
                new IndianState { Id = 22, Name = "Sikkim", Type = "State" },
                new IndianState { Id = 23, Name = "Tamil Nadu", Type = "State" },
                new IndianState { Id = 24, Name = "Telangana", Type = "State" },
                new IndianState { Id = 25, Name = "Tripura", Type = "State" },
                new IndianState { Id = 26, Name = "Uttar Pradesh", Type = "State" },
                new IndianState { Id = 27, Name = "Uttarakhand", Type = "State" },
                new IndianState { Id = 28, Name = "West Bengal", Type = "State" },

                new IndianState { Id = 29, Name = "Andaman and Nicobar Islands", Type = "Union Territory" },
                new IndianState { Id = 30, Name = "Chandigarh", Type = "Union Territory" },
                new IndianState { Id = 31, Name = "Dadra and Nagar Haveli and Daman and Diu", Type = "Union Territory" },
                new IndianState { Id = 32, Name = "Delhi", Type = "Union Territory" },
                new IndianState { Id = 33, Name = "Jammu and Kashmir", Type = "Union Territory" },
                new IndianState { Id = 34, Name = "Ladakh", Type = "Union Territory" },
                new IndianState { Id = 35, Name = "Lakshadweep", Type = "Union Territory" },
                new IndianState { Id = 36, Name = "Puducherry", Type = "Union Territory" }
            };

            return Ok(states);
        }
    }
}