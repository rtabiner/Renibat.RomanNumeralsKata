
namespace Renibat.RomanNumeralsKata.Services
{
    public class RomanNumeralGenerator
    {
        public string Generate(int number)
        {
            var result = "";

            var numbers = new[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            var numerals = new[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            for (int i = 0; i < numbers.Length; i++)
            {
                while (number >= numbers[i] && number > 0)
                {
                    result += numerals[i];

                    number -= numbers[i];
                }
            }

            return result;
        }
    }
}
