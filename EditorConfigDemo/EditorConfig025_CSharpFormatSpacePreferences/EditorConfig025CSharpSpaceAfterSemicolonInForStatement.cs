using System;

namespace EditorConfigDemo.EditorConfig025_CSharpFormatSpacePreferences
{
    class EditorConfig025CSharpSpaceAfterSemicolonInForStatement
    {
        public void Test()
        {
            // csharp_space_after_semicolon_in_for_statement = true
            for (int i = 0;i < 10;i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
