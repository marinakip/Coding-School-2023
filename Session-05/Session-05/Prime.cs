internal class Prime
{
    public Prime()
    {
    }

    public void CalculateAllPrimes(int primesUpperBound){
        
        for (int i = 1; i <= primesUpperBound; i++){
            if (IsPrime(i)){
                Console.Write($"{i} ");
            }
        }
          
    }

    public bool IsPrime(int number)
    {
        if (number == 0 || number == 1) {
            return false;
        }

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0) {
                return false;
            }
        }
        return true;
    }
}