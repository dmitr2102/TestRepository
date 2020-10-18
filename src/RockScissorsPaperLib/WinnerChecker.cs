using System.Security.Cryptography;
using System;
// using RandomNumberGenerator;

namespace RockScissorsPaperLib
{
    public class WinnerChecker
    {
        string Game(string s)
        {
            Random rnd = new Random();
            //0 - бумага, 1 - ножницы, 2 - камень
            var n = rnd.Next(0, 3);
            if (s == "rock"){
                if (n == 0)
                {
                    return "You lose";
                }

                else if (n == 1)
                {
                    return "You win";
                }

                else
                {
                    return "Draw";
                }
            }

            else if (s == "scissors")
            {
                if (n == 0)
                {
                    return "You win";
                }
                else if (n == 1)
                {
                    return "Draw";
                }
                else return "You lose";
            }

            else if (s == "paper")
            {
                if (n == 2)
                {
                    return "You win";
                }
                else if (n == 0)
                {
                    return "Draw";
                }
                else return "You lose";
            }
            // NEWLINE
        }
    }
}
