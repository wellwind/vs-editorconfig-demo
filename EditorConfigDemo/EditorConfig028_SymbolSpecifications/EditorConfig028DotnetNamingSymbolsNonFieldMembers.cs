namespace EditorConfigDemo.EditorConfig028_SymbolSpecifications
{

    public class EditorConfig028DotnetNamingSymbolsNonFieldMembers
    {
        // dotnet_naming_symbols.non_field_members.applicable_kinds = property, event, method
        // dotnet_naming_symbols.non_field_members.applicable_accessibilities = public
        // dotnet_naming_rule.non_field_members_should_be_pascal_case.style = pascal_case
        // 由於此設定，因此非 public 的 class 都不用套用 pascal case 的規則
        // 將其改為 private 就不會看到錯誤
        public void method()
        {

        }

    }
}
