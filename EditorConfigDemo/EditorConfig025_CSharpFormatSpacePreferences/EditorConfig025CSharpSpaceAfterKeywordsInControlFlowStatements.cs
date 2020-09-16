using System;

namespace EditorConfigDemo.EditorConfig025_CSharpFormatSpacePreferences
{
    class EditorConfig025CSharpSpaceAfterKeywordsInControlFlowStatements
    {
        public void Test()
        {
            // csharp_space_after_keywords_in_control_flow_statements = true
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
