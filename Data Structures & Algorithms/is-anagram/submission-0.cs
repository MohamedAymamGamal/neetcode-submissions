public class Solution {
    public bool IsAnagram(string s, string t) {
            
              if (s.Length != t.Length)
            return false;


        Dictionary<char, int> map = new();

        foreach (char c in s )
        {
            map[c] = map.GetValueOrDefault(c, 0) + 1;
        }

        foreach (char c in t)
        {
            if (!map.ContainsKey(c)) return false;
            
            map[c]--;

            if (map[c] == 0)
                map.Remove(c);

        }
    

        return map.Count == 0;


    }
}
