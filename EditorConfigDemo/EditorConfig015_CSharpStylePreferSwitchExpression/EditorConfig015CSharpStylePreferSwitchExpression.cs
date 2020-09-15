namespace EditorConfigDemo.EditorConfig015_CSharpStylePreferSwitchExpression
{
    class EditorConfig015CSharpStylePreferSwitchExpression
    {
        public int Test()
        {
            var x = 1;
            // csharp_style_prefer_switch_expression = true
            // 建議改為
            // return x switch
            // {
            //     1 => 1 * 1,
            //     2 => 2 * 2,
            //     _ => 0,
            // };
            switch (x)
            {
                case 1:
                    return 1 * 1;
                case 2:
                    return 2 * 2;
                default:
                    return 0;
            }
        }
    }
}
