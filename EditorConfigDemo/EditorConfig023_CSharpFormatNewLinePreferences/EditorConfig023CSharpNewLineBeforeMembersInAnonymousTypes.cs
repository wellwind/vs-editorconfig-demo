namespace EditorConfigDemo.EditorConfig023_CSharpFormatNewLinePreferences
{
    class EditorConfig023CSharpNewLineBeforeMembersInAnonymousTypes
    {
        // csharp_new_line_before_members_in_anonymous_types = true
        public void Test()
        {
            var z = new
            {
                A = 3, B = 4
            };
        }
    }
}
