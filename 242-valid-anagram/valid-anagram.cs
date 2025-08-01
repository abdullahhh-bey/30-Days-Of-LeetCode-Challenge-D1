public class Solution {
    public bool IsAnagram(string s, string t) {
        List<char> s1 = s.ToList();
        List<char> t1 = t.ToList();
        s1.Sort();
        t1.Sort();

        if(s1.Count != t1.Count)
        {
            return false;
        } else{
            for(int i = 0; i < s1.Count ; i++)
            {
                if(s1[i] != t1[i])
                {
                    return false;
                }
            }

            return true;
        }

    }
}