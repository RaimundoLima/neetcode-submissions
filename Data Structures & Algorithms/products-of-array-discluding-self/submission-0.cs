public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int totalValue = 1;
        var result = new int[nums.Count()];
        var count0 = 0;
        for(int i=0;i<nums.Count();i++)
        {
            if(nums[i]==0 && count0==0)
            {
                count0++;
                continue;
            }
            totalValue *= nums[i];
        }
        for(int i=0;i<nums.Count();i++)
        {
            if(count0 == 1 && nums[i] == 0){
                result[i] = totalValue;
                continue;
            }

            if(count0 > 1)
                result[i] = 0;
            if(count0 == 0)
                result[i]=totalValue/nums[i];
        }
        return result;
    }
}
