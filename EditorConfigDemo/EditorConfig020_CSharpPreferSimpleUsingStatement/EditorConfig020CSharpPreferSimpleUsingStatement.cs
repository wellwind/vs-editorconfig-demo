namespace EditorConfigDemo.EditorConfig020_CSharpPreferSimpleUsingStatement
{
    class EditorConfig020CSharpPreferSimpleUsingStatement
    {
        public void Test()
        {
            // csharp_prefer_simple_using_statement = true
            // 建議改為 using var fs = new System.IO.FileStream("test.txt", System.IO.FileMode.Open);
            using (var fs = new System.IO.FileStream("test.txt", System.IO.FileMode.Open))
            {
            }
        }
    }
}
