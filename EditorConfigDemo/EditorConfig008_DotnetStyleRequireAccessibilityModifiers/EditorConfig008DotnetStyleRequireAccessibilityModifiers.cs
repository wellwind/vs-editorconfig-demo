namespace EditorConfigDemo.EditorConfig008_DotnetStyleRequireAccessibilityModifiers
{
    // dotnet_style_require_accessibility_modifiers = for_non_interface_members
    // 建議針對存取範圍加上修飾子 (private, public, internal, protected)
    class EditorConfig008DotnetStyleRequireAccessibilityModifiers
    {
        // dotnet_style_require_accessibility_modifiers = for_non_interface_members
        // 建議針對存取範圍加上修飾子 (private, public, internal, protected)
        const string name = "Mike";

        public string Test()
        {
            return name;
        }
    }
}
