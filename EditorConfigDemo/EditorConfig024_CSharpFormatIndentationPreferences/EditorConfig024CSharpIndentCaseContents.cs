using System;

namespace EditorConfigDemo.EditorConfig024_CSharpFormatIndentationPreferences
{
    class EditorConfig024CSharpIndentCaseContents
    {
        public void Test()
        {
            var c = 1;
            // csharp_indent_case_contents = true
            switch (c)
            {
                case 1:
                Console.WriteLine("The color is red");
                break;
                case 2:
                Console.WriteLine("The color is blue");
                break;
                default:
                Console.WriteLine("The color is unknown.");
                break;
            }
        }
    }
}
