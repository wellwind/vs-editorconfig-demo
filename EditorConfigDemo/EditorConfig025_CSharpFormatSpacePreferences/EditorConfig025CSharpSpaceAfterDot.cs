namespace EditorConfigDemo. EditorConfig025_CSharpFormatSpacePreferences
{
    class EditorConfig025CSharpSpaceAfterDot
    {
        public void Test()
        {
            var mike = new Student();
            // csharp_space_after_dot = false
            mike. Name = "Mike";
        }
    }

    class Student
    {
        public string Name { get; set; }
    }
}
