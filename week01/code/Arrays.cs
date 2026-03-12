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
        // Plan:
        // 1. Create a new array with size equal to 'length'
        // 2. Loop through the array from index 0 to length-1
        // 3. For each position i, calculate the multiple: number * (i + 1)
        //    - When i=0, we get number * 1 = the starting number
        //    - When i=1, we get number * 2 = first multiple
        //    - And so on...
        // 4. Store each multiple in the array at position i
        // 5. Return the completed array

        double[] multiples = new double[length];
        
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }
        
        return multiples;
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
        // Plan:
        // 1. Calculate the effective rotation amount using modulo to handle cases 
        //    where amount might be larger than the list size
        //    - Example: if list has 9 elements and amount is 3, we rotate by 3
        //    - Example: if list has 9 elements and amount is 12, that's the same as rotating by 3 (12 % 9 = 3)
        // 2. Use the GetRange() method to slice the list into two parts:
        //    - Last 'amount' elements (the part that moves to the front)
        //    - First (length - amount) elements (the part that moves to the back)
        // 3. Use RemoveRange() to remove the last 'amount' elements from the list
        // 4. Use InsertRange() to add those removed elements to the beginning of the list
        // 5. The list is modified in-place, so no return is needed

        // Calculate the effective rotation amount
        amount = amount % data.Count;
        
        // Get the last 'amount' elements
        List<int> lastElements = data.GetRange(data.Count - amount, amount);
        
        // Remove the last 'amount' elements from the list
        data.RemoveRange(data.Count - amount, amount);
        
        // Insert the removed elements at the beginning
        data.InsertRange(0, lastElements);
    }
}