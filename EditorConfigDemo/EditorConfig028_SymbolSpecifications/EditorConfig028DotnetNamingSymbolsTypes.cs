namespace EditorConfigDemo.EditorConfig028_SymbolSpecifications
{

    public class EditorConfig028DotnetNamingSymbolsTypes
    {
        // dotnet_naming_symbols.types.applicable_kinds = class, struct, interface, enum
        // dotnet_naming_symbols.types.applicable_accessibilities = public
        // dotnet_naming_rule.types_should_be_pascal_case.style = pascal_case
        // 由於此設定，因此非 public 的 class 都不用套用 pascal case 的規則
        // 將其改為 private 就不會看到錯誤
        public class user
        {

        }

    }
}
