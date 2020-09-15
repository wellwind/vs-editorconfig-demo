using System;

namespace EditorConfigDemo.EditorConfig023_CSharpFormatNewLinePreferences
{
    public class EditorConfig023CSharpNewLineBeforeCatch
    {
        public void Test()
        {
            // csharp_new_line_before_catch = true
            try
            {
                Console.WriteLine("Hello");
            } catch {
                Console.WriteLine("World");
            }
        }
    }
}
