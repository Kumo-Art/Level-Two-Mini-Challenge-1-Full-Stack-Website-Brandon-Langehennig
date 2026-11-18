
namespace api.Services
{
    public class SumServices : ISumServices
    {
        public int Addition(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }
    }
}