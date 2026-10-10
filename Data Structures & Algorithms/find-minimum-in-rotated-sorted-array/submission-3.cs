public class Solution {
    public int FindMin(int[] nums) {
        int minNumber = nums[0];
        int left = 0;
        int right = nums.Length-1;
        int count=0;
        while(count<nums.Length)
        {
            
            var center = (left + right)/2;
            var actualNumber =nums[center];
            if(actualNumber<minNumber)
            {
                minNumber=actualNumber;
                if(right == center)
                    break;
                right=center;
            }
            else
            {
                if(left == center)
                    break;
                left=center;
            }
            count++;
        }
        if(nums[nums.Length-1]<minNumber)
            minNumber = nums[nums.Length-1];
        return minNumber;
    }
}
