public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // My plan:
        // Need to create array of size 'length'
        // Loop from 0 to length-1, each position gets number * (position+1)
        // Because position 0 should be number*1, position 1 should be number*2, etc.
        
        double[] result = new double[length];
        
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        
        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // My plan:
        // Rotating right by 'amount' means taking the last 'amount' elements and moving them to the front
        // Steps:
        // 1. Find where the last 'amount' elements start: data.Count - amount
        // 2. Use GetRange to grab those elements
        // 3. Use RemoveRange to delete them from the end
        // 4. Use InsertRange to put them at the beginning
        
        int startIndex = data.Count - amount;
        List<int> elementsToMove = data.GetRange(startIndex, amount);
        data.RemoveRange(startIndex, amount);
        data.InsertRange(0, elementsToMove);
    }
}