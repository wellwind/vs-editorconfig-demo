using System;

namespace EditorConfigDemo.EditorConfig014_CSharpStylePatternMatching
{
    class EditorConfig014CSharpStylePatternMatching
    {
        public void Test()
        {
            var o = 1;
            // csharp_style_pattern_matching_over_is_with_cast_check = true
            // 建議改為 if (o is int i) { }
            if (o is int) { int i = (int)o; }
        }

        public void Test2()
        {
            var o = "1";
            // csharp_style_pattern_matching_over_as_with_null_check = true
            // 建議改為 if (o is string s) { }
            var s = o as string;
            if (s != null)
            {
                Console.WriteLine(s);
            }
        }
    }
}
