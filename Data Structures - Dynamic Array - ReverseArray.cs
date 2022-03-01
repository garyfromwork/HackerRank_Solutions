class Result
{

    /*
     * Complete the 'reverseArray' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static List<int> reverseArray(List<int> a)
    {
        List<int> returnedArray = new List<int>();
        for (int i = a.Count-1; i >= 0; i--) {
            returnedArray.Add(a[i]);
        }
        return returnedArray;
    }

}