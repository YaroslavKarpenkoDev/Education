using System.Text;

namespace Education;

public class PrimeFactors
{
    public string GetPrimeFactors(int number)
    {
        if (number < 4)
        { 
            return number.ToString();
        }

        var numbers = new StringBuilder();
        for (int i = 2; i < 10; i++)
        {
            var reminder = number % i;
            if (reminder == 0)
            {
                if (number / i != 1)
                {
                    numbers.Append($"{i}*");
                    number /= i;
                    i = 1;
                }
                else
                {
                    numbers.Append($"{i}");
                    return numbers.ToString();
                }
            }
        }
        return numbers.ToString();
    }
}