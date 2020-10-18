using System.Security.Cryptography;
using System;
using RandomNumberGenerator;

namespace RockScissorsPaperLib
{
    public class WinnerChecker
    {
        string Game(string obj)
        {
            Random rnd = new Random();
            //1 - бумага, 2 - ножницы, 3 - камень
            var n = rnd.Next(1, 4);
            if (obj == "камень"){
                if (n == 1){
                    return "You lose";
                }
                else if (n == 2){
                    return "You win";
                }
                else{
                    return "Draw";
                }
            }
        }
    }
}
