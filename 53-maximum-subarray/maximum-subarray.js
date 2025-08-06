/**
 * @param {number[]} nums
 * @return {number}
 */
var maxSubArray = function(nums) {
    // Approach is very simple
    // Variable to store the sum of two or more numbers
    let sum = 0;
    // It will store the max sum
    let maxSum = 0;

    // Used for validation
    let neg = false;
    let max = -1000000;

    // Validation method, this is for the arrays that have only negative numbers
    for (let i = 0; i < nums.length; i++) {
        if (nums[i] < 0) {
            max = Math.max(max, nums[i]);
        } else {
            neg = true;
        }
    }

    if (neg === false) {
        return max;
    }

    // Main Logic starts from here
    // Check for each item, add it to sum, check if the sum is greater than zero, if yes then compare
    // Compare it to the previous maximum value
    // If sum is smaller than zero or equal to zero, reset the sum because it is not necessary
    for (let i = 0; i < nums.length; i++) {
        sum += nums[i];
        if (sum > 0) {
            maxSum = Math.max(maxSum, sum);
        } else {
            sum = 0;
        }
    }

    return maxSum;
};