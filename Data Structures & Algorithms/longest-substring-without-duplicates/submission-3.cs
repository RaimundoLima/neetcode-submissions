public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int result = 0;

        int start=0;
        int end=1;
        if(s.Length == 0)
            return 0;

        while(end <= s.Length)
        {   
            var actualString = s.Substring(start,end-start);
            var hash = actualString.ToHashSet<char>();
            if(actualString.Length == hash.Count())
            {
                
                int actualValue = end - start;
                result = (actualValue>result)?actualValue:result;
                end++;
                continue;
            }
            start++;
            end++;
        }

        return result;

    }
}
