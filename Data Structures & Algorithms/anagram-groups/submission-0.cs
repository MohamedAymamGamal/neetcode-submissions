public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
       Dictionary<string, List<string>> map = new();

foreach (string str in strs)
{
    char[] charArray = str.ToCharArray();
    Array.Sort(charArray);
    string key = new string(charArray);

    if (!map.ContainsKey(key))
    {
        map[key] = new List<string>();
    }

    map[key].Add(str);
}

return new List<List<string>>(map.Values); 
    }
}
