namespace EditorConfigDemo.EditorConfig018_CSharpPreferredModifierOrder
{
    class EditorConfig018CSharpPreferredModifierOrder
    {
        // csharp_preferred_modifier_order 設定 static 應該在 private 之後
        // 因此建議改為 private static readonly int _daysInYear = 365;
        static private readonly int _daysInYear = 365;
    }
}
