using System.Collections.Generic;
using System.Linq;

namespace EditorConfigDemo.EditorConfig023_CSharpFormatNewLinePreferences
{
    class EditorConfig023CSharpNewLineBetweenQueryExpressionClauses
    {
        public void Test()
        {
            var e = new List<int>() { 1, 2, 3 };

            // csharp_new_line_between_query_expression_clauses = true
            var q = from a in e from b in e 
                    select a * b;
        }
    }
}
