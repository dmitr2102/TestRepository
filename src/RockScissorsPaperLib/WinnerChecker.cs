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
            switch (p)
            {
                case (0): 
                    switch(n)
                    {
                        case(0):
                            return "Draw";
                        break;
                        case(1):
                            return "You lose";
                        break;
                        case(2):
                            return "You win";
                        break;
                        default:
                            return "Error";
                        break;
                    }
                break;
                case (1): 
                    switch(n)
                    {
                        case(0):
                            return "You win";
                        break;
                        case(1):
                            return "Draw";
                        break;
                        case(2):
                            return "You lose";
                        break;
                        default:
                            return "Error";
                        break;
                    }
                break;
                case (2): 
                    switch(n)
                    {
                        case(0):
                            return "You lose";
                        break;
                        case(1):
                            return "You win";
                        break;
                        case(2):
                            return "Draw";
                        break;
                        default:
                            return "Error";
                        break;
                    }
                break;
                default:
                    return("Error");
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
