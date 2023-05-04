using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NibbleTools.ViewModels;

public partial class PrimeNumberGeneratorViewModel : ObservableRecipient
{
    [ObservableProperty] private int _count = 1;

    [ObservableProperty] private int _length = 1;

    [ObservableProperty] private string _number = string.Empty;

    [RelayCommand]
    public void ButtonClick()
    {
        Number = string.Join(" ", GenerateRandomPrimes(Count, Length));
    }

    private static readonly Random random = new Random();

    public static List<int> GenerateRandomPrimes(int count, int length)
    {
        List<int> primes = new List<int>();

        while (primes.Count < count)
        {
            int number = GenerateRandomNumber(length);
            if (IsPrime(number))
            {
                primes.Add(number);
            }
        }

        return primes;
    }

    public static int GenerateRandomNumber(int length)
    {
        int min = (int)Math.Pow(10, length - 1);
        int max = (int)Math.Pow(10, length) - 1;
        return random.Next(min, max);
    }

    public static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }
        if (number == 2 || number == 3)
        {
            return true;
        }
        if (number % 2 == 0 || number % 3 == 0)
        {
            return false;
        }
        int i = 5;
        while (i * i <= number)
        {
            if (number % i == 0 || number % (i + 2) == 0)
            {
                return false;
            }
            i += 6;
        }
        return true;
    }
}