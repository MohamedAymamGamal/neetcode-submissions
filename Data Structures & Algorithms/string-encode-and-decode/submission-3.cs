public class Solution {

          public string Encode(IList<string> strs)
        {
            StringBuilder builder = new StringBuilder();

            foreach (string str in strs)
            {
                builder.Append(str.Length);
                builder.Append("#");
                builder.Append(str);
            }

            return builder.ToString();

        }

        public List<string> Decode(string s)
{
    List<string> listOfStrings = new List<string>();

    int i = 0;

    while (i < s.Length)
    {
        // Find '#'
        int delimiter = s.IndexOf('#', i);

        // Read the length
        int length = int.Parse(s.Substring(i, delimiter - i));

        // First character of the string
        int start = delimiter + 1;

        // Read exactly 'length' characters
        listOfStrings.Add(s.Substring(start, length));

        // Move to the next encoded string
        i = start + length;
    }

    return listOfStrings;


        }
}
