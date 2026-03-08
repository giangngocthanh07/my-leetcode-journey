public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();

        for (int index = 0; index < strs.Length; index++)
        {
            int[] Map = new int[26];

            string key = string.Empty;

            for (int i = 0; i < strs[index].Length; i++)
            {
                Map[strs[index][i] - 'a']++;
            }

            for (int m = 0; m < Map.Length; m++)
            {
                key += Map[m] + "#";
            }

            if (groups.ContainsKey(key))
            {
                groups[key].Add(strs[index]);
            }
            else
            {
                groups.Add(key, new List<string> { strs[index] });
            }
        }

        IList<IList<string>> results = new List<IList<string>>();

        foreach (var group in groups.Values)
        {
            results.Add(group);
        }        
        return results;
    }
}
