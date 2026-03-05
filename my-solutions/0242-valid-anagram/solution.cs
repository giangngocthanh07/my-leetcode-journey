public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }

        int[] ConstArray = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            int n = s[i] - 'a';
            ConstArray[n]++;
        }

        for (int j = 0; j < t.Length; j++)
        {
            int m = t[j] - 'a';
            ConstArray[m]--;
        }

        for (int k = 0; k < ConstArray.Length; k++)
        {
            if (ConstArray[k] != 0)
            {
                return false;
            }
        }
        return true;
    }
}
