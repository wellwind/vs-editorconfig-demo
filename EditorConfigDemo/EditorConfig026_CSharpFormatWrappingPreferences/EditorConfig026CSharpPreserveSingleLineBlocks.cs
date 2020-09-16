namespace EditorConfigDemo.EditorConfig026_CSharpFormatWrappingPreferences
{
    class EditorConfig026CSharpPreserveSingleLineBlocks
    {
        // csharp_preserve_single_line_blocks = true
        // 這條不會自動 format，建議寫法為 public int MyProperty { get; set; }
        // 但設成 false 會自動 format
        public int MyProperty
        {
            get; set;
        }
    }
}
