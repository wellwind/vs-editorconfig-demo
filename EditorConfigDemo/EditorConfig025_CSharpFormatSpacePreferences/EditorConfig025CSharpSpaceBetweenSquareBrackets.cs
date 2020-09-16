using System.Collections.Generic;

namespace EditorConfigDemo.EditorConfig025_CSharpFormatSpacePreferences
{
    class EditorConfig025CSharpSpaceBetweenSquareBrackets
    {
        public static List<int> numbers = new List<int>() { 0, 1, 2 };

        // csharp_space_between_square_brackets = false
        public int index = numbers[ 0 ];
    }
}
