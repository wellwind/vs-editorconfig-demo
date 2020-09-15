using System;

namespace EditorConfigDemo.EditorConfig017_CSharpPreferStaticLocalFunction
{
    class EditorConfig017CSharpPreferStaticLocalFunction
    {
        // csharp_prefer_static_local_function = true
        // 建議改成 static void Test() { }
        void Test()
        {
            Console.WriteLine("Hello");
        }
    }
}
