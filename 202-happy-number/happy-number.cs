public class Solution {
    public bool IsHappy(int n) {
        //Made a hashset to keep trach of the elements
        //if any element repeats in the hashset, then
        //the cycle exixts
        HashSet<int> numberSet = new HashSet<int>();

        while (n != 1 && !numberSet.Contains(n))
        {
            numberSet.Add(n);
            n = GetSumOfSquares(n);
        }

        return n == 1;
    }

    private int GetSumOfSquares(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            int digit = num % 10;
            sum += digit * digit;
            num /= 10;
        }
        return sum;
    }

}