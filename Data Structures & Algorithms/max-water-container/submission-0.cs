public class Solution {
    public int MaxArea(int[] heights) {
        var result =0;
        var bar1=0;
        var bar2=heights.Length-1;
        while(bar1 != bar2)
        {
            int lowerBar =(heights[bar1]<heights[bar2])?heights[bar1]:heights[bar2];
            int actualValue = (bar2-bar1)*lowerBar;
            if(actualValue>result)
                result = actualValue;

            if(lowerBar==heights[bar1])
            {
                bar1++;
                continue;
            }
            bar2--;

        }
        return result;
        
    }
}
