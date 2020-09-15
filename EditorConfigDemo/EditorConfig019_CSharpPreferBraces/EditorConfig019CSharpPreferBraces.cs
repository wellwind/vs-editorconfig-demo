namespace EditorConfigDemo.EditorConfig019_CSharpPreferBraces
{
    class EditorConfig019CSharpPreferBraces
    {
        public void Test()
        {
            var test = true;
            // csharp_prefer_braces = true
            // 建議寫法 if (test) { Display(); }
            if (test) Display();
        }

        public void Display()
        {

        }
    }
}
