public class Solution
{
    public bool IsValid(string s)
    {
        if (string.IsNullOrEmpty(s)) return true;

        var stack = new Stack<char>();

        foreach (var c in s)
        {
            if (c == '(') stack.Push(c);
            else if (c == '[') stack.Push(c);
            else if (c == '{') stack.Push(c);
            else if (c == ')' && stack.Count > 0 && stack.Pop() == '(')
                continue;
            else if (c == ']' && stack.Count > 0 && stack.Pop() == '[')
                continue;
            else if (c == '}' && stack.Count > 0 && stack.Pop() == '{')
                continue;
            else
                return false;

        }
        if (stack.Count > 0)
            return false;
        return true;
    }
}


public class Solution
{
    public bool IsValid(string s)
    {
        if (string.IsNullOrEmpty(s)) return true;

        var stack = new Stack<char>();

        foreach (var c in s)
        {
            switch (c)
            {
                case '(': stack.Push(')'); break;
                case '[': stack.Push(']'); break;
                case '{': stack.Push('}'); break;
                case ')':
                case ']':
                case '}':
                    if (stack.Count == 0) return false;
                    if (stack.Pop() != c) return false;
                    break;
                default:
                    return false;
            }
        }
        return stack.Count == 0;
    }
}