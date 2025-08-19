public class Solution {
    public int MaxArea(int[] height) {
       //Main logic is to Use Two Pointer Approach
       int lp = 0; //It will follow the left side
       int rp = height.Length - 1; //It will follow the right side
       int minHeight = 0;
       int width = 0;
       int area;
        int maxArea = 0;

       while(lp < rp)
       {
        //Took width
           width = rp - lp;
        //took min height that controls 
           minHeight = Math.Min(height[lp], height[rp]);

           //Finding area
           area = width * minHeight;

           //Compare the Area
           maxArea = Math.Max(maxArea , area);
            if(height[lp] < height[rp])
            {
                lp++;
            } else{
                rp--;
            }
       }
       
       return maxArea;

    }
}