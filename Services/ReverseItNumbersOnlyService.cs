using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniChallengeFiveToSeven___Endpoints.Services
{
    public class ReverseItNumbersOnlyService
    {
        public string ReverseInteger(string userString){
            int lastDigit;
            int reverseNum=0;
            int number;
            bool userValidation = int.TryParse(userString, out number);

            if (!userValidation)
            {
                return "Invalid user input. try again.";
            }

            while (number > 0){
            lastDigit = number % 10;
            reverseNum = (reverseNum*10) + lastDigit;
            number = number/10;
            }

            return $"You had entered {userString} which is {reverseNum} when reversed";
        }
    }
}