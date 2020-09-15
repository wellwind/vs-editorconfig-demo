using System;

namespace EditorConfigDemo.EditorConfig023_CSharpFormatNewLinePreferences
{
    public class EditorConfig023CSharpNewLineBeforeFinally
    {
        public void Test()
        {
            // csharp_new_line_before_catch = true
            try
            {
                Console.WriteLine("Hello");
            } catch {
                Console.WriteLine("World");
            } finally {
                Console.WriteLine("Test");
            }
        }
    }
}
