using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Services
{
    public class EightServices : IEightServices
    {
        public string RandomAns()
        {
             Random rnd = new Random();
            int randomNum = rnd.Next(1, 11);
            string answer = ""; 
              switch(randomNum){
         case 1: 
        answer = "Definite yes ";
         break; 
         case 2: 
         answer = "Definite no ";
         break; 
         case 3: 
         answer = "I wouldnt count on it ";
         break; 
         case 4: 
         answer = "Go for it";
         break;
         case 5: 
         answer = "I'd probably avoid that";
         break;
         case 6: 
        answer = "Your outcome is favorable ";
         break; 
         case 7: 
         answer = "Try asking again later ";
         break; 
         case 8: 
         answer = "Couldn't tell you";
         break; 
         default: 
        answer = "The outcome is not favorable";
         break; 

        }//end of switch

        return answer; 
        }
    }
}