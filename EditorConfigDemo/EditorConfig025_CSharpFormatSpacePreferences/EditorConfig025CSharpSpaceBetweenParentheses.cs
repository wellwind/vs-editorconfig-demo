namespace EditorConfigDemo.EditorConfig025_CSharpFormatSpacePreferences
{
    class EditorConfig025CSharpSpaceBetweenParentheses
    {
        public void Test()
        {
            var x = 1;
            var y = 1;
            // csharp_space_between_parentheses = false
            // 所有括號內都不加空白
            for ( int i = 0; i < 10; i++ ) { }
            var z = ( x * y ) - ( ( y - x ) * 3 );           
            int y = ( int )x;

            // 可獨立設定那些情況不要括號內要加空白
            // csharp_space_between_parentheses = control_flow_statements
            // for ( int i = 0; i < 10; i++ ) { }

            // csharp_space_between_parentheses = expressions
            // var z = ( x * y ) - ( ( y - x ) * 3 );

            // csharp_space_between_parentheses = type_casts
            // int y = ( int )x;
        }
    }
}
