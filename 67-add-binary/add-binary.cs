public class Solution {
    public string AddBinary(string a, string b) {
        //Logic is simple
        //first convert binary to decimal
        //and then sum the both decimal and then after
        //the sum. convert it back to binary string and return

        // var n1 = Convert.ToInt32(a , 2);
        // var n2 = Convert.ToInt32(b , 2);

        // var sum = n1+n2;

        // string ans = Convert.ToString(sum , 2);
        // return ans;

        int i = a.Length - 1;  
        int j = b.Length - 1;   
        int carry = 0;
        var result = new System.Text.StringBuilder();

        // Process both strings from right to left
        while (i >= 0 || j >= 0 || carry > 0) {
            int sum = carry;  

            if (i >= 0) {
                sum += a[i] - '0';  
                i--;
            }
            if (j >= 0) {
                sum += b[j] - '0';
                j--;
            }

            // Append the current bit (sum % 2)
            result.Insert(0, (sum % 2).ToString());

            // Update carry (sum / 2)
            carry = sum / 2;
        }

        return result.ToString();

    }
}