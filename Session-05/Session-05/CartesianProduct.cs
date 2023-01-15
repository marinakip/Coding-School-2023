internal class CartesianProduct
{
    private int[] array1 = new int[] { 2, 4, 9, 12 };
    private int[] array2 = new int[] { 1, 3, 7, 10 };
    public CartesianProduct() {}

    private int[] CalculateCartesianProduct()
    {
        int[] cartesianProductArray = new int[16];
        int k = 0;
        for (int i = 0; i < array1.Length; i++){
            for (int j = 0; j < array2.Length; j++){
                cartesianProductArray[k] = array1[i] * array2[j];   
                k++;    
            }
        }
        return cartesianProductArray;

    }
    private void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} \t" );
        }
    }
    public void printCartesianProduct()
    {
        int[] cartesianArray = CalculateCartesianProduct();
        PrintArray(cartesianArray); 
        
    }
    
    public void printArray1()
    {
        PrintArray(array1); 
    }

    public void printArray2()
    {
        PrintArray(array2);
    }

}