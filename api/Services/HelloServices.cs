
namespace api.Services
{
    public class HelloServices : IHelloServices
    {
        public string Greeting(string name)
        {
            return $"Hello {name}!";
        }
    }
}