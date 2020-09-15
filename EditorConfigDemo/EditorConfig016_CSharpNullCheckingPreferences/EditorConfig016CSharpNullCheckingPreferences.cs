using System;

namespace EditorConfigDemo.EditorConfig016_CSharpNullCheckingPreferences
{
    class EditorConfig016CSharpNullCheckingPreferences
    {
        public Func<int, int> func = new Func<int, int>(x => x * x);

        public void Test()
        {
            // csharp_style_conditional_delegate_call = true
            // 建議改為 func?.Invoke(1);
            if (func != null) { func(1); }
        }
    }
}
