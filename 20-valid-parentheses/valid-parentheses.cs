public class Solution {
    public bool IsValid(string s) {
        //Using stack to solve this
        //CHECK 1 - check openeing bracket for every closing bracket
        //CHECK 2 - order should be maintained
        
        // Use a stack to store the opening brackets encountered.
        Stack<char> stack = new Stack<char>();

        // Loop through each character in the input string.
        foreach (char c in s)
        {
            // If the character is an opening bracket, push it onto the stack.
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            // If the character is a closing bracket, we need to check for a match.
            else if (c == ')' || c == '}' || c == ']')
            {
                // If the stack is empty, it means we have a closing bracket
                // without a corresponding opening one. The string is invalid.
                if (stack.Count == 0)
                {
                    return false;
                }

                // Pop the top element from the stack. This should be the
                // last opening bracket we encountered.
                char openBracket = stack.Pop();

                // Check for a mismatch.
                if (c == ')' && openBracket != '(')
                {
                    return false;
                }
                if (c == '}' && openBracket != '{')
                {
                    return false;
                }
                if (c == ']' && openBracket != '[')
                {
                    return false;
                }
            }
        }

        if(stack.Count == 0)
        {
            return true;
        }

        return false;

    }
}