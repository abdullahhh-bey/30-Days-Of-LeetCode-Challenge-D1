public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {

        //took a count var to count the non adjancent zeros
        int count = 0;

        //Logic is to count the number of indexes where the non adjancency exists
        //Leave the 1's and check if zero, if yes then check if that index+1 aldso 
        //contains zero?, If yes then do count++

        for(int i = 0 ; i < flowerbed.Length ; i++)
        {
            if(flowerbed[i] == 0)
            {

                    //It will check the left neightbour
                    bool right = ((i == flowerbed.Length - 1) || (flowerbed[i + 1] == 0));
                    //it will check the right neighbour 
                    bool left = ((i == 0) || (flowerbed[i-1] == 0) );                    
                    //If both conditions gets true, it means its non adjancent and COunt+++
                    
                    if(left && right)
                    {
                        count++;
                        i++;
                    }

            }
        }

        if(n <= count)
        {
            return true;
        } else{
            return false;
        }

    }
}