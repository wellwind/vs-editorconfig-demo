namespace EditorConfigDemo.EditorConfig011_DotnetCodeQualityUnusedParameters.NonPublic
{
    class EditorConfig011DotnetCodeQualityUnusedParametersNonPublic
    {
        // 依照 editorconfig 設定這邊應該不會被標示問題才對
        public int GetNum(int arg1) { return 1; }

        // dotnet_code_quality_unused_parameters = non_public
        // 只有非 public 的方法有沒用到的參數才會提示
        int GetNum2(int arg2) { return 2; }

        public void Test()
        {
            GetNum2(1);
        }
    }
}
