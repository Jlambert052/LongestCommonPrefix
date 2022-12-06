namespace Prefix {
    public class LCP {
        public string LongestCommonPrefix(string[] strs) {
            string str = strs[0];
            int i = str.Length;
            foreach(string s in strs) {
                int j = 0;
                while(j < str.Length && j < s.Length && str[j] == s[j])
                j++;
                i = Math.Min(i, j);

            }
            System.Console.WriteLine($"The longest common prefix is {strs[0].Substring(0, i)}");
            return strs[0].Substring(0, i);
        }
    }
}