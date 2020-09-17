namespace EditorConfigDemo.EditorConfig027_CSharpNamingRules
{
    class EditorConfig027DotnetNamingRuleNonFieldMembersShouldBePascalCase
    {
        // field ok
        public string name = "Mike";

        // dotnet_naming_rule.non_field_members_should_be_pascal_case
        // 非 field 應該以 pascal case 的規則命名
        public string sex
        {
            get { return "F";  }
        }

        public void method()
        {
        }

    }
}
