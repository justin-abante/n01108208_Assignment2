using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101Assignment2.Controllers
{
    /* Each player starts with 100 points.
    The game uses standard six-sided dice and is played in rounds. During one round, each player
    rolls one die. The player with the lower roll loses the number of points shown on the higher die. If
    both players roll the same number, no points are lost by either player.
    Write a program to determine the final scores.
    /// This question was taken from https://cemc.math.uwaterloo.ca/contests/computing/2014/stage%201/juniorEn.pdf
    */

    /// <summary>
    /// A user selects the nmber of rounds of a dice game between two players. Both players start with 100 points are 
    /// rolling a die with 6 sides and whoever rolls the higher the number the loser than loses that amount of points depending on the number rolled. So if Player 1 rolls a 5 and player 2 rolls a 2 then 
    /// player 2 loses 5 points from the initial 100.
    /// </summary>
    /// <param name="numberOfRounds">The number of rounds of the game selected by the user</param>
    /// <returns>The scores of both players</returns>
    /// <example>
    /// Note *Outputs are based on a random number variable so your output will vary every single time even if you enter the same parameters*
    /// GET: api/J3/DoubleDice/3 --> "Player 1: 98 Player 2: 94"
    /// </example>


    public class J3Controller : ApiController
    
    {
        [Route("api/J3/DoubleDice/{numberOfRounds}")]
        public string GetDoubleDice (int numberOfRounds)
          
        {
            int player1 = 100;
            int player2 = 100;
            Random num = new Random();
            string message = "";
            string player1message = "Player 1 Score: ";
            string player2message = "Player 2 Score: ";
      
          


            for (int i = 0; i < numberOfRounds; i++)
            {
                //Random number to simulate a 6 sided die
                int dice1 = num.Next(1, 7);
                int dice2 = num.Next(1, 7);

                if (dice1 > dice2)
                {
                    player2 -= dice1;
                  
                   
                    

                }

                else if (dice2 > dice1)
                {
                    player1 -= dice2;
                  
                   
                }
         
                message =  player1message + player1.ToString() + " " + player2message + player2.ToString(); 


            }

            return message;
        }
    }
}
