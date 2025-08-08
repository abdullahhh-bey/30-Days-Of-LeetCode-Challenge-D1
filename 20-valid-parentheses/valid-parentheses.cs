public class Solution {
    public bool IsValid(string s) {
        //Using stack to solve this
        //CHECK 1 - check openeing bracket for every closing bracket
        //CHECK 2 - order should be maintained
        
        Stack<char> stack = new Stack<char>();

        for(int i = 0; i < s.Length ; i++)
        {
            char c = s[i];
            if(c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }else if( c == ')' || c == '}' || c == ']')
            {
                if(stack.Count == 0 )
                {   
                    return false;
                } 

                char bracket = stack.Pop();

                if( c == ')' && bracket != '(')
                {
                    return false;
                } else if( c == '}' && bracket != '{')
                {
                    return false;
                } else if (c == ']' && bracket != '['){
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