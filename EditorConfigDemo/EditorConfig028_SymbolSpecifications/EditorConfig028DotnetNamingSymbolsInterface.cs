namespace EditorConfigDemo.EditorConfig028_SymbolSpecifications
{
    
    public class EditorConfig028DotnetNamingSymbolsInterface
    {
        // dotnet_naming_symbols.interface.applicable_kinds = interface
        // dotnet_naming_symbols.interface.applicable_accessibilities = public
        // dotnet_naming_rule.interface_should_be_begins_with_i.style = begins_with_i
        // 由於此設定，因此非 public 的 interface 都不用套用 I 的規則
        // 將其改為 private 就不會看到錯誤
        public interface A
        {

        }
    }
}
