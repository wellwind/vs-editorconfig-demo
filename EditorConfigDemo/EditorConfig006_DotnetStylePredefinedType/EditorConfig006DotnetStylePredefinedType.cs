using System;

namespace EditorConfigDemo.EditorConfig006_DotnetStylePredefinedType
{
    // dotnet_style_predefined_type_for_* 系列設定在 format 時不會自動修正
    public class EditorConfig006DotnetStylePredefinedType
    {
        // 建議使用內建的關鍵字 int
        private Int32 _member;

        public void Test()
        {
            // 建議使用內建的關鍵字 int
            var local = Int32.MaxValue;
        }
    }
}
