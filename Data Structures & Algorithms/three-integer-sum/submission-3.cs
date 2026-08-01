public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var result = new List<List<int>>();
        
        
        for(int i = 0;i<nums.Length-2;i++)
        {
            for(int j = i+1;j<nums.Length-1;j++)
            {
                var nums2 = nums.ToList();
                var sum = nums[i]+ nums[j];
                nums2.Remove(nums[i]);
                nums2.Remove(nums[j]);
                var hash = nums2.ToHashSet();
                if(hash.Contains(-sum))
                {
                    var sumToAdd =  new List<int>{nums[i],nums[j],-sum};
                    sumToAdd.Sort();
                    if(result.Where(x=>x.SequenceEqual(sumToAdd)).Count()==0){
                        result.Add(sumToAdd);
                    }
                }
                /*  
                for(int k = j+1;k<nums.Length;k++)
                {
                    var sum = nums[i]+ nums[j]+nums[k];
                    if(sum == 0)
                    {
                        var sumToAdd =  new List<int>{nums[i],nums[j],nums[k]};
                        sumToAdd.Sort();
                        if(result.Where(x=>x.SequenceEqual(sumToAdd)).Count()==0){
                            result.Add(sumToAdd);
                        }
                    }
                }
                */
            }
        }

        return result;
    }
}
