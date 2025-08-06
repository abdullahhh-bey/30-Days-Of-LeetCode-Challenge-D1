class Solution {
public:
    vector<int> intersection(vector<int>& nums1, vector<int>& nums2) {
        //Converting the Arrays into Vectors
        // In C++, if nums1 and nums2 are already vector, we can use them directly.
        vector<int> n1 = nums1; 
        vector<int> n2 = nums2; 

        //It will store the result
        vector<int> result; 

        //Main logic is that i will go to each element of list1/array1
        //and check if it is present in list2/array2, it yes then i will check that 
        //if it is present in resultList, if yes then skip and if not then add it to result
        for(int i = 0 ; i < n1.size() ; i++) 
        {           
            if(find(n2.begin(), n2.end(), n1[i]) != n2.end() &&
            find(result.begin(), result.end(), n1[i]) == result.end()) 
            {
                result.push_back(n1[i]); 
            }
        }

        //Converting the List into Aarray
        return result;
    }
};