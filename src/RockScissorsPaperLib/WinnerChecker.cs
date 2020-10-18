using System.Security.Cryptography;
using System;

namespace RockScissorsPaperLib
{
    public class WinnerChecker
    {
        enum t {paper = 0, scissors = 1, rock = 2, lizard}
        public string Game(int p, int n)
        {
            //0 - бумага, 1 - ножницы, 2 - камень
            switch (p, n){
                case (0, 0): 
                case (1, 1):
                case (2, 2):
                    return "Draw";
                    break;
                case (0, 1):
                case (1, 2):
                case (2, 0):
                    return "You lose";
                    break;
                case (0, 2):
                case (1, 0):
                case (2, 1):
                    return "You win";
                    break;
                default:
                    return "Error";
                    break;
            }

            /*if (s == "rock"){
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

            else return "Error";*/
        }
    }
}
