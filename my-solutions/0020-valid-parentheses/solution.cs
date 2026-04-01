public class Solution {
    public bool IsValid(string s) {
        Stack<char> stackSteps = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '[' || s[i] == '{')
            {
                stackSteps.Push(s[i]);
            }
            else if (s[i] == ')' || s[i] == ']' || s[i] == '}')
            {
                if (stackSteps.Count == 0)
                {
                    return false;
                }
                else
                {
                    char result = stackSteps.Pop();
                    if (s[i] == ')' && result != '(') return false;
                    if (s[i] == ']' && result != '[') return false;
                    if (s[i] == '}' && result != '{') return false;
                }
            }
        }

        if (stackSteps.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}
