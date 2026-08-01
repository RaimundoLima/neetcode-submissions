public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var result = new List<List<int>>();
        var hash = nums.ToHashSet();
        for(int i = 0;i<nums.Length-2;i++)
        {
            for(int j = i+1;j<nums.Length-1;j++)
            {    
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
            }
        }

        return result;
    }
}
