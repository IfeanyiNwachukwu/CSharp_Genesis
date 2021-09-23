using System.Diagnostics;

namespace ForCSharp.StringSlicing
{
    public static class substring
    {
       
        // CONTAINS
        public static bool ContainsString()
        {
            string example = "abc";
            if (example.Contains("bc"))
            {
                Debug.WriteLine("TRUE");
                return true;
            }
            return false;
        }

        public static string SliceString(string wordToSlice,int sliceOption)
        {
            var split = wordToSlice.Substring(sliceOption);
            return split;
        }
      
    }
}
