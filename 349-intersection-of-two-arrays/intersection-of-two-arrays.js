/**
 * @param {number[]} nums1
 * @param {number[]} nums2
 * @return {number[]}
 */
var intersection = function(nums1, nums2) {
    //Converting the Arrays into LIST
    // In js, arrays are already dynamic like Lists.
    let n1 = nums1; 
    let n2 = nums2; 

    //It will store the result
    let result = []; 

    //Main logic is that i will go to each element of list1/array1
    //and check if it is present in list2/array2, it yes then i will check that 
    //if it is present in resultList, if yes then skip and if not then add it to result
    for (let i = 0; i < n1.length; i++) { 
        if (n2.includes(n1[i]) && !result.includes(n1[i])) {
            result.push(n1[i]); 
        }
    }

    //Converting the List into Aarray
    // In JavaScript, the 'result' is already an array, so we can return it directly.
    return result;
};