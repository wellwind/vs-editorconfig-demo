using System;

namespace EditorConfigDemo.EditorConfig026_CSharpFormatWrappingPreferences
{
    class EditorConfigCSharpPreserveSingleLineStatements
    {
        public void TesT()
        {
            // csharp_preserve_single_line_statements = true
            // 這條不會自動 format，建議寫法為 int i = 0; string name = "John";
            // 但設成 false 會自動 format
            int i = 0;
            string name = "John";

            Console.WriteLine(i);
            Console.WriteLine(name);
        }

    }
}
