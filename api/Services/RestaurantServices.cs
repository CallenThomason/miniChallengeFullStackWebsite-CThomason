using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Services
{
    public class RestaurantServices : IRestaurantServices
    {
        public String ResAns(string choice)
        {
             string[] food = new string[10];
       
       
        switch (choice)
        {
           
            case "mexican":
             food = ["Chipotle", "TacoBell", "Del Taco", "Casa Bonita", "Tacqueria San Jose", "Dons", "Tacqueria de Ripon", "QDOBA", "Jalepenos", "My Grandmas House"]; 
        
            break; 
            case "burger":
            food = ["McDonalds", "In-N-Out", "Jack in the Box", "Carl's Jr", "Brothers", "Fast Eddies", "Sno-Whites", "Wendys", "Nations", "My back yard"]; 
            
            break; 
            case "chinese":
            food = ["Panda Express", "P.F. Chang's", "Pei Wei", "Din Tai", "Jade Garden", "Golden Dragon", "House of Nanking", "Mission Chinese Food", "Yang Chow", "China Garden"]; 
          
            break;
           
        } 
         Random rnd = new Random(); 
        int randomNum = rnd.Next(0, 10); 
        string res = food[randomNum];

        return res; 
        }
    }
}