namespace EditorConfigDemo.EditorConfig022_CsharpUsingDirectivePlacement
{
    // csharp_using_directive_placementcsharp_using_directive_placement = outside_namespace
    // using 應該在 namespace 外
    // 這條設定 error 不會報錯
    using System;

    class EditorConfig022CsharpUsingDirectivePlacement
    {
        public void Test()
        {
            Console.WriteLine("Hello");
        }
    }
}
