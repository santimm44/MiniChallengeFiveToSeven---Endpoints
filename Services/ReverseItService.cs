using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniChallengeFiveToSeven___Endpoints.Services
{
    public class ReverseItService
    {
        public string ReverseString(string userString){
            int arraySize = userString.Length;
            char[] reverseString = new char[arraySize];

            int j = 0;
            for (int i = arraySize-1; i >= 0; i--){
                reverseString[j] = userString[i];
                j++;
            }
             
            string reverseStringValue = string.Join("", reverseString);
            return $"You had entered {userString} which is {reverseStringValue} when reversed";

        }
    }
}