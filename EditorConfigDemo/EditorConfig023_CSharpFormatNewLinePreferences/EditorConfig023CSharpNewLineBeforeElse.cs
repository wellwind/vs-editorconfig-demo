using System;

namespace EditorConfigDemo.EditorConfig023_CSharpFormatNewLinePreferences
{
    class EditorConfig023CSharpNewLineBeforeElse
    {
        public void Test()
        {
            // csharp_new_line_before_else = true
            var r = new Random().Next(1, 100);
            if (r >= 50)
            {
                Console.WriteLine("Hello");
            } else {
                Console.WriteLine("World");
            }
        }
    }
}
