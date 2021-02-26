using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101Assignment2.Controllers
{
    /// <summary>
    /// Recieves four inputs one for a burger, drink, side and a dessert from the menu and provides a message calculating how many calories will be in the meal
    /// </summary>
    /// <param name="burger">The burger choice corresponding to a number on the burgers choices menu</param>
    /// <param name="drink">The drink choice corresponding to a number on the drinks choices menu</param>
    /// <param name="side">The side choice corresponding to a number on the sides choices menu</param>
    /// <param name="dessert">The dessert choice corresponding to a number on the desserts choices menu</param>
    /// <example>GET api/J1/Menu/1/2/3/4 --> "Your total calorie count is 691"</example>
    /// <returns>The amount of calories in the meal based on the users inputs</returns>
    public class J1Controller : ApiController
    {
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        
        public string GetMenu(int burger, int drink, int side, int dessert)
        {

            int[] burgers = { 461, 431, 420, 0 };
            int[] drinks = { 130, 160, 118, 0 };
            int[] sides = { 100, 57, 70, 0 };
            int[] desserts = { 167, 266, 75, 0 };
            var totalCalories = burgers[burger - 1] + drinks[drink - 1] + sides[side - 1] + desserts[dessert - 1];
            string outputMessage = "Your total calorie count is ";

            return outputMessage + totalCalories.ToString();


        }

    }
}
