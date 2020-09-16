namespace EditorConfigDemo.EditorConfig025_CSharpFormatSpacePreferences
{
    class EditorConfig025CSharpSpaceBeforeDot
    {
        public void Test()
        {
            var mike = new User();
            // csharp_space_before_dot = false
            mike .Name = "Mike";
        }
    }

    class User
    {
        public string Name { get; set; }
    }
}
