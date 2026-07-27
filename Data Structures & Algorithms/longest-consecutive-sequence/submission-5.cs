public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Count() == 0)
        {
            return 0;
        }
        var hashSet = nums.ToHashSet();
        int lastNumber = nums[0];
        int bigSequence = 1;
        int currentSequence = 1;
        
        for(int i=0;i<nums.Count();i++)
        {
            lastNumber = nums[i];
            for(int j =i;j<nums.Count();j++){

                if(hashSet.Contains(lastNumber+1))
                {
                    lastNumber = lastNumber + 1;
                    currentSequence++;
                    if(currentSequence > bigSequence)
                    {
                        bigSequence = currentSequence;
                    }
                    j--;
                    continue;
                } 
                currentSequence = 1;
                break;

            }

        }

        return bigSequence;
    }
}
