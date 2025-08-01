using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public bool ContainsDuplicate(int[] nums) {        
        bool found = false;
         // Constraints
        int sizeMin = 1;
        int sizeMax = 100000;
        int valueMin = -1000000000;
        int valueMax = 1000000000;

        // Validation for array length and null
        if (nums == null || nums.Length < sizeMin || nums.Length > sizeMax) {
            return false;
        }

        // Validation for values within the array
        foreach (int number in nums) {
            if (number < valueMin || number > valueMax) {
                return false;
            }
        }

        //Validation Ends

    
        // //If the Array is valid, then it starts from here     
        // for(int i = 0 ; i < nums.Length ; i++)
        // {
        //     for (int j = 0 ; j < nums.Length ; j++)
        //     {
        //         if( nums[i] == nums[j] && i != j )
        //         {
        //             found = true;
        //             return found;
        //         } 
        //     }
        // }

        List<int> seen = new List<int>();

        // Loop through the array
        foreach (int num in nums) {
            // If number already exists in HashSet, it's a duplicate
            if (seen.Contains(num)) {
                return true;
            }
            // Add number to HashSet
            seen.Add(num);
        }
        
        return found;   
        
        
    }
}