public class Solution {

    public string Encode(IList<string> strs) {
        if(strs.Count() == 0)
            return null;
        StringBuilder sBuilder = new StringBuilder();
        for(int i = 0;i<strs.Count();i++)
        {
            if(i + 1 == strs.Count() ){
                sBuilder.Append(strs[i]);
                continue;
            }
            sBuilder.Append(strs[i]+ (char)327);
        }
        return sBuilder.ToString();
        
    }

    public List<string> Decode(string s) {
        Console.WriteLine(s);
        if(s == "")
            return new List<string>(){""};
        if(s == null)
            return new List<string>();
        Console.WriteLine((char)327);
        return s.Split((char)327).ToList();
   }
}
