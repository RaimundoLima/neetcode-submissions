public class Solution {
    public string MinWindow(string s, string t) {
        string result = "";
        Dictionary<char,int> tMap = new Dictionary<char,int>();
        int first = 0;
        int last = t.Length-1;
        
        if(s.Length<t.Length)
            return result;

        for(int i=0;i<t.Length;i++)
        {
            if(tMap.ContainsKey(t[i]))
            {
               tMap[t[i]]++;
               continue; 
            }
            tMap[t[i]] = 1;
        }
        while(last<s.Length+1)
        {
            Console.WriteLine("While");

            if(!tMap.ContainsKey(s[first]))
            {
                first++;
                last++;
                if(first>=s.Length)
                    break;
                continue;
            }

            string sub = s.Substring(first,last-first);

            var aux = new Dictionary<char,int>(tMap);
            for(int i=0;i<sub.Length;i++)
            {
                if(aux.ContainsKey(sub[i]))
                    aux[sub[i]]-=1;
            }
            if(aux.Values.Max() == 0)
            {
                
                if(result == "")
                {
                    result=sub;
                }
                if(result.Length > sub.Length)
                {
                    result = sub;
                }

                first++;
                last = first+t.Length;

                continue;
            }
            last++;

        }
        


        return result;
    }
}
