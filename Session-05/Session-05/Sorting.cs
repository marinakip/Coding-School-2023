internal class Sorting
{
    private int[] array = new int[] { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
    public Sorting()  {}

    internal int[] Sort()
    {
        int temp;
        for (int j = 0; j <= array.Length - 2; j++){
            for (int i = 0; i <= array.Length - 2; i++){
                if (array[i] > array[i + 1]){
                    temp = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = temp;
                }
            }   
        }
        return array;
    }

    public void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} \t");
        }
    }

    public void PrintSortedArray(){
        int[] sortedArray = Sort();
        PrintArray(sortedArray);
    }

    public void PrintArray1()
    {
        PrintArray(array);  
    }


}