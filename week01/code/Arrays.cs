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

        // PLAN TO IMPLEMENT MultiplesOf FUNCTION:

        // 1. Define a method called MultiplesOf that takes two parameters:
        //    - A double called 'number' which is the starting number.
        //    - An int called 'length' which represents how many multiples to generate.
        // 2. Inside the method, create an array of type double with a length equal to 'length'.
        //    This array will store the resulting multiples.
        // 3. Use a for loop to generate each multiple:
        //    - Loop variable i should go from 0 to length - 1.
        //    - On each iteration, compute the multiple as: number * (i + 1).
        //      We use (i + 1) to avoid starting from zero.
        // 4. Store each calculated multiple into the array at index i.
        // 5. After the loop ends, return the array containing all the multiples.

        double[] results = new double[length];

        for (int i = 0; i < length; i++)
        {
            results[i] = number * (i + 1);
        }

        return results; // replace this return statement with your own
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


        // PLAN TO IMPLEMENT RotateListRight FUNCTION:

        // 1. Define a method called RotateListRight that takes two parameters:
        //    - A List of integers called 'data'.
        //    - An integer called 'amount' which specifies how many positions to rotate to the right.
        // 2. Understand that rotating right by N means taking the last N elements and moving them to the front of the list,
        //    while keeping the order of the remaining elements.
        // 3. To do this:
        //    - First, calculate the starting index of the "right-rotated" part, which is data.Count - amount.
        //    - Use List.GetRange(start, count) to extract:
        //        a) The last 'amount' elements (from index data.Count - amount to end).
        //        b) The first remaining elements (from index 0 to data.Count - amount).
        // 4. Create a new list by combining the two parts:
        //    - First the last part (rotated portion),
        //    - Then the beginning part (original front part).
        // 5. Return or overwrite the original list with the newly rotated list.
        // Get the last 'amount' elements

        // Step 1: Get the last 'amount' elements (the part to rotate to the front)
        List<int> rightPart = data.GetRange(data.Count - amount, amount);

        // Step 2: Get the remaining elements (the part to go after the rotated part)
        List<int> leftPart = data.GetRange(0, data.Count - amount);

        // Step 3: Clear the original list
        data.Clear();

        // Step 4: Add the rotated parts back in the new order
        data.AddRange(rightPart);
        data.AddRange(leftPart);

    }
}
