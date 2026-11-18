

namespace api.Services
{
    public class ChallengeServices : IChallengeServices
    {
        public string Greeting(string name)
        {
            return "Hello " + name; 
        }
    }
}