using System;

namespace EditorConfigDemo.EditorConfig025_CSharpFormatSpacePreferences
{
    class EditorConfig025CSharpSpaceBetweenMethodCallParameterListParentheses
    {
        // csharp_space_between_method_call_parameter_list_parentheses = false
        public void Test()
        {
            Test2( "Mike" );
        }

        public void Test2(string name)
        {
            Console.WriteLine( name );
        }
    }
}
