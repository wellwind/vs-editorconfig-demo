namespace EditorConfigDemo.EditorConfig023_CSharpFormatNewLinePreferences
{
    public class EditorConfig023CSharpNewLineBeforeMembersInObjectInitializers
    {
        public void Test()
        {
            // csharp_new_line_before_members_in_object_initializers = true
            var z = new User()
            {
                Name = "Mike", Age = 18
            };
        }
    }

    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

}
