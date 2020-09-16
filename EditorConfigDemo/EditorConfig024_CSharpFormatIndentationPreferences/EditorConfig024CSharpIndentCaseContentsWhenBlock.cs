using System;

namespace EditorConfigDemo.EditorConfig024_CSharpFormatIndentationPreferences
{
    class EditorConfig024CSharpIndentCaseContentsWhenBlock
    {
        public void Test()
        {
            var c = 1;
            // csharp_indent_case_contents_when_block = true
            switch (c)
            {
                case 1:
                {
                    Console.WriteLine("The color is red");
                    break;
                }
            }
        }
    }
}
