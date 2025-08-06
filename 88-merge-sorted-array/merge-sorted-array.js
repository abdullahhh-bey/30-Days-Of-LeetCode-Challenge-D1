/**
 * @param {number[]} nums1
 * @param {number} m
 * @param {number[]} nums2
 * @param {number} n
 * @return {void} Do not return anything, modify nums1 in-place instead.
 */
var merge = function(nums1, m, nums2, n) {
     let num = new Array(m + n);

        // it will be used to iterate nums1
        let i = nums1.length - n - 1; // 2
        // It will be used to iterate nums2
        let j = n - 1;
        // used to iterate new array -> num
        let k = m + n - 1;

        // Compare and add the array
        while (i >= 0 && j >= 0) {
            if (nums1[i] >= nums2[j]) {
                num[k] = nums1[i];
                k--;
                i--;
            } else {
                num[k] = nums2[j];
                k--;
                j--;
            }
        }

        // these two while loops check for the array that is not ended and it will
        // find it and copy the remaining elements to the New array
        while (i > j) {
            num[k] = nums1[i];
            k--;
            i--;
        }

        while (j > i) {
            num[k] = nums2[j];
            k--;
            j--;
        }

        // Putting every new changes and new array to the already exists nums1 because 
        // it was a condition 
        for (let z = 0; z < num.length; z++) {
            nums1[z] = num[z];
        }

};