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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        double[] list = new double[length];
        double multipleCount = number;
        for (int i = 0; i < length; i++)
        {
            list[i] = multipleCount;
            multipleCount += number;
        }

        return list; // replace this return statement with your own

        //I decided to create a new array of doubles with the size of length.
        //Then I created a variable to keep track of the current multiple of the number.
        // I used a for loop to iterate through the array
        // and add the current multiple to the array at the current index.
        //Then I incremented the multiple variable by the original number
        //At the final step, I returned the array. 
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        List<int> newList = new List<int>(data.Count);
        int index = data.Count - amount;
        for (int j = index; j < data.Count; j++)
        {
            newList.Add(data[j]);
        }
        for (int k = 0; k < index; k++)
        {
            newList.Add(data[k]);
        }
        data.Clear();
        data.AddRange(newList);
    }
    //I created a new list to hold the rotated values.
    //I calculated the starting index for the rotation by subtracting the amount from the count of the data list.
    //I used a for loop to add the elements from the calculated index to the end of the data list to the new list.
    //Then I used another for loop to add the elements from the start of the data list to the calculated index to the new list.
    //Finally, I cleared the original data list and added the elements from the new list back into the data list.
}
