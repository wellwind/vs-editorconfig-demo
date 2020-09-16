namespace EditorConfigDemo.EditorConfig025_CSharpFormatSpacePreferences
{
    class EditorConfig025CSharpSpaceAfterCast
    {
        public void Test()
        {
            dynamic x = 1;
            // csharp_space_after_cast = false
            int _ = (int) x;
        }
    }
}
