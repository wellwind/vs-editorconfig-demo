using System;

namespace EditorConfigDemo.EditorConfig024_CSharpFormatIndentationPreferences
{
    class EditorConfig024CSharpIndentSwitchLabels
    {
        public void Test()
        {
            var c = 1;
            // csharp_indent_switch_labels = true
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
