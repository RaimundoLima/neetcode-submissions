public class Solution {
    public bool IsAnagram(string s, string t) {

        return new string(s.Order().ToArray()).Equals(new string(t.Order().ToArray()));

    }
}
