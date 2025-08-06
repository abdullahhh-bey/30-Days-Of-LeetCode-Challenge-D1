class Solution {
public:
    int maxSubArray(vector<int>& nums) {

        //It was almost the same and time efficient in c++, so i preferred c++ here
        // Approach is very simple
        // Variable to store the sum of two or more numbers
        int sum = 0;
        // It will store the max sum
        int maxSum = 0;

        // Used for validation
        bool neg = false;
        int max = -1000000;

        // Validation method, this is for the arrays that have only negative numbers
        for (int i = 0; i < nums.size(); i++) {
            if (nums[i] < 0) {

                max = std::max(max, nums[i]);
            } else {
                neg = true;
            }
        }

        if (neg == false) {
            return max;
        }

        // Main Logic starts from here
        // Check for each item, add it to sum, check if the sum is greater than zero, if yes then compare
        // Compare it to the previous maximum value
        // If sum is smaller than zero or equal to zero, reset the sum because it is not necessary
        for (int i = 0; i < nums.size(); i++) {
            sum += nums[i];
            if (sum > 0) {
                maxSum = std::max(maxSum, sum);
            } else {
                sum = 0;
            }
        }

        return maxSum;

    }
};