
internal class Product
{
    /// <summary>
    /// It calculates product of N numbers, the factorial n!
    /// </summary>
    public int CalculateProduct(int n) {
        int factorial = 1;
        for (int i = 1; i <= n; i++) {
            factorial *= i;
        }
        return factorial;
    }
}