namespace EditorConfigDemo.EditorConfig007_DotnetStyleParentheses
{
    public class EditorConfig007DotnetStyleParentheses
    {
        public void Test()
        {
            var a = 1;
            var b = 2;
            var c = 3;

            // dotnet_style_parentheses_in_arithmetic_binary_operators = always_for_clarity
            // 要求用括號明確標示算術順序，正確寫法為 a + (b * c)，因為先乘除後加減
            var num = a + b * c;
        }

        public void Test2()
        {
            var a = 1;
            var b = 2;
            var c = 3;
            var d = 4;

            // dotnet_style_parentheses_in_relational_binary_operators = always_for_clarity
            // 要求用括號明確標示關聯運算，正確寫法為 (a < b) == (c > d)
            var condition = a < b == c > d;
        }

        public void Test3()
        {
            var a = true;
            var b = true;
            var c = false;

            // dotnet_style_parentheses_in_other_binary_operators = always_for_clarity
            // 要求用括號明確標示布林運算順序，正確寫法為 a || (b && c)
            var result = a || b && c;
        }

        public void Test4()
        {
            var a = new
            {
                b = new[] { 1, 2, 3 }
            };

            // dotnet_style_parentheses_in_other_operators = never_if_unnecessary
            // dotnet_style_parentheses_in_other_operators 其他類型運算是否要用括號
            // never_if_unnecessary 代表不需要就不要加括號，以下程式並不需要加括號，正確寫法為 a.b.Length
            var result1 = (a.b).Length;

        }
    }
}
