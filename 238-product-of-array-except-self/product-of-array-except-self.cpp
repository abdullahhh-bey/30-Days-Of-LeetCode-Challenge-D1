class Solution {
public:
    vector<int> productExceptSelf(vector<int>& nums) {

        //I used c++ just because it was very time efficient ( run the program in 0ms )
        vector<int> result(nums.size());

        //Using common approach - first find prefix & add it to result array and then find the suffix
        //and multity it to the prefix of ith item
        //it would be like
        //result[ith] = prodiuct of left items of result[i] * product of right items of result[i]

        //Assume first index a 1
        result[0] = 1;
        for(int i = 1; i < nums.size(); i++)
        {
            result[i] = result[i - 1] * nums[i - 1];
        }

        //Assuming Suffix as 1 
        int suffix = 1;
        for(int j = nums.size() - 1; j >= 0; j--)
        {
            result[j] = result[j] * suffix;
            suffix *= nums[j];
        }

        //Return the Updated Array
        return result;
        
        }
};